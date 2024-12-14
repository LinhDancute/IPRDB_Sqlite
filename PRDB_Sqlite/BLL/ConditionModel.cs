using System.Collections.Generic;

namespace PRDB_Sqlite.BLL
{
    //giữ danh sách các chiến lược (StrategyModel), danh sách các toán tử và khoảng xác suất (MaxProb và MinProb).
    public class ConditionModel
    {
        public List<StrategyModel> StrategyModels { get; set; }
        public List<string> OperatorStrategy { get; set; }
        public double? MaxProb { get; set; }
        public double? MinProb { get; set; }
    }

    //StrategyModel đại diện cho từng điều kiện hoặc chiến lược áp dụng vào truy vấn,
    //bao gồm các thuộc tính như AttributeName, AttributeValue, và OperatorStrOfTriple.
    public class StrategyModel
    {
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public string OperatorStrOfTriple { get; set; }
    }
}
