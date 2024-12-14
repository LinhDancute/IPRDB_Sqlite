using PRDB_Sqlite.DAL;
using System.Collections.Generic;

namespace PRDB_Sqlite.BLL
{
    public class ProbAttribute
    {
        //Lớp này quản lý các thuộc tính trong lược đồ PRDB, lưu trữ thông tin như thuộc tính là khóa chính hay không,
        //tên thuộc tính, kiểu dữ liệu (ProbDataType), và lược đồ liên kết (ProbScheme).
        //Nó cung cấp các phương thức tương tác với cơ sở dữ liệu, ví dụ như lấy thuộc tính theo ID lược đồ,
        //xóa thuộc tính, và chèn thuộc tính mới.
        #region Properties
        public bool PrimaryKey { get; set; }

        public int IDAttribute { get; set; }
        // Tên thuộc tính
        public string AttributeName { get; set; }

        public ProbDataType Type { get; set; }

        public string Description { get; set; }

        public ProbScheme probScheme { get; set; }

        public string TypeName { get { return this.Type.TypeName; } set { } }
        public string DomainString { get { return this.Type.DomainString; } set { } }

        #endregion

        #region Methods

        public ProbAttribute()
        {
            this.IDAttribute = -1;
            Type = new ProbDataType();
        }

        public ProbAttribute(ProbAttribute attr)
        {
            this.IDAttribute = attr.IDAttribute;
            this.Type = new ProbDataType(attr.Type);
            this.Description = attr.Description;
            this.PrimaryKey = attr.PrimaryKey;
            this.AttributeName = attr.AttributeName;
            this.probScheme = attr.probScheme;
        }

        #endregion

        internal List<ProbAttribute> getListAttributeByIDScheme(int IDScheme)
        {
            return DALProbAttribute.getListAttributeByIDScheme(IDScheme);
        }

        internal void DeleteAllAttribute()
        {
            DALProbAttribute.DeleteAllAttribute();
        }

        internal void Insert()
        {
            DALProbAttribute.Insert(this);
        }

        internal int getMaxIdinTable()
        {
            return DALProbAttribute.getMaxIdinTable();
        }

        internal void DeleteAllAttributeByIdScheme()
        {
            DALProbAttribute.DeleteAllAttributeByIdScheme(this);
        }
    }
}
