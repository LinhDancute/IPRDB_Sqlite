using PRDB_Sqlite.DAL;
using System.Collections.Generic;
namespace PRDB_Sqlite.BLL
{
    public class ProbRelation
    {

        #region Properties

        // ID relation
        public int IDRelation { get; set; }

        // Lược đồ quan hệ tương ứng
        public ProbScheme Scheme { get; set; }

        // Tên quan hệ
        public string RelationName { get; set; }

        // Tên quan hệ đã đổi
        public string RenameRelationName { get; set; }

        // Danh sách các tên đã đổi quan hệ
        public List<string> ListRenameRelation { get; set; }

        // Tập các bộ trên quan hệ
        public List<ProbTuple> Tuples { get; set; }

        #endregion

        #region Methods

        // Default constructor
        public ProbRelation()
        {
            this.IDRelation = -1; // Default value for IDRelation
            this.Scheme = new ProbScheme();
            this.Tuples = new List<ProbTuple>();
            this.RelationName = "No Name";
            this.RenameRelationName = string.Empty;
            this.ListRenameRelation = new List<string>();
        }

        // Constructor with relation name
        public ProbRelation(string relationName)
        {
            this.IDRelation = -1;
            this.Scheme = new ProbScheme();
            this.Tuples = new List<ProbTuple>();
            this.RelationName = relationName;
            this.RenameRelationName = string.Empty;
            this.ListRenameRelation = new List<string>();
        }

        // Constructor with full parameters
        public ProbRelation(int IDRelation, string relationName, List<ProbTuple> tuples, ProbScheme scheme)
        {
            this.IDRelation = IDRelation;
            this.Scheme = scheme;
            this.Tuples = tuples;
            this.RelationName = relationName;
            this.RenameRelationName = string.Empty;
            this.ListRenameRelation = new List<string>();
        }

        #endregion

        // CRUD operations related to ProbRelation

        internal List<ProbRelation> getAllRelation()
        {
            return DALProbRelation.getAllRelation();
        }


        internal void DropTableByTableName()
        {
            DALProbRelation.DropTableByTableName(this);
        }

        internal void DeleteAllRelation()
        {
            DALProbRelation.DeleteAllRelation();
        }

        internal void InsertSystemRelation()
        {
            DALProbRelation.InsertSystemRelation(this);
        }

        internal void CreateTableRelation()
        {
            DALProbRelation.CreateTableRelation(this);
        }

        internal void InsertTupleIntoTableRelation()
        {
            DALProbRelation.InsertTupleIntoTableRelation(this);
        }

        internal void DeleteRelationById()
        {
            DALProbRelation.DeleteRelationById(this);
        }
    }
}
