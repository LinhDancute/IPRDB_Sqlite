using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PRDB_Sqlite.BLL
{
    public class QueryExecution
    {
        public string queryString { get; set; }
        public List<ProbRelation> selectedRelations { get; set; }
        public ProbRelation relationResult { get; set; }
        public ProbDatabase probDatabase { get; set; }
        public string conditionString { get; set; }
        public bool flagNaturalJoin { get; set; }
        public string MessageError { get; set; }

        public List<ProbAttribute> selectedAttributes;
        private List<string> OperationNaturalJoin = new List<string>();

        public QueryExecution(string queryString, ProbDatabase probDatabase)
        {
            this.selectedRelations = new List<ProbRelation>();
            this.selectedAttributes = new List<ProbAttribute>();
            this.relationResult = new ProbRelation();
            this.probDatabase = probDatabase;
            this.queryString = StandardizeQuery(queryString);
            this.flagNaturalJoin = false;
        }


        #region new
        private static string StandardizeQuery(string queryString)
        {
            try
            {
                // Remove extra spaces and replace new lines with a single space
                string result = string.Join(" ", queryString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                return result.ToLower();
            }
            catch (Exception)
            {
                return null;
            }
        }

        private ProbRelation Descartes(ProbRelation relationOne, ProbRelation relationTwo)
        {
            ProbRelation relation = new ProbRelation();
            GenerateNewRelation(relation, relationOne);
            GenerateNewRelation(relation, relationTwo);
            JoinTwoRelation(relation, relationOne, relationTwo);
            return relation;
        }

        private static void JoinTwoRelation(ProbRelation relation, ProbRelation relation1, ProbRelation relation2)
        {
            foreach (ProbTuple tupleOne in relation1.Tuples)
            {
                foreach (ProbTuple tupleTwo in relation2.Tuples)
                {
                    ProbTuple value = new ProbTuple();
                    value.Triples.AddRange(tupleOne.Triples);
                    value.Triples.AddRange(tupleTwo.Triples);
                    relation.Tuples.Add(value);
                }
            }
        }

        private void GenerateNewRelation(ProbRelation relation, ProbRelation relationInput)
        {
            relation.ListRenameRelation.Add(relationInput.RelationName);
            foreach (ProbAttribute attr in relationInput.Scheme.Attributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = relationInput.RelationName + "." + attr.AttributeName;
            }
            relation.Scheme.Attributes.AddRange(relationInput.Scheme.Attributes);
        }

        private static ProbTriple JoinTwoTriple(ProbTriple tripleOne, ProbTriple tripleTwo, ProbAttribute attribute, string OperationNaturalJoin)
        {
            // Khởi tạo đối tượng ProbTriple mới để lưu kết quả
            ProbTriple triple = new ProbTriple();

            // Duyệt qua các giá trị trong tập giá trị của tripleOne và tripleTwo
            for (int i = 0; i < tripleOne.Values.Count; i++)
            {
                for (int j = 0; j < tripleTwo.Values.Count; j++)
                {
                    // Kiểm tra điều kiện EQUAL giữa các giá trị
                    if (SelectCondition.EQUAL(tripleOne.Values[i].ToString().Trim(), tripleTwo.Values[j].ToString().Trim(), attribute.Type.DataType))
                    {
                        // Nếu điều kiện thỏa mãn, thêm giá trị vào tập giá trị của triple
                        triple.Values.Add(tripleOne.Values[i]);
                        // Cập nhật các xác suất cận dưới và cận trên tương ứng
                        triple.MinProbs.Add(tripleOne.MinProbs[i]);
                        triple.MaxProbs.Add(tripleOne.MaxProbs[i]);
                    }
                }
            }

            // Nếu có ít nhất một giá trị được tìm thấy, thực hiện tính toán xác suất theo phép toán
            if (triple.Values.Count > 0)
            {
                switch (OperationNaturalJoin)
                {
                    case "in":
                        // Phép toán "in" tính xác suất cận dưới và cận trên
                        triple.MinProbs = tripleOne.MinProbs.Zip(tripleTwo.MinProbs, (min1, min2) => min1 * min2).ToList();
                        triple.MaxProbs = tripleOne.MaxProbs.Zip(tripleTwo.MaxProbs, (max1, max2) => max1 * max2).ToList();
                        break;

                    case "ig":
                        // Phép toán "ig" tính xác suất cận dưới và cận trên
                        triple.MinProbs = tripleOne.MinProbs.Zip(tripleTwo.MinProbs, (min1, min2) => Math.Max(0, (min1 + min2) - 1)).ToList();
                        triple.MaxProbs = tripleOne.MaxProbs.Zip(tripleTwo.MaxProbs, (max1, max2) => Math.Min(max1, max2)).ToList();
                        break;

                    case "me":
                        // Phép toán "me" sẽ đặt xác suất cận dưới và cận trên về 0
                        triple.MinProbs = new List<double> { 0 };
                        triple.MaxProbs = new List<double> { 0 };
                        break;
                }
            }

            // Nếu không có giá trị nào thỏa mãn điều kiện, trả về null
            return triple.Values.Count <= 0 ? null : triple;
        }


        private ProbRelation NaturalJoin(ProbRelation relationResult, ProbRelation relationInput, string operationRa)
        {
            ProbRelation relation = Descartes(relationResult, relationInput);
            List<int> indexsRemove = new List<int>();

            var totalAttributesOne = relation.Scheme.Attributes.Count - relationInput.Scheme.Attributes.Count;

            for (int i = 0; i < totalAttributesOne; i++)
            {
                for (int j = totalAttributesOne; j < relation.Scheme.Attributes.Count; j++)
                {
                    if (i != j && relation.Scheme.Attributes[i].Type.DataType == relation.Scheme.Attributes[j].Type.DataType)
                    {
                        string attributeOne = relation.Scheme.Attributes[i].AttributeName.Substring(relation.Scheme.Attributes[i].AttributeName.IndexOf(".") + 1);
                        string attributeTwo = relation.Scheme.Attributes[j].AttributeName.Substring(relation.Scheme.Attributes[j].AttributeName.IndexOf(".") + 1);

                        if (attributeOne.Equals(attributeTwo, StringComparison.CurrentCultureIgnoreCase))
                        {
                            indexsRemove.Add(j);

                            for (int k = relation.Tuples.Count - 1; k >= 0; k--)
                            {
                                ProbTriple triple = JoinTwoTriple(relation.Tuples[k].Triples[i], relation.Tuples[k].Triples[j], relation.Scheme.Attributes[i], operationRa);
                                if (triple != null)
                                {
                                    relation.Tuples[k].Triples[i] = triple;
                                    relation.Tuples[k].Triples[j] = triple;
                                }
                                else
                                {
                                    relation.Tuples.RemoveAt(k);
                                }
                            }
                        }
                    }
                }
            }

            var check = relation.Scheme.Attributes.Count() == this.selectedAttributes.Count();
            if (check)
            {
                for (int i = 0; i < indexsRemove.Count; i++)
                {
                    foreach (ProbTuple tuple in relation.Tuples)
                    {
                        tuple.Triples.RemoveAt(indexsRemove[i]);
                    }
                    relation.Scheme.Attributes.RemoveAt(indexsRemove[i]);
                    this.selectedAttributes.RemoveAt(indexsRemove[i]);
                }
            }
            flagNaturalJoin = false;
            return relation;
        }

        private static ProbRelation getRelationBySelectAttribute(ProbRelation probRelation, List<ProbAttribute> attributes)
        {
            ProbRelation relation = new ProbRelation();
            relation.RelationName = probRelation.RelationName;

            List<int> indexs = new List<int>();
            foreach (ProbAttribute attr in attributes)
            {
                for (int i = 0; i < probRelation.Scheme.Attributes.Count; i++)
                {
                    if (probRelation.Scheme.Attributes[i].AttributeName.Trim().ToLower() == attr.AttributeName.Trim().ToLower())
                    {
                        indexs.Add(i);
                        break;
                    }
                }
            }

            foreach (ProbTuple item in probRelation.Tuples)
            {
                ProbTuple tuple = new ProbTuple();
                for (int i = 0; i < indexs.Count; i++)
                {
                    tuple.Triples.Add(item.Triples[indexs[i]]);
                }
                relation.Tuples.Add(tuple);
            }

            relation.Scheme.Attributes = attributes;
            return relation;
        }

        internal bool ExcuteQuery()
        {
            try
            {
                if (!QueryAnalyze()) return false;

                if (this.selectedRelations.Count == 1)
                {
                    foreach (ProbAttribute attr in this.selectedRelations[0].Scheme.Attributes)
                    {
                        if (!attr.AttributeName.Contains("."))
                            attr.AttributeName = String.Format("{0}.{1}", this.selectedRelations[0].RelationName, attr.AttributeName);
                    }
                }
                else
                {
                    var relationRes = this.selectedRelations[0];
                    for (int i = 1; i < this.selectedRelations.Count(); i++)
                    {
                        relationRes = flagNaturalJoin
                            ? NaturalJoin(relationRes, this.selectedRelations[i], this.OperationNaturalJoin[i - 1])
                            : Descartes(relationRes, this.selectedRelations[i]);
                    }
                    this.selectedRelations[0] = relationRes;
                }

                // Handle where clause
                if (!this.queryString.Contains(Common.Where))
                {
                    this.relationResult = getRelationBySelectAttributeV2(this.selectedRelations[0], this.selectedAttributes);
                    return true;
                }
                else
                {
                    SelectCondition Condition = new SelectCondition(this.selectedRelations[0], this.conditionString);
                    Condition.ProcessConditionString();

                    if (!string.IsNullOrEmpty(Condition.MessageError))
                    {
                        MessageError = Condition.MessageError;
                        return false;
                    }

                    foreach (ProbTuple tuple in this.selectedRelations[0].Tuples)
                        if (Condition.Satisfied(tuple))
                            this.relationResult.Tuples.Add(tuple);
                        else
                        {
                            if (!string.IsNullOrEmpty(Condition.MessageError))
                            {
                                MessageError = Condition.MessageError;
                                return false;
                            }
                        }

                    if (Condition.MessageError != string.Empty)
                    {
                        this.MessageError = Condition.MessageError;
                        return false;
                    }

                    if (Condition.conditionString == string.Empty)
                    {
                        this.MessageError = Condition.MessageError;
                        return false;
                    }

                    this.relationResult.Scheme = this.selectedRelations[0].Scheme;
                    this.relationResult = getRelationBySelectAttribute(this.relationResult, this.selectedAttributes);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        internal bool QueryAnalyze()
        {
            try
            {
                string s = this.queryString;
                //Kiểm tra câu truy vấn có hợp lệ
                if (!this.CheckStringQuery(s))
                {
                    return false;
                }

                //Get All Relation
                this.selectedRelations = GetAllRelation(s);
                if (this.selectedRelations == null)
                {
                    return false;
                }

                //Get All Attribute
                this.selectedAttributes = GetAttribute(s);
                if (this.selectedAttributes == null)
                    return false;

                this.conditionString = GetCondition(s);

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool CheckStringQuery(string query)
        {
            try
            {

                // Loại bỏ ký tự xuống dòng và tab
                query = query.Replace("\n", " ").Replace("\r", " ").Replace("\t", " ");
                var indexSelect = query.IndexOf(Common.Select);
                var indexFrom = query.IndexOf(Common.From);
                var indexWhere = query.IndexOf(Common.Where);

                if (indexSelect == -1 || indexFrom == -1)
                {
                    MessageError = "Syntax Error! The keyword must theo order 'Select From Where' ";
                    return false;
                }

                if (indexSelect > indexFrom || (indexWhere != -1 && indexFrom > indexWhere))
                {
                    MessageError = "Syntax Error! The keyword must theo order 'Select From Where' ";
                    return false;
                }

                var regex = new Regex("^[a-zA-Z *,.]*$");

                var subQuery = query;

                if (query.Contains(Common.Where))
                {
                    subQuery = query.Substring(query.IndexOf("select") + 6, query.IndexOf("where") - 1);
                }

                if (!regex.IsMatch(subQuery))
                {
                    MessageError = "Error: Do not input the special character in query statement";
                    return false;
                }

                return true;

            }
            catch
            {
                return false;
            }

        }

        private List<ProbRelation> GetAllRelation(string valueString)
        {
            int posOne;
            int posTwo;
            string relationsString = string.Empty;
            List<string> listOfRelationName = this.probDatabase.ListOfRelationNameToLower();
            string[] seperator = { "," };
            string[] relations;
            List<ProbRelation> probRelations = new List<ProbRelation>();

            //////////////////////// Get Relations ///////////////////////
            posOne = valueString.IndexOf(Common.From) + 4;

            if (!valueString.Contains(Common.Where))
                posTwo = valueString.Length - 1;
            else
                posTwo = valueString.IndexOf(Common.Where) - 1;

            relationsString = valueString.Substring(posOne, posTwo - posOne + 1);   // Get Relation in the Query Text     

            if (relationsString.Trim().Length <= 0)
            {
                MessageError = "No relation exists in the query !";
                return null;
            }

            if (relationsString.Contains(","))
            {
                relations = relationsString.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                if (relationsString.Contains(Common.NaturalJoinIn) || relationsString.Contains(Common.NaturalJoinIg) || relationsString.Contains(Common.NaturalJoinMe))
                {

                    var listRaltion = relationsString.Split(new string[] { "natural join" }, StringSplitOptions.RemoveEmptyEntries);

                    relations = new string[listRaltion.Length];

                    for (int i = 0; i < listRaltion.Length; i++)
                    {
                        if (i == 0)
                        {
                            relations[i] = listRaltion[i];
                        }
                        else
                        {
                            string[] listTmp = listRaltion[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            if (listTmp.Length != 2 && listTmp.Length != 3)
                            {
                                MessageError = String.Format("Incorrect syntax near '{0}'.", listRaltion[i]);
                                return null;
                            }
                            if (!listTmp[0].Contains("in") && !listTmp[0].Contains("ig") && !listTmp[0].Contains("me"))
                            {
                                MessageError = String.Format("Incorrect syntax near '{0}'.", listRaltion[i]);
                                return null;
                            }

                            OperationNaturalJoin.Add(listTmp[0]);
                            if (listTmp.Length == 2)
                            {
                                relations[i] = listTmp[1];
                            }
                            else
                            {
                                relations[i] = listTmp[1] + " " + listTmp[2];
                            }
                        }
                    }

                    flagNaturalJoin = true;
                }
                else
                {
                    relations = new string[1];
                    relations[0] = relationsString;
                }
            }

            for (int i = 0; i < relations.Length; i++)
            {
                string[] listTmp = relations[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!listOfRelationName.Contains(listTmp[0].ToLower()))
                {
                    MessageError = String.Format("Invalid relation name '{0}'.", listTmp[0]);
                    return null;
                }

                if(listTmp.Length > 2)
                {
                    MessageError = String.Format("Invalid relation name '{0}'.", relations[i]);
                    return null;
                }

                ProbRelation tmp = this.probDatabase.Relations.SingleOrDefault(c => c.RelationName.ToLower().Equals(listTmp[0], StringComparison.OrdinalIgnoreCase));

                ProbRelation rela = new ProbRelation();
                if (listTmp.Length == 2)
                {
                    rela.RelationName = listTmp[1];
                }
                else
                    rela.RelationName = tmp.RelationName;

                rela.Scheme = new ProbScheme(-1, tmp.Scheme.SchemeName, tmp.Scheme.Attributes);

                foreach (ProbTuple item in tmp.Tuples)
                {
                    ProbTuple tuple = new ProbTuple(item);
                    rela.Tuples.Add(tuple);
                }

                probRelations.Add(rela);
            }

            return probRelations;

        }

        private List<ProbAttribute> GetAttribute(string valueString)
        {
            List<ProbAttribute> listProbAttribute = new List<ProbAttribute>();
            //////////////////////// Get Attributes //////////////////////
            int posOne, posTwo, posThree;

            // * là chọn tất cả các thuộc tính
            if (valueString.Contains("*"))
            {
                posOne = valueString.IndexOf("*");  // start postion of attributes
                posTwo = valueString.IndexOf("from ") - 1;
                posThree = valueString.IndexOf(Common.Select) + 6;

                if (posOne > posTwo)
                {
                    MessageError = "Incorrect syntax near 'from'.";
                    return null;
                }

                if (posOne < valueString.IndexOf(Common.Select))
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }

                if (valueString.Contains(Common.Where) && posOne > valueString.IndexOf(Common.Where))
                {
                    MessageError = "Incorrect syntax near 'where'.";
                    return null;
                }

                if (posOne != valueString.LastIndexOf("*"))
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }

                // end postion of attributes
                string attributes = valueString.Substring(posOne, posTwo - posOne + 1);
                string attributesBeforeStar = valueString.Substring(posThree, posOne - posThree + 1);

                // Nếu như phia sau dấu * có bất kì kí tự nào thì sẽ thông báo lỗi
                if (attributes.Trim().Length > 1 || attributesBeforeStar.Trim().Length > 1)
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }

                // thực hiện sao chép toàn bộ thuộc tính của các quan hệ vào danh sách thuộc tính chọn
                for (int i = 0; i < this.selectedRelations.Count; i++)
                {
                    foreach (ProbAttribute attr in this.selectedRelations[i].Scheme.Attributes)
                    {
                        attr.AttributeName = String.Format("{0}.{1}", this.selectedRelations[i].RelationName, attr.AttributeName);
                        listProbAttribute.Add(attr);
                    }
                }

                return listProbAttribute;

            }
            else // ngược lại là xuất theo thuộc tính chỉ định
            {
                posOne = valueString.IndexOf("select") + 6;                                                   // start postion of attributes
                posTwo = valueString.IndexOf("from ") - 1;                                                    // end postion of attributes

                string attributes = valueString.Substring(posOne, posTwo - posOne + 1);

                //kiểm tra cú pháp của chuổi thuộc tính
                if (!QueryExecution.CheckStringAttribute(attributes))
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }
                else
                {
                    string[] seperator = { "," };
                    string[] attribute = attributes.Split(seperator, StringSplitOptions.RemoveEmptyEntries); // split thành mảng các thuộc tính                    

                    foreach (string str in attribute)
                    {
                        if (str.Trim().Contains(' '))
                        {
                            MessageError = "Incorrect syntax near 'select'.";
                            return null;
                        }
                        if (!str.Contains("."))
                        {
                            string attributeName = str.Trim();
                            int countOne = 0;
                            int countSameAttribute = 0;
                            foreach (ProbRelation relation in this.selectedRelations)
                            {
                                List<string> listOfAttributeName = relation.Scheme.ListOfAttributeNameToLower();
                                if (listOfAttributeName.Contains(attributeName.ToLower()))
                                {
                                    ProbAttribute attr = new ProbAttribute(relation.Scheme.Attributes[listOfAttributeName.IndexOf(attributeName)]);
                                    attr.AttributeName = String.Format("{0}.{1}", relation.RelationName, attr.AttributeName);
                                    listProbAttribute.Add(attr);
                                    countSameAttribute++;
                                }
                                else
                                {
                                    countOne++;
                                }
                            }

                            if (countOne == this.selectedRelations.Count)
                            {
                                MessageError = String.Format(" Invalid attribute name '{0}'.", attributeName);
                                return null;
                            }

                            if (countSameAttribute == this.selectedRelations.Count && this.selectedRelations.Count >= 2)
                            {
                                MessageError = String.Format(" Ambiguous attribute name '{0}'.", attributeName);
                                return null;
                            }
                        }
                        else
                        {
                            string[] array = str.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                            if (array.Length != 2)
                            {
                                MessageError = "Incorrect syntax near the keyword 'select'.";
                                return null;
                            }

                            ProbRelation relation = this.selectedRelations.SingleOrDefault(c => c.RelationName.Trim() == array[0].Trim());

                            if (relation == null)
                            {
                                MessageError = String.Format("The multi-part identifier '{0}' could not be bound.", str);
                                return null;
                            }

                            ProbAttribute attr = new ProbAttribute(relation.Scheme.Attributes.SingleOrDefault(c => c.AttributeName.Trim().ToLower() == array[1].Trim()));
                            attr.AttributeName = String.Format("{0}.{1}", relation.RelationName, attr.AttributeName);

                            if (attr == null)
                            {
                                MessageError = "Invalid attribute name '" + array[1] + "'.";
                                return null;
                            }

                            listProbAttribute.Add(attr);
                        }
                    }

                    return listProbAttribute;
                }
            }
        }

        private static bool CheckStringAttribute(string stringAttribute)
        {
            string subString = stringAttribute;

            if (subString.Trim().Length <= 0)
                return false;

            if (subString.Contains(",,"))
                return false;

            if (subString.LastIndexOf(",") == subString.Length - 1)
            {
                return false;
            }

            return true;
        }

        private static string GetCondition(string valueString)
        {
            string conditionString = string.Empty;
            int posOne;

            ///////////////////// Get Select Condition /////////////////
            if (valueString.Contains("where "))
            {
                posOne = valueString.IndexOf("where") + 5;
                conditionString = valueString.Substring(posOne);   // Get Select Condition in the Query Text
            }

            return conditionString;
        }

        private static ProbRelation getRelationBySelectAttributeV2(ProbRelation probRelation, List<ProbAttribute> attributes)
        {
            ProbRelation relation = new ProbRelation();
            relation.RelationName = probRelation.RelationName;

            List<int> indexs = new List<int>();

            // Xác định các chỉ số thuộc tính khớp
            for (int i = 0; i < probRelation.Scheme.Attributes.Count; i++)
            {
                string attributeNameWithoutPrefix = probRelation.Scheme.Attributes[i].AttributeName.Trim().ToLower();
                if (attributes.Any(x => x.AttributeName.Trim().ToLower() == attributeNameWithoutPrefix))
                {
                    indexs.Add(i);
                }
            }

            // Kiểm tra nếu không có thuộc tính nào khớp
            if (!indexs.Any())
            {
                throw new Exception("Error: No matching attributes found in the relation.");
            }

            // Lấy các bộ dữ liệu (Tuples) theo thuộc tính được chọn
            foreach (ProbTuple item in probRelation.Tuples)
            {
                ProbTuple tuple = new ProbTuple();
                foreach (int index in indexs)
                {
                    tuple.Triples.Add(item.Triples[index]);
                }
                relation.Tuples.Add(tuple);
            }

            // Cập nhật lược đồ thuộc tính của quan hệ mới
            relation.Scheme.Attributes = probRelation.Scheme.Attributes
                .Where((attr, idx) => indexs.Contains(idx))
                .ToList();

            return relation;
        }

        #endregion
    }
}
