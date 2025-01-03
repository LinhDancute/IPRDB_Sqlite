using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRDB_Sqlite.BLL
{
    public class ProbDataType
    {
        #region Properties

        public string TypeName { get; set; } // TypeName != DataType if DataType == "User-Defined"

        public string DataType { get; set; }

        public string DomainString { get; set; }

        public List<string> Domain { get; set; }

        #endregion
        #region Methods
        public ProbDataType()
        {
            this.TypeName = "No Name";
            this.DataType = "No Type";
            this.DomainString = "No Domain String";
            Domain = new List<string>();
        }

        public ProbDataType(ProbDataType type)
        {
            this.TypeName = type.TypeName;
            this.DataType = type.DataType;
            this.DomainString = type.DomainString;
            Domain = new List<string>();

            foreach (string item in type.Domain)
            {
                Domain.Add(item);
            }
        }

        public void GetDomain(string str)
        {
            try
            {
                this.DomainString = str;
                if (this.TypeName == "UserDefined")
                {
                    str = str.Replace("{", "");
                    str = str.Replace("}", "");
                    char[] seperator = { ',' };
                    string[] temp = str.Split(seperator);
                    this.Domain = new List<string>();
                    foreach (string value in temp)
                        this.Domain.Add(value.Trim());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public bool CheckDomain(string value)
        {
            string tmp = this.DomainString;

            tmp = tmp.Replace("{", "");
            tmp = tmp.Replace("}", "");
            char[] seperator = { ',' };
            string[] temp = tmp.Split(seperator);
            this.Domain = new List<string>();
            foreach (string v in temp)
                this.Domain.Add(v.Trim().ToLower());
            return this.Domain.Contains(value.ToLower());
        }

        private static bool isBinaryType(object V)
        {
            try
            {
                foreach (char i in V.ToString())
                    if (i != '0' && i != '1')
                        return false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return true;
        }

        private static bool isCurrencyType(object V)
        {
            try
            {
                const double MINCURRENCY = 1.0842021724855044340074528008699e-19;
                const double MAXCURRENCY = 9223372036854775807.0;
                double temp = Convert.ToDouble(V);
                if (temp - MINCURRENCY >= 0)
                    if (temp - MAXCURRENCY <= 0)
                        return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return false;
        }

        public bool CheckDataTypeOfVariables(string value)
        {
            try
            {
                this.GetDataType();

                switch (this.DataType)
                {
                    case "Int16": Convert.ToInt16(value); break;
                    case "Int32": Convert.ToInt32(value); break;
                    case "Int64": Convert.ToInt64(value); break;
                    case "Byte": Convert.ToByte(value); break;
                    case "String": Convert.ToString(value); break;
                    case "DateTime": Convert.ToDateTime(value); break;
                    case "Decimal": Convert.ToDecimal(value); break;
                    case "Single": Convert.ToSingle(value); break;
                    case "Double": Convert.ToDouble(value); break;
                    case "Boolean": Convert.ToBoolean(value); break;
                    case "Binary": return (isBinaryType(value));
                    case "Currency": return (isCurrencyType(value));
                    case "UserDefined":
                        return CheckDomain(value.ToString().Trim());
                    default: break;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool CheckDataType(string value)
        {
            try
            {
                this.GetDataType();

                if (new ProbTriple().isProbTripleValue(value)) // Kiểm tra xem có phải ProbTriple hợp lệ không
                {
                    // Nếu là kiểu UserDefined, kiểm tra giá trị trong domain
                    if (this.DataType == "UserDefined")
                    {
                        // Phân tách các triple trong {}
                        string innerValue = value.Substring(1, value.Length - 2).Trim();
                        string[] triples = innerValue.Split(new string[] { "), (" }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string triple in triples)
                        {
                            string cleanedTriple = triple.Trim('(', ')').Trim();
                            string[] parts = cleanedTriple.Split(new string[] { ", [" }, StringSplitOptions.RemoveEmptyEntries);

                            if (!CheckDomain(parts[0].Trim())) // Kiểm tra giá trị đầu tiên trong domain
                                return false;
                        }
                    }

                    return true;
                }

                // Kiểm tra các kiểu dữ liệu thông thường
                if (this.DataType != "String")
                {
                    value = value.Replace(" ", "");
                }

                string[] seperator = { "," };
                object[] listValue = value.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

                foreach (object tem in listValue)
                {
                    switch (this.DataType)
                    {
                        case "Int16": Convert.ToInt16(tem); break;
                        case "Int32": Convert.ToInt32(tem); break;
                        case "Int64": Convert.ToInt64(tem); break;
                        case "Byte": Convert.ToByte(tem); break;
                        case "String": Convert.ToString(tem); break;
                        case "DateTime": Convert.ToDateTime(tem); break;
                        case "Decimal": Convert.ToDecimal(tem); break;
                        case "Single": Convert.ToSingle(tem); break;
                        case "Double": Convert.ToDouble(tem); break;
                        case "Boolean": Convert.ToBoolean(tem); break;
                        default: break;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        // Lấy DataType từ TypeName
        public void GetDataType()
        {
            try
            {
                this.DataType = "UserDefined";

                switch (this.TypeName)
                {
                    case "Int16": this.DataType = "Int16"; break;
                    case "Int64": this.DataType = "Int64"; break;
                    case "Int32": this.DataType = "Int32"; break;
                    case "Byte": this.DataType = "Byte"; break;
                    case "Decimal": this.DataType = "Decimal"; break;
                    case "Currency": this.DataType = "Currency"; break;
                    case "String": this.DataType = "String"; break;
                    case "DateTime": this.DataType = "DateTime"; break;
                    case "Binary": this.DataType = "Binary"; break;
                    case "Single": this.DataType = "Single"; break;
                    case "Double": this.DataType = "Double"; break;
                    case "Boolean": this.DataType = "Boolean"; break;
                    default: break;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        #endregion
        internal string getDefaultValue()
        {
            this.GetDataType();

            switch (this.DataType)
            {
                case "Int16":
                case "Int32":
                case "Int64":
                case "Byte": return "{ 0 }[ 0,0]";
                case "String": return "{ Empty }[ 0,0]";
                case "DateTime": return String.Format("{{ {0} }}[ 0,0]", DateTime.MinValue);
                case "Decimal": return "{ 0.0 }[ 0,0]";
                case "Single": return "{ 0 }[ 0,0]";
                case "Double": return "{ 0.0 }[ 0,0]";
                case "Boolean": return "{ false }[ 0,1]";
                case "Binary": return "{ 0 }[ 0,0]";
                case "Currency": return "{ 0.0 }[ 0,0]";
                case "UserDefined":
                    this.TypeName = "UserDefined";
                    GetDomain(DomainString);
                    return String.Format("{{ {0} }}[ 0, 0]", this.Domain[0]);
                default: return "{ 0 }[ 0,0]";

            }
        }
    }
}
