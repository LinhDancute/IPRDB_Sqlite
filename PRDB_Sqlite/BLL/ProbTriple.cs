using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace PRDB_Sqlite.BLL
{
    public class ProbTriple
    {

        #region Properties

        // Tập các giá trị
        public List<object> Values { get; set; }

        // Tập xác suất cận dưới
        public List<double> MinProbs { get; set; }

        // Tập xác suất cận trên
        public List<double> MaxProbs { get; set; }

        #endregion

        #region Methods

        public ProbTriple()
        {
            this.Values = new List<object>();
            this.MinProbs = new List<double>();
            this.MaxProbs = new List<double>();
        }

        // Tạo bộ ba xác suất từ chuỗi text
        public ProbTriple(string value)
        {
            this.Values = new List<object>();
            this.MinProbs = new List<double>();
            this.MaxProbs = new List<double>();

            try
            {
                if (value.StartsWith("{") && value.EndsWith("}"))
                {
                    // Remove outer braces
                    string innerContent = value.Trim('{', '}').Trim();

                    // Regex to match each triple
                    var matches = Regex.Matches(innerContent, @"\(\s*(.+?)\s*,\s*\[\s*(.+?)\s*,\s*(.+?)\s*\]\s*\)");

                    foreach (Match match in matches)
                    {
                        // Extract the value (e.g., "171")
                        this.Values.Add(match.Groups[1].Value.Trim());

                        // Extract min and max probabilities
                        this.MinProbs.Add(double.Parse(match.Groups[2].Value.Trim()));
                        this.MaxProbs.Add(double.Parse(match.Groups[3].Value.Trim()));
                    }
                }
                else
                {
                    // Fallback for non-nested structures
                    this.Values.Add(value.Trim());
                    this.MinProbs.Add(1.0);
                    this.MaxProbs.Add(1.0);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error parsing ProbTriple: {ex.Message}");
            }
        }

        public ProbTriple(List<object> values, List<double> minProbs, List<double> maxProbs)
        {
            this.Values = new List<object>(values);
            this.MinProbs = new List<double>(minProbs);
            this.MaxProbs = new List<double>(maxProbs);
        }

        public ProbTriple(ProbTriple triple)
        {
            this.Values = new List<object>(triple.Values);
            this.MinProbs = new List<double>(triple.MinProbs);
            this.MaxProbs = new List<double>(triple.MaxProbs);
        }

        public string GetStrValue()
        {
            if (this.Values.Count == 0)
            {
                return "{}";
            }

            // Format each triple
            var formattedTriples = this.Values.Select((value, index) =>
                $"( {value}, [ {this.MinProbs[index]:0.##}, {this.MaxProbs[index]:0.##} ] )");

            // Combine all triples into a single string
            return $"{{ {string.Join(", ", formattedTriples)} }}";
        }

        public bool isProbTripleValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            // Kiểm tra dữ liệu có chứa đúng định dạng { ( ), ( ) }
            if (value.StartsWith("{") && value.EndsWith("}"))
            {
                // Lấy phần bên trong dấu {}
                string innerValue = value.Substring(1, value.Length - 2).Trim();

                // Phân tách các triple: ( value, [probMin, probMax] )
                string[] triples = innerValue.Split(new string[] { "), (" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string triple in triples)
                {
                    // Đảm bảo triple có dạng ( value, [probMin, probMax] )
                    string cleanedTriple = triple.Trim('(', ')').Trim();
                    if (!cleanedTriple.Contains(", [")) return false;

                    string[] parts = cleanedTriple.Split(new string[] { ", [" }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 2) return false;

                    // Phân tích giá trị và khoảng xác suất
                    string dataValue = parts[0].Trim();
                    string[] probs = parts[1].Trim(']').Split(',');

                    if (probs.Length != 2) return false;

                    // Kiểm tra xác suất là số hợp lệ
                    if (!double.TryParse(probs[0], out double minProb) || !double.TryParse(probs[1], out double maxProb))
                        return false;

                    // Kiểm tra điều kiện xác suất [0, 1]
                    if (minProb < 0 || maxProb > 1 || minProb > maxProb)
                        return false;
                }

                return true;
            }

            return false;
        }

        #endregion
    }
}
