using System;
using System.Collections.Generic;

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
            originalInput = value.Trim();
            try
            {
                this.Values = new List<object>();
                this.MinProbs = new List<double>();
                this.MaxProbs = new List<double>();

                if (!value.Contains("{") && !value.Contains("}") && !value.Contains("[") && !value.Contains("]"))
                {
                    Values.Add(value);
                    MinProbs.Add(1);
                    MaxProbs.Add(1);
                }
                else
                {
                    // Sử dụng Split để tách chuỗi theo dấu phân cách ||
                    string[] parts = value.Split(new[] { " || " }, StringSplitOptions.None);

                    foreach (var part in parts)
                    {
                        int j1 = part.IndexOf('{');
                        int j2 = part.IndexOf('}');
                        int j3 = part.IndexOf('[');
                        int j4 = part.LastIndexOf(',');
                        int j5 = part.IndexOf(']');

                        // Lấy giá trị trong { }
                        var valueString = part.Substring(j1 + 1, j2 - j1 - 1);
                        string[] listValue = valueString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        // Thêm từng giá trị vào Values
                        foreach (var item in listValue)
                        {
                            this.Values.Add(item);
                        }

                        // Lấy xác suất [Min, Max]
                        double minProb = double.Parse(part.Substring(j3 + 1, j4 - j3 - 1));
                        double maxProb = double.Parse(part.Substring(j4 + 1, j5 - j4 - 1));

                        // Cập nhật MinProbs và MaxProbs với số lượng tương ứng
                        this.MinProbs.Add(minProb);
                        this.MaxProbs.Add(maxProb);
                    }

                }
            }
            catch
            {
                // Xử lý lỗi
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

        // Xuất bộ ba xác suất ra chuỗi giá trị
        //public string GetStrValue()
        //{
        //    string strValue = "{";
        //    for (int i = 0; i < Values.Count; i++)
        //    {
        //        strValue += Values[i].ToString();
        //        strValue += " [" + MinProbs[i] + ", " + MaxProbs[i] + "]";
        //        if (i < Values.Count - 1)
        //            strValue += " || ";
        //    }
        //    strValue += "}";
        //    return strValue;
        //}

        private string originalInput;

        public string GetStrValue()
        {
            if (!string.IsNullOrEmpty(originalInput))
            {
                return originalInput;
            }

            // Nếu originalInput chưa được gán giá trị, xây dựng chuỗi theo định dạng bộ
            string strValue = "";
            for (int i = 0; i < Values.Count; i++)
            {
                // Định dạng từng bộ giá trị và xác suất
                strValue += "{ " + Values[i].ToString() + " }";
                strValue += "[ " + MinProbs[i] + ", " + MaxProbs[i] + " ]";

                // Thêm " || " nếu chưa phải phần tử cuối
                if (i < Values.Count - 1)
                {
                    strValue += " || ";
                }
            }

            return strValue;
        }


        public bool isProbTripleValue(string value)
        {
            return value.Contains("{") && value.Contains("}") && value.Contains("[") && value.Contains("]");
        }

        #endregion
    }
}
