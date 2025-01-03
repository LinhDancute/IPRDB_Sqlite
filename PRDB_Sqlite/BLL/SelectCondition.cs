using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PRDB_Sqlite.BLL
{
    public class SelectCondition
    {
        public ProbRelation relations { get; set; }
        public ProbTuple tuple { get; set; }
        public string conditionString { get; set; }
        public string MessageError { get; set; }

        static public string[] Operator = new string[15] { "_<", "_>", "<=", ">=", "_=", "!=", "⊗_in", "⊗_ig", "⊗_me", "⊕_in", "⊕_ig", "⊕_me", "equal_in", "equal_ig", "equal_me" };
        private readonly List<ProbAttribute> Attributes = new List<ProbAttribute>();
        public Dictionary<string, bool> dictProb = new Dictionary<string, bool>();
        public Dictionary<string, bool> dictCon = new Dictionary<string, bool>();
        public List<ConditionModel> conditionModels = new List<ConditionModel>();
        public string[] subCondition;
        public ProbDatabase probDatabase { get; set; }

        public SelectCondition()
        {
            dictProb = new Dictionary<string, bool>();
            dictCon = new Dictionary<string, bool>();
            conditionModels = new List<ConditionModel>();
            Attributes = new List<ProbAttribute>();
            MessageError = string.Empty;
        }
        public SelectCondition(ProbRelation probRelation, string conditionString, ProbDatabase probDatabase)
        {
            this.relations = probRelation;
            this.conditionString = conditionString.Trim();
            this.Attributes = probRelation.Scheme.Attributes;
            this.probDatabase = probDatabase; // Assign probDatabase
            this.MessageError = string.Empty;
            dictProb = new Dictionary<string, bool>();
            dictCon = new Dictionary<string, bool>();
            conditionModels = new List<ConditionModel>();

            // Standardize condition string
            int i = 0;
            while (i < this.conditionString.Length - 1)
            {
                if (this.conditionString[i] == '<' && this.conditionString[i + 1] != '=')
                    this.conditionString = this.conditionString.Insert(i++, "_");
                if (this.conditionString[i] == '>' && this.conditionString[i + 1] != '=')
                    this.conditionString = this.conditionString.Insert(i++, "_");
                if (this.conditionString[i] == '=' && this.conditionString[i - 1] != '!' && this.conditionString[i - 1] != '<' && this.conditionString[i - 1] != '>')
                    this.conditionString = this.conditionString.Insert(i++, "_");
                i++;
            }
        }

        #region kiểm tra bộ có thỏa mãn điều kiện chọn


        //public bool Satisfied(ProbTuple tuple)
        //{
        //    this.tuple = tuple;

        //    foreach (var condition in conditionModels)
        //    {
        //        bool isConditionSatisfied = false;

        //        foreach (var t in tuple.Triples)
        //        {
        //            for (int i = 0; i < t.Values.Count; i++)
        //            {
        //                string tripleValue = t.Values[i]?.ToString().Trim();
        //                double minProb = t.MinProbs[i];
        //                double maxProb = t.MaxProbs[i];

        //                Debug.WriteLine($"Checking value: {tripleValue}, Probabilities: [{minProb}, {maxProb}]");

        //                string conditionValue = condition.StrategyModels[0].AttributeValue.Trim();
        //                string opratorStr = condition.StrategyModels[0].OperatorStrOfTriple;
        //                string typename = "string";

        //                bool isValueMatch = CompareTriple(tripleValue, conditionValue, opratorStr, typename);

        //                if (opratorStr != "⊗_ig")
        //                {
        //                    // Basic range filtering for simple queries
        //                    bool isProbMatch = condition.MinProb <= minProb && condition.MaxProb >= maxProb;

        //                    if (isValueMatch && isProbMatch)
        //                    {
        //                        Debug.WriteLine($"Condition satisfied: Value={tripleValue}, MinProb={minProb}, MaxProb={maxProb}");
        //                        isConditionSatisfied = true;
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    // Handle ⊗_ig operator
        //                    double minProbCondition = condition.MinProb ?? 0.0; // Default to 0.0 if null
        //                    double maxProbCondition = condition.MaxProb ?? 1.0; // Default to 1.0 if null

        //                    // Combine probabilities for ⊗_ig
        //                    bool isProbMatch = CombineProbabilityIntervals(
        //                        "⊗_ig",
        //                        minProbCondition,
        //                        maxProbCondition,
        //                        minProb,
        //                        maxProb,
        //                        out double combinedMinProb,
        //                        out double combinedMaxProb
        //                    ) && combinedMinProb >= 0.3 && combinedMaxProb <= 1;

        //                    if (isValueMatch && isProbMatch)
        //                    {
        //                        Debug.WriteLine($"Condition satisfied: CombinedMinProb={combinedMinProb}, CombinedMaxProb={combinedMaxProb}");
        //                        isConditionSatisfied = true;
        //                        break;
        //                    }
        //                }
        //            }

        //            if (isConditionSatisfied)
        //                break;
        //        }

        //        if (!isConditionSatisfied)
        //        {
        //            Debug.WriteLine("Condition evaluation failed.");
        //            return false;
        //        }
        //    }

        //    return true;
        //}





        public bool Satisfied(ProbTuple tuple)
        {
            this.tuple = tuple;

            foreach (var condition in conditionModels)
            {
                if (EvaluateCondition(tuple, condition))
                {
                    // For "OR", if any condition passes, the tuple is valid
                    return true;
                }
            }

            // If no conditions pass, the tuple is invalid
            return false;
        }


        private bool EvaluateCondition(ProbTuple tuple, ConditionModel condition)
        {
            string targetColumn = condition.StrategyModels[0].AttributeName.ToLower();

            int targetIndex = FindColumnIndex(targetColumn);
            if (targetIndex == -1)
            {
                Debug.WriteLine($"Column '{targetColumn}' not found.");
                return false;
            }

            var t = tuple.Triples[targetIndex];

            // Handle composite conditions with ⊗_ig or sequential AND logic
            if (condition.StrategyModels[0].OperatorStrOfTriple.Contains("⊗_ig"))
            {
                return ValidateCompositeTriple(t, condition);
            }

            return ValidateTriple(t, condition);
        }


        private int FindColumnIndex(string targetColumn)
        {
            return relations.Scheme.Attributes.FindIndex(attr =>
                attr.AttributeName.Equals(targetColumn, StringComparison.OrdinalIgnoreCase) ||
                attr.AttributeName.EndsWith($".{targetColumn}", StringComparison.OrdinalIgnoreCase));
        }

        private bool ValidateCompositeTriple(ProbTriple triple, ConditionModel condition)
        {
            // Initialize composite probabilities
            double compositeMin = 0.0;
            double compositeMax = 1.0;

            // Iterate through all values and calculate combined probabilities
            for (int i = 0; i < triple.Values.Count; i++)
            {
                string tripleValue = triple.Values[i]?.ToString().Trim();
                double minProb = triple.MinProbs[i];
                double maxProb = triple.MaxProbs[i];

                if (IsValueValid(tripleValue, condition, minProb, maxProb))
                {
                    // Combine probabilities using ⊗_ig
                    var combinedProbs = CombineProbabilities(compositeMin, compositeMax, minProb, maxProb);
                    compositeMin = combinedProbs[0];
                    compositeMax = combinedProbs[1];
                }
            }

            Debug.WriteLine($"Composite Probabilities After ⊗_ig: Min={compositeMin}, Max={compositeMax}");

            // Validate cumulative probabilities
            if (compositeMin < condition.MinProb || compositeMax > condition.MaxProb)
            {
                Debug.WriteLine("Tuple invalid due to composite probabilities.");
                return false;
            }

            return true;
        }

        private bool ValidateTriple(ProbTriple triple, ConditionModel condition)
        {
            double cumulativeMinProb = 0.0;
            double cumulativeMaxProb = 0.0;

            var validValues = new List<object>();
            var validMinProbs = new List<double>();
            var validMaxProbs = new List<double>();

            for (int i = 0; i < triple.Values.Count; i++)
            {
                string tripleValue = triple.Values[i]?.ToString().Trim();
                double minProb = triple.MinProbs[i];
                double maxProb = triple.MaxProbs[i];

                if (IsValueValid(tripleValue, condition, minProb, maxProb))
                {
                    validValues.Add(triple.Values[i]);
                    validMinProbs.Add(minProb);
                    validMaxProbs.Add(maxProb);

                    cumulativeMinProb = Math.Min(1, cumulativeMinProb + minProb);
                    cumulativeMaxProb = Math.Min(1, cumulativeMaxProb + maxProb);
                }
            }

            Debug.WriteLine($"Cumulative Probabilities: Min={cumulativeMinProb}, Max={cumulativeMaxProb}");

            if (cumulativeMinProb < condition.MinProb || cumulativeMaxProb > condition.MaxProb)
            {
                Debug.WriteLine("Tuple invalid due to cumulative probabilities.");
                return false;
            }

            // Update triple with valid values
            triple.Values = validValues;
            triple.MinProbs = validMinProbs;
            triple.MaxProbs = validMaxProbs;

            return true;
        }

        private double[] CombineProbabilities(double l1, double u1, double l2, double u2)
        {
            double combinedMin = Math.Max(0, l1 + l2 - 1);
            double combinedMax = Math.Min(u1, u2);

            return new double[] { combinedMin, combinedMax };
        }

        private bool IsValueValid(string value, ConditionModel condition, double minProb, double maxProb)
        {
            string operatorStr = condition.StrategyModels[0].OperatorStrOfTriple;
            string conditionValue = condition.StrategyModels[0].AttributeValue.Trim();

            if (double.TryParse(value, out double numericValue) &&
                double.TryParse(conditionValue, out double conditionNumericValue))
            {
                if (!DoubleCompare(numericValue, conditionNumericValue, operatorStr))
                {
                    Debug.WriteLine($"Value invalid: {numericValue} {operatorStr} {conditionNumericValue}");
                    return false;
                }
            }
            else
            {
                if (!CompareTriple(value, conditionValue, operatorStr, "string"))
                {
                    Debug.WriteLine($"String comparison failed: {value} {operatorStr} {conditionValue}");
                    return false;
                }
            }

            return true;
        }

        public void ProcessConditionString()
        {
            string conditionStr = this.conditionString;

            // Regex for simple conditions
            string simpleConditionPattern = @"\(\s*([a-zA-Z0-9._]+)\s*([><=!_]+)\s*(['""]?[a-zA-Z0-9._\s]+['""]?|[\d.]+)\s*\)\s*\[\s*([\d.]+)\s*,\s*([\d.]+)\s*\]";
            Regex regexSimple = new Regex(simpleConditionPattern);

            // Check whether the condition contains "OR" or "AND"
            bool isOrQuery = conditionStr.Contains("or");
            bool isAndQuery = conditionStr.Contains("and");

            // Handle "OR" logic
            if (isOrQuery)
            {
                // Split the entire condition into "OR" groups
                var orConditions = conditionStr.Split(new[] { "and" }, StringSplitOptions.RemoveEmptyEntries);

                // Initialize a set to store unique results across all "OR" groups
                HashSet<ProbTuple> finalResults = new HashSet<ProbTuple>();

                foreach (var orCondition in orConditions)
                {
                    // Process each "OR" condition independently
                    var matches = regexSimple.Matches(orCondition);

                    if (matches.Count > 0)
                    {
                        Debug.WriteLine($"Processing OR Condition: {orCondition}");

                        // Handle matches for the current "OR" condition
                        HandleMatches(matches, ref conditionStr);

                        // Filter tuples for the current "OR" condition
                        HashSet<ProbTuple> currentResults = new HashSet<ProbTuple>(
                            relations.Tuples.Where(tuple =>
                            {
                                this.tuple = tuple;
                                return Satisfied(tuple);
                            })
                        );

                        // Add the results of this "OR" condition to the final results (union)
                        finalResults.UnionWith(currentResults);
                    }
                    else
                    {
                        this.MessageError = "Invalid condition format.";
                        return;
                    }
                
            }

                // Update the final results after evaluating all "OR" conditions
                relations.Tuples = finalResults.ToList();
                Debug.WriteLine($"Final results filtered by combined OR conditions: {finalResults.Count} tuples.");
            }
            // Handle "AND" logic
            else if (isAndQuery)
            {
                // "AND" Logic
                Debug.WriteLine("Processing AND conditions...");

                // Split the condition into "AND" groups
                var andConditions = conditionStr.Split(new[] { "and" }, StringSplitOptions.RemoveEmptyEntries);

                // Initialize a set for the intersection of "AND" conditions
                HashSet<ProbTuple> finalResults = new HashSet<ProbTuple>(relations.Tuples);

                foreach (var andCondition in andConditions)
                {
                    // Process each "AND" condition independently
                    var matches = regexSimple.Matches(andCondition);

                    if (matches.Count > 0)
                    {
                        Debug.WriteLine($"Processing AND Condition: {andCondition}");

                        // Handle matches for the current "AND" condition
                        HandleMatches(matches, ref conditionStr);

                        // Filter tuples for the current "AND" condition
                        HashSet<ProbTuple> currentResults = new HashSet<ProbTuple>(
                            relations.Tuples.Where(tuple =>
                            {
                                this.tuple = tuple;
                                return Satisfied(tuple);
                            })
                        );

                        Debug.WriteLine($"Current Results for AND Condition: {currentResults.Count} tuples.");

                        // Intersect the current results with the final results
                        finalResults.IntersectWith(currentResults);
                    }
                    else
                    {
                        this.MessageError = "Invalid condition format.";
                        return;
                    }
                }

                // Update the final results after evaluating all "AND" conditions
                relations.Tuples = finalResults.ToList();
                Debug.WriteLine($"Final results filtered by combined AND conditions: {finalResults.Count} tuples.");
            }
            else
            {
                // Handle single conditions
                Debug.WriteLine("Processing single condition...");
                var matches = regexSimple.Matches(conditionStr);

                if (matches.Count > 0)
                {
                    Debug.WriteLine($"Processing Single Condition: {conditionStr}");

                    // Handle matches for the single condition
                    HandleMatches(matches, ref conditionStr);

                    // Filter tuples for the single condition
                    relations.Tuples = relations.Tuples.Where(tuple =>
                    {
                        this.tuple = tuple;
                        return Satisfied(tuple);
                    }).ToList();

                    Debug.WriteLine($"Final results filtered by single condition: {relations.Tuples.Count} tuples.");
                }
                else
                {
                    this.MessageError = "Invalid condition format.";
                    return;
                }
            }
        }

        










        // Helper method to handle matches
        private void HandleMatches(MatchCollection matches, ref string conditionStr)
        {
            var allMatches = new List<string>();
            foreach (Match match in matches)
            {
                allMatches.Add(match.Value);
            }

            // Extract and replace conditions with placeholders
            string[] subConditionHaveProbability = allMatches.ToArray();
            for (int i = 0; i < subConditionHaveProbability.Length; i++)
            {
                Debug.WriteLine($"Matched Condition: {subConditionHaveProbability[i]}");
                conditionStr = conditionStr.Replace(subConditionHaveProbability[i], $"ConditionProb_{i}");
            }

            // Convert subconditions with probabilities into models
            if (subConditionHaveProbability.Length > 0)
            {
                ConvertStringToModel(subConditionHaveProbability);
            }
        }


        private static int GetTotalSubCondition(string conditionStr, int degree, Regex regexCondition)
        {
            var timeCondition = 1;
            for (int i = 0; i < degree; i++)
            {
                var listCondition = regexCondition.Matches(conditionStr);

                for (int j = 0; j < listCondition.Count; j++)
                {
                    timeCondition++;
                }
            }

            return timeCondition;
        }

        private string[] GetArrayCondition(string conditionStr)
        {
            string[] listConditionProb;
            var option = conditionStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (option.Count() == 1 && !option[0].Contains("ConditionProb_") && !option[0].Contains("Condition_"))
            {
                MessageError = string.Format("An expression of non-boolean type specified in a context where a condition is expected, near '{0}'.", option[0]);
                return null;
            }
            var count = 0;
            for (int i = 0; i < option.Count(); i++)
            {
                if (Common.ConditionNormalString.Contains(option[i]))
                {
                    count++;
                }
            }

            var count3 = 0;
            listConditionProb = new string[(count * 2) + 1];
            foreach (var item in option)
            {
                if (Common.ConditionNormalString.Contains(item))
                {
                    count3++;
                    listConditionProb[count3] = item;
                    count3++;
                    continue;
                }
                listConditionProb[count3] += item;
            }

            foreach (string item in listConditionProb)
            {
                if (Common.ConditionNormalString.Contains(item)) continue;

                if(item.Contains("ConditionProb_") && item.Trim().Length > 15)
                {
                    MessageError = string.Format("An expression of non-boolean type specified in a context where a condition is expected, near 'Where'.");
                    return null;
                }

                if (item.Contains("Condition_") && item.Trim().Length > 11)
                {
                    MessageError = string.Format("An expression of non-boolean type specified in a context where a condition is expected, near 'Where'.");
                    return null;
                }

                if (!item.Contains("Condition_") && !item.Contains("ConditionProb_") && string.IsNullOrEmpty(IsOperatior(item)))
                {
                    MessageError = string.Format("An expression of non-boolean type specified in a context where a condition is expected, near 'Where'.");
                    return null;
                }
            }

            return listConditionProb.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        private void CalculateConditionProb()
        {
            for (int i = 0; i < conditionModels.Count(); i++)
            {
                if (conditionModels[i].OperatorStrategy != null)
                {
                    string[] conditionArray = new string[conditionModels[i].OperatorStrategy.Count * 2 + 1];

                    var listProb = new List<double>();
                    int k = 0;
                    for (int j = 0; j < conditionModels[i].StrategyModels.Count; j++)
                    {
                        var strategyModel = conditionModels[i].StrategyModels[j];
                        var prob = GetProbIntervalV3(strategyModel.AttributeName, strategyModel.AttributeValue, strategyModel.OperatorStrOfTriple);

                        if (prob == null)
                        {
                            return;
                        }

                        conditionArray[k] = prob[0].ToString() + "-" + prob[1].ToString();
                        if (j != (conditionModels[i].StrategyModels.Count - 1))
                            conditionArray[k + 1] = conditionModels[i].OperatorStrategy[j];
                        k = k + 2;
                    }

                    List<string[]> listResult = new List<string[]>();
                    int d = 0;
                    for (int j = 0; j < conditionArray.Length; j++)
                    {
                        if (conditionArray[j].Contains("⊕"))
                        {
                            listResult.Add(conditionArray.Skip(j - d).Take(d).ToArray());
                            listResult.Add(conditionArray.Skip(j).Take(1).ToArray());
                            d = 0;
                        }
                        else
                        {
                            if (j == conditionArray.Length - 1)
                            {
                                listResult.Add(conditionArray.Skip(j - d).Take(d + 1).ToArray());
                                break;
                            }
                            d++;
                        }
                    }

                    var listString = new List<string>();
                    foreach (var item in listResult)
                    {

                        if (item.Length > 1)
                        {
                            listString.Add(ConjunctionStrategy(item));
                        }
                        else
                        {
                            listString.Add(item[0]);
                        }
                    }

                    dictProb.Add("ConditionProb_" + i.ToString(), DisjunctionStrategy(listString, conditionModels[i].MinProb.Value, conditionModels[i].MaxProb.Value));
                }
                else
                {
                    dictProb.Add("ConditionProb_" + i.ToString(), GetProbIntervalV2(conditionModels[i].StrategyModels[0].AttributeName, conditionModels[i].StrategyModels[0].AttributeValue, conditionModels[i].StrategyModels[0].OperatorStrOfTriple, conditionModels[i].MaxProb, conditionModels[i].MinProb));
                }
            }
        }

        public string ConjunctionStrategy(string[] arrayInput)
        {
            var tmpOne = arrayInput[0].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            double maxProb = double.Parse(tmpOne[1]);
            double minProb = double.Parse(tmpOne[0]);
            double minProbOne = 0; double maxProbOne = 0;

            for (int i = 1; i < arrayInput.Length; i++)
            {
                if (arrayInput[i].Contains("⊗"))
                {
                    var tmp = arrayInput[i + 1].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    minProbOne = double.Parse(tmp[0]);
                    maxProbOne = double.Parse(tmp[1]);

                    if (arrayInput[i].Contains("⊗_ig"))
                    {
                        minProb = Math.Max(0, minProbOne + minProb - 1); maxProb = Math.Min(maxProbOne, maxProb);
                    }
                    else if (arrayInput[i].Contains("⊗_in"))
                    {
                        minProb = minProbOne * minProb; maxProb = maxProbOne * maxProb;
                    }
                    else
                    {
                        minProb = 0; maxProb = 0;
                    }

                    i = i + 1;
                }
            }

            return minProb.ToString() + "-" + maxProb.ToString();
        }

        public bool DisjunctionStrategy(List<string> listDisjunction, double minProd, double maxProb)
        {
            var tmpOne = listDisjunction[0].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            double minProbOne = double.Parse(tmpOne[1]);
            double maxProbOne = double.Parse(tmpOne[0]);
            double minProbTwo = 0; double maxProbTwo = 0;

            for (int i = 1; i < listDisjunction.Count; i++)
            {
                if (listDisjunction[i].Contains("⊕"))
                {
                    var tmp = listDisjunction[i + 1].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    minProbTwo = double.Parse(tmp[0]);
                    maxProbTwo = double.Parse(tmp[1]);

                    if (listDisjunction[i].Contains("⊕_ig"))
                    {
                        minProbOne = Math.Max(minProbOne, minProbTwo); maxProbOne = Math.Min(1, maxProbOne + maxProbTwo);
                    }
                    else if (listDisjunction[i].Contains("⊕_in"))
                    {
                        minProbOne = minProbOne + minProbTwo - (minProbOne * minProbTwo); maxProbOne = maxProbOne + maxProbTwo - (maxProbOne * maxProbTwo);
                    }
                    else
                    {
                        minProbOne = Math.Min(1, minProbOne + minProbTwo); maxProbOne = Math.Min(1, maxProbOne + maxProbTwo);
                    }

                    i = i + 1;
                }
            }

            return minProd <= minProbOne && maxProbOne <= maxProb;
        }

       

        public void ConvertStringToModel(string[] subConditionHaveProbability)
        {
            try
            {
                conditionModels.Clear(); // Clear previous conditions
                foreach (var conditionString in subConditionHaveProbability)
                {
                    Debug.WriteLine($"Converting SubCondition: {conditionString}");

                    // Regex to parse both simple and composite conditions
                    string pattern = @"\(\s*([a-zA-Z0-9._]+)\s*([><=!_]+)\s*(['""]?[a-zA-Z0-9._\s]+['""]?|\d+(\.\d+)?)\s*"
                                   + @"(⊗_ig|⊕_ig|⊗_in|⊕_in|⊗_me|⊕_me)?\s*"
                                   + @"\(?([a-zA-Z0-9._]+)?\s*([><=!_]+)?\s*(['""]?[a-zA-Z0-9._\s]+['""]?)?\)?"
                                   + @"\[\s*(\d+(\.\d+)?)\s*,\s*(\d+(\.\d+)?)\s*\]";

                    var match = Regex.Match(conditionString, pattern);

                    if (match.Success)
                    {
                        string attributeName = match.Groups[1].Value.Trim();
                        string operatorStr = match.Groups[2].Value.Trim();
                        string attributeValue = match.Groups[3].Value.Trim().Trim('\'', '"');
                        string compositeOperator = match.Groups[5].Value.Trim(); // Composite operator (e.g., ⊗_ig)
                        string secondaryAttributeName = match.Groups[6].Value.Trim(); // Secondary attribute (if composite)
                        string secondaryOperator = match.Groups[7].Value.Trim(); // Secondary operator
                        string secondaryValue = match.Groups[8].Value.Trim().Trim('\'', '"'); // Secondary value
                        double minProb = double.Parse(match.Groups[9].Value.Trim());
                        double maxProb = double.Parse(match.Groups[11].Value.Trim());

                        Debug.WriteLine($"Parsed Attribute: {attributeName}, Operator: {operatorStr}, Value: {attributeValue}, CompositeOperator: {compositeOperator}, Secondary Attribute: {secondaryAttributeName}, Secondary Operator: {secondaryOperator}, Secondary Value: {secondaryValue}, MinProb: {minProb}, MaxProb: {maxProb}");

                        // Add parsed condition to the list
                        conditionModels.Add(new ConditionModel
                        {
                            StrategyModels = new List<StrategyModel>
                    {
                        new StrategyModel
                        {
                            AttributeName = attributeName,
                            OperatorStrOfTriple = compositeOperator == string.Empty ? operatorStr : $"{operatorStr} {compositeOperator} {secondaryOperator}",
                            AttributeValue = compositeOperator == string.Empty ? attributeValue : $"{attributeValue} {secondaryOperator} {secondaryValue}"
                        }
                    },
                            MinProb = minProb,
                            MaxProb = maxProb
                        });
                    }
                    else
                    {
                        Debug.WriteLine("Failed to parse subcondition: " + conditionString);
                    }
                }

                Debug.WriteLine($"Total Parsed Conditions: {conditionModels.Count}");
            }
            catch (Exception ex)
            {
                MessageError = $"Error parsing condition: {ex.Message}";
                Debug.WriteLine(MessageError);
            }
        }





        private void CalculateConditionStr(string[] subCondition)
        {
            Dictionary<string, bool> dict = new Dictionary<string, bool>();

            subCondition = subCondition.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (subCondition.Length == 0)
            {
                return;
            }

            try
            {
                for (int i = 0; i < subCondition.Count(); i++)
                {
                    var listConditionProb = GetArrayCondition(subCondition[i]);

                    string result = string.Empty;
                    for (int j = 0; j < listConditionProb.Count(); j++)
                    {
                        if (Common.ConditionNormalString.Contains(listConditionProb[j]))
                        {
                            var s = CompareCharacters(listConditionProb[j]);
                            if (string.IsNullOrEmpty(s))
                            {
                                MessageError = string.Format("Incorrect syntax near the keyword.");
                                return;
                            }
                            result += s;
                        }
                        else
                        {
                            if (listConditionProb[j].Contains("ConditionProb_"))
                            {
                                foreach (var item in dictProb)
                                {
                                    if (item.Key == listConditionProb[j].Trim())
                                    {
                                        result += item.Value ? "1" : "0";
                                    }
                                }

                            }
                            else
                            {
                                if (listConditionProb[j].Contains("Condition_"))
                                {
                                    foreach (var item in dictCon)
                                    {
                                        if (item.Key == listConditionProb[j].Trim())
                                        {
                                            result += item.Value ? "1" : "0";
                                        }
                                    }
                                }
                                else
                                {
                                    var operatorStr = IsOperatior(listConditionProb[j]);
                                    if (!string.IsNullOrEmpty(operatorStr))
                                    {
                                        string[] seperator = { operatorStr };
                                        string[] attribute = listConditionProb[j].Split(seperator, StringSplitOptions.RemoveEmptyEntries);

                                        if (attribute.Count() != 2)
                                        {
                                            MessageError = string.Format("Incorrect syntax near the keyword {0}.", operatorStr);
                                            return;
                                        }
                                        var attributeName = attribute[0];
                                        var attributeValue = attribute[1];
                                        result += GetProbIntervalV2(attributeName.Trim(), attributeValue.Trim(), operatorStr) ? "1" : "0";
                                    }
                                }
                            }
                        }
                    }
                    dict.Add("Condition_" + i.ToString(), CalculationCon(result));
                }
                dictCon = dict;
            }
            catch
            {
                MessageError = "Incorrect syntax near 'where'.";
                return;
            }

        }

        private bool CalculateTotalCondition(string[] listConditionProb)
        {
            var totalOfList = listConditionProb.Count();
            string result = string.Empty;

            for (int i = 0; i < totalOfList; i++)
            {
                if (Common.ConditionNormalString.Contains(listConditionProb[i]))
                {
                    var s = CompareCharacters(listConditionProb[i]);
                    if (string.IsNullOrEmpty(s))
                    {
                        MessageError = string.Format("Incorrect syntax near the keyword.");
                        return false;
                    }
                    result += s;
                }
                else
                {
                    var operatorStr = IsOperatior(listConditionProb[i]);
                    if (!string.IsNullOrEmpty(operatorStr))
                    {
                        string[] seperator = { operatorStr };
                        string[] attribute = listConditionProb[i].Split(seperator, StringSplitOptions.RemoveEmptyEntries);

                        if (attribute.Count() != 2)
                        {
                            MessageError = string.Format("Incorrect syntax near the keyword {0}.", operatorStr);
                            return false;
                        }
                        var attributeName = attribute[0];
                        var attributeValue = attribute[1];
                        result += GetProbIntervalV2(attributeName.Trim(), attributeValue.Trim(), operatorStr) ? "1" : "0";
                    }
                    else
                    {
                        if (listConditionProb[i].Contains("ConditionProb_"))
                        {
                            foreach (var item in dictProb)
                            {
                                if (item.Key == listConditionProb[i].Trim())
                                {
                                    result += item.Value ? "1" : "0";
                                }
                            }
                        }
                        if (listConditionProb[i].Contains("Condition_"))
                        {
                            foreach (var item in dictCon)
                            {
                                if (item.Key == listConditionProb[i].Trim())
                                {
                                    result += item.Value ? "1" : "0";
                                }
                            }
                        }
                    }
                }
            }

            return CalculationCon(result);
        }

        private string IsOperatior(string s)
        {
            for (int i = 0; i < 6; i++)
            {
                if (s.Contains(Operator[i]))
                    return Operator[i];
            }
            return string.Empty;
        }

        private string IsOperatiorStrategy(string s)
        {
            for (int i = 6; i < 12; i++)
            {
                if (s.Contains(Operator[i]))
                    return Operator[i];
            }
            return string.Empty;
        }

        private string CompareCharacters(string s)
        {
            switch (s)
            {
                case "or": return "|";
                case "and": return "&";
                case "not": return "!";
                //bo xung them
                default: return string.Empty;
            }
        }

        private bool GetProbIntervalV2(string valueOne, string valueTwo, string operatorStr, double? maxProbOfCon = null, double? minProbOfCon = null)
        {
            Debug.WriteLine($"Evaluating condition: {valueOne} {operatorStr} {valueTwo} with Prob Interval [{minProbOfCon}, {maxProbOfCon}]");
            int indexOne = this.IndexOfAttribute(valueOne);
            if (indexOne == -1)
            {
                this.MessageError = $"Attribute '{valueOne}' not found.";
                Debug.WriteLine(this.MessageError);
                return false;
            }

            ProbTuple tuple = this.tuple;
            var listValue = tuple.Triples[indexOne].Values;
            var minProbs = tuple.Triples[indexOne].MinProbs;
            var maxProbs = tuple.Triples[indexOne].MaxProbs;

            for (int i = 0; i < listValue.Count; i++)
            {
                string tupleValue = listValue[i]?.ToString().ToLower();
                string conditionValue = valueTwo.ToLower();

                Debug.WriteLine($"Checking tuple value: {tupleValue}, Probabilities: [{minProbs[i]}, {maxProbs[i]}]");

                if (CompareTriple(tupleValue, conditionValue, operatorStr, "string"))
                {
                    double currentMinProb = minProbs[i];
                    double currentMaxProb = maxProbs[i];

                    if (minProbOfCon.HasValue && maxProbOfCon.HasValue)
                    {
                        if (currentMinProb >= minProbOfCon.Value && currentMaxProb <= maxProbOfCon.Value)
                        {
                            Debug.WriteLine("Condition satisfied with probabilities.");
                            return true;
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Condition satisfied without probability constraints.");
                        return true;
                    }
                }
            }

            Debug.WriteLine("No matching value found.");
            return false;
        }


        private string HandleQuotedString(string value)
        {
            if (value.Contains("'"))
            {
                int count = value.Count(c => c == '\'');
                if (value[0] != '\'' || value[value.Length - 1] != '\'' || count != 2)
                {
                    MessageError = "Unclosed quotation mark in the string '" + value + "'.";
                    return null;
                }

                return value.Trim('\'');
            }

            return value;
        }

        private bool TryParseInterval(string interval, out double minProb, out double maxProb)
        {
            minProb = 0;
            maxProb = 0;

            try
            {
                string[] parts = interval.Trim('[', ']').Split(',');
                if (parts.Length != 2) return false;

                minProb = Convert.ToDouble(parts[0]);
                maxProb = Convert.ToDouble(parts[1]);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool CombineProbabilityIntervals(string operatorStr, double minProbOne, double maxProbOne, double minProbTwo, double maxProbTwo, out double minProb, out double maxProb)
        {
            minProb = 0;
            maxProb = 0;

            switch (operatorStr)
            {
                case "⊗_ig":
                    minProb = Math.Max(0, minProbOne + minProbTwo - 1); // Lower bound
                    maxProb = Math.Min(maxProbOne, maxProbTwo);         // Upper bound
                    return true;

                case "⊗_in":
                    minProb = minProbOne * minProbTwo;
                    maxProb = maxProbOne * maxProbTwo;
                    return true;

                case "⊗_me":
                    minProb = 0;
                    maxProb = 0;
                    return true;

                case "⊕_ig":
                    minProb = Math.Max(minProbOne, minProbTwo);
                    maxProb = Math.Min(1, maxProbOne + maxProbTwo);
                    return true;

                case "⊕_in":
                    minProb = minProbOne + minProbTwo - (minProbOne * minProbTwo);
                    maxProb = maxProbOne + maxProbTwo - (maxProbOne * maxProbTwo);
                    return true;

                case "⊕_me":
                    minProb = Math.Min(1, minProbOne + minProbTwo);
                    maxProb = Math.Min(1, maxProbOne + maxProbTwo);
                    return true;

                default:
                    Debug.WriteLine($"Unsupported operator: {operatorStr}");
                    return false;
            }
        }


        private List<double> GetProbIntervalV3(string valueOne, string valueTwo, string operaterStr)
        {
            double minProb = 0, maxProb = 0;
            int indexOne, countTripleOne;
            ProbTuple tuple = this.tuple;

            try
            {
                if (SelectCondition.isCompareOperator(operaterStr))     // Biểu thức so sánh giữa một thuộc tính với một giá trị
                {
                    indexOne = this.IndexOfAttribute(valueOne); // vị trí của thuộc tính trong ds các thuộc tính
                    if (indexOne == -1)
                        return null;

                    if (valueTwo.Contains("'"))
                    {
                        int count = valueTwo.Split(new char[] { '\'' }).Length - 1;

                        if (valueTwo.Substring(0, 1) != "'")
                        {
                            MessageError = "Unclosed quotation mark before the character string " + valueTwo;
                            return null;
                        }

                        if (valueTwo.Substring(valueTwo.Length - 1, 1) != "'")
                        {
                            MessageError = "Unclosed quotation mark after the character string " + valueTwo;
                            return null;
                        }

                        if (count != 2)
                        {
                            MessageError = "Unclosed quotation mark at the character string " + valueTwo;
                            return null;
                        }

                        valueTwo = valueTwo.Remove(0, 1);
                        valueTwo = valueTwo.Remove(valueTwo.Length - 1, 1);
                    }

                    #region ProbDataType
                    ProbDataType dataType = new ProbDataType();
                    dataType.TypeName = Attributes[indexOne].Type.TypeName;
                    dataType.DataType = Attributes[indexOne].Type.DataType;
                    dataType.Domain = Attributes[indexOne].Type.Domain;
                    dataType.DomainString = Attributes[indexOne].Type.DomainString;
                    #endregion

                    // Kiểm tra dữ liệu có thể chuyển đổi được không
                    if (!dataType.CheckDataTypeOfVariables(valueTwo))
                    {
                        MessageError = String.Format("Conversion failed when converting the varchar value {0} to data type {1}.", valueTwo, dataType.DataType);
                        return null;
                    }

                    #region ProbDataType
                    countTripleOne = tuple.Triples[indexOne].Values.Count; // số lượng các cặp xác suất trong thuộc tính
                    var listValue = tuple.Triples[indexOne].Values;
                    var minProbV = tuple.Triples[indexOne].MinProbs;
                    var maxProbV = tuple.Triples[indexOne].MaxProbs;
                    #endregion

                    // Lọc danh sách theo điều kiện so sánh và tính toán xác suất
                    var result = listValue.Where(x => CompareTriple(x, valueTwo, operaterStr, dataType.TypeName)).Count();

                    if (result > 0)
                    {
                        // Tính toán lại minProb và maxProb
                        minProb = (result / (float)countTripleOne) * minProbV.Average(); // Lấy trung bình nếu có nhiều giá trị cận dưới
                        maxProb = (result / (float)countTripleOne) * maxProbV.Average(); // Lấy trung bình nếu có nhiều giá trị cận trên

                        return new List<double> { minProb, maxProb };
                    }
                    else
                    {
                        // Trả về khoảng xác suất nếu không tìm thấy kết quả phù hợp
                        return new List<double> { 0, 0 };
                    }
                }

                // Trường hợp nếu không phải là biểu thức so sánh
                MessageError = "Incorrect operator or query structure.";
                return null;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo lỗi chi tiết
                MessageError = $"Error occurred: {ex.Message}";
                return null;
            }
        }



        public int IndexOfAttribute(string attribute)
        {
            string value = attribute.Trim().ToLower();
            int indexAttribute = -1;

            try
            {
                if (value.Contains("."))
                {

                    // Split into relation and attribute parts
                    string[] parts = value.Split('.');
                    if (parts.Length != 2)
                    {
                        MessageError = $"Invalid attribute format '{value}'. Expected format: relation.attribute.";
                        return -1;
                    }

                    string relationName = parts[0].Trim().ToLower();
                    string attributeName = parts[1].Trim().ToLower();

                    // Find the relation by name
                    ProbRelation relation = this.probDatabase.Relations
                        .FirstOrDefault(r => r.RelationName.ToLower() == relationName);

                    if (relation == null)
                    {
                        MessageError = $"Invalid relation name '{relationName}'. Please ensure the relation exists in the database.";
                        return -1;
                    }

                    // Find the attribute in the relation's schema
                    indexAttribute = relation.Scheme.Attributes.FindIndex(attr =>
                        attr.AttributeName.Trim().ToLower() == attributeName);

                    if (indexAttribute == -1)
                    {
                        MessageError = $"Invalid attribute name '{attributeName}' in relation '{relationName}'.";
                        return -1;
                    }

                    return indexAttribute;
                }
                else
                {
                    // If no relation is specified, search across all attributes
                    int matchCount = 0;

                    for (int i = 0; i < Attributes.Count; i++)
                    {
                        string[] parts = Attributes[i].AttributeName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length == 2 && value == parts[1].ToLower().Trim())
                        {
                            matchCount++;
                            indexAttribute = i;
                        }
                    }

                    if (matchCount > 1)
                    {
                        MessageError = $"Ambiguous attribute name '{value}'. Specify the relation using relation.attribute format.";
                        return -1;
                    }

                    if (matchCount == 0)
                    {
                        MessageError = $"Invalid attribute name '{value}'. No matching attribute found.";
                        return -1;
                    }

                    return indexAttribute;
                }
            }
            catch (Exception ex)
            {
                MessageError = $"Error processing attribute '{attribute}': {ex.Message}";
                return -1;
            }
        }

        private static bool CalculationCon(string s1)
        {
            string valueOne, valueTwo;
            string[] listOperation = s1.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            List<bool> result = new List<bool>();

            foreach (var item in listOperation)
            {
                List<string> stack = new List<string>();
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i].ToString().CompareTo("!") == 0)
                    {
                        if (item[i + 1].ToString().CompareTo("1") == 0 || item[i + 1].ToString().CompareTo("0") == 0)
                        {
                            valueOne = item[i + 1].ToString().CompareTo("1") == 0 ? "0" : "1";
                            stack.Add(valueOne);
                            i = i + 1;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (item[i].ToString().CompareTo("&") == 0)
                    {
                        valueOne = stack[stack.Count - 1].ToString();
                        stack.RemoveAt(stack.Count - 1);
                        int d = 0;
                        if (item[i + 1].ToString().CompareTo("!") == 0 && (item[i + 2].ToString().CompareTo("1") == 0 || item[i + 2].ToString().CompareTo("0") == 0))
                        {
                            valueTwo = item[i + 2].ToString().CompareTo("1") == 0 ? "0" : "1";
                            d = 2;
                        }
                        else
                        {
                            valueTwo = item[i + 1].ToString();
                            d = 1;
                        }
                        bool v1 = (valueOne.CompareTo("1") == 0) ? true : false;
                        bool v2 = (valueTwo.CompareTo("1") == 0) ? true : false;
                        switch (item[i].ToString())
                        {
                            case "&": stack.Add(v1 && v2 ? "1" : "0"); break;
                            case "|": stack.Add(v1 || v2 ? "1" : "0"); break;
                            default: break;
                        }
                        i = i + d;
                    }
                    else
                    {
                        stack.Add(item[i].ToString());
                    }
                }

                result.Add(stack[0].CompareTo("1") == 0);
            }

            return (result.Any(x => x));
        }
        #endregion

        #region những hàm compare
        public static bool isCompareOperator(string S)
        {
            for (int i = 0; i < 6; i++)
                if (Operator[i].CompareTo(S) == 0)
                    return true;
            return false;
        }
        public static bool EQUAL(object a, object b, string type)
        {
            switch (type)
            {
                case "Int16":
                case "Int64":
                case "Int32":
                case "Byte":
                case "Currency": return int.Parse(a.ToString()) == int.Parse(b.ToString());
                case "String":
                case "DateTime":
                case "UserDefined":
                case "Binary": return (a.ToString().CompareTo(b.ToString()) == 0);
                case "Decimal":
                case "Single":
                case "Double": return (Math.Abs((double)a - (double)b) < 0.001);
                case "Boolean": return Boolean.Parse(a.ToString()) == Boolean.Parse(b.ToString());
                default: return false;
            }
        }
        public static bool IntCompare(Int16 valueOne, Int16 valueTwo, string OpratorStr)
        {
            switch (OpratorStr)
            {
                case "_<": return (valueOne < valueTwo);
                case "_>": return (valueOne > valueTwo);
                case "<=": return (valueOne <= valueTwo);
                case ">=": return (valueOne >= valueTwo);
                case "_=": return (valueOne == valueTwo);
                case "!=": return (valueOne != valueTwo);
                default: return false;
            }
        }
        private bool StrCompare(string valueOne, string valueTwo, string opratorStr)
        {
            valueOne = valueOne?.Trim().ToLower();
            valueTwo = valueTwo?.Trim().ToLower();

            //Debug.WriteLine($"Comparing strings: ValueOne='{valueOne}', ValueTwo='{valueTwo}', Operator='{opratorStr}'");

            switch (opratorStr)
            {
                case "=":
                    return string.Equals(valueOne, valueTwo, StringComparison.OrdinalIgnoreCase); // Case-insensitive equality
                case "!=":
                    return !string.Equals(valueOne, valueTwo, StringComparison.OrdinalIgnoreCase); // Case-insensitive inequality
                default:
                    Debug.WriteLine($"Unsupported string comparison operator: {opratorStr}");
                    return false;
            }
        }



        public static bool DoubleCompare(double valueOne, double valueTwo, string OpratorStr)
        {
            switch (OpratorStr)
            {
                case "_<": return (valueOne < valueTwo);
                case "_>": return (valueOne > valueTwo);
                case "<=": return (valueOne <= valueTwo);
                case ">=": return (valueOne >= valueTwo);
                case "_=": return (Math.Abs(valueOne - valueTwo) < 0.001);
                case "!=": return (Math.Abs(valueOne - valueTwo) > 0.001);
                default: return false;
            }

        }
        public static bool BoolCompare(bool valueOne, bool valueTwo, string OpratorStr)
        {
            switch (OpratorStr)
            {
                case "_=": return (valueOne == valueTwo);
                case "!=": return (valueOne != valueTwo);
                default: return false;
            }

        }
        //public bool CompareTriple(object valueOne, string valueTwo, string opratorStr, string typename)
        //{
        //    Debug.WriteLine($"Comparing: ValueOne='{valueOne}', ValueTwo='{valueTwo}', Operator='{opratorStr}', Type='{typename}'");

        //    if (opratorStr == "_=") opratorStr = "=";

        //    switch (typename.ToLower())
        //    {
        //        case "int16":
        //        case "int64":
        //        case "int32":
        //        case "byte":
        //        case "currency":
        //            return IntCompare(Convert.ToInt16(valueOne), Convert.ToInt16(valueTwo), opratorStr);
        //        case "string":
        //        case "datetime":
        //        case "userdefined":
        //        case "binary":
        //            // Handle `_=` as `=` for string comparisons
        //            if (opratorStr == "_=") opratorStr = "=";
        //            return StrCompare(valueOne.ToString(), valueTwo, opratorStr);
        //        case "decimal":
        //        case "single":
        //        case "double":
        //            return DoubleCompare(Convert.ToDouble(valueOne), Convert.ToDouble(valueTwo), opratorStr);
        //        case "boolean":
        //            return BoolCompare(Convert.ToBoolean(valueOne), Convert.ToBoolean(valueTwo), opratorStr);
        //        default:
        //            Debug.WriteLine("Unsupported type for comparison.");
        //            return false;
        //    }
        //}
        public bool CompareTriple(object valueOne, string valueTwo, string opratorStr, string typename)
        {
            Debug.WriteLine($"Comparing: ValueOne='{valueOne}', ValueTwo='{valueTwo}', Operator='{opratorStr}', Type='{typename}'");

            if (opratorStr == "_=") opratorStr = "="; // Normalize `_=` to `=`

            switch (typename.ToLower())
            {
                case "string":
                    valueOne = RemoveDiacritics(valueOne.ToString().Trim().ToLower());
                    valueTwo = RemoveDiacritics(valueTwo.Trim('\'', '"').ToLower());
                    return StrCompare(valueOne.ToString(), valueTwo, opratorStr);

                default:
                    Debug.WriteLine($"Unsupported type for comparison: {typename}");
                    return false;
            }
        }


        private string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Normalize the string to FormD (decomposed) and remove diacritical marks
            return new string(text
                .Normalize(NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }



        #endregion

    }
}
