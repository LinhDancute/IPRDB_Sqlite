using PRDB_Sqlite.DAL;
using System.Collections.Generic;

namespace PRDB_Sqlite.BLL
{
    public class ProbTuple
    {

        #region Properties
        // Tập các giá trị bộ ba xác suất trên một tuple
        public List<ProbTriple> Triples { get; set; }
        #endregion

        #region Methods

        public ProbTuple()
        {
            this.Triples = new List<ProbTriple>();
        }

        public ProbTuple(ProbTuple tuple)
        {
            this.Triples = new List<ProbTriple>();
            foreach (ProbTriple item in tuple.Triples)
            {
                this.Triples.Add(new ProbTriple(item));
            }
        }

        internal List<ProbTuple> GetAllTypleByRelationName(string relationName, int nTriples)
        {
            return DALProbTuple.getAllTypleByRelationName(relationName, nTriples);
        }

        internal void DeleteTypeById()
        {
            DALProbTuple.DeleteTypeById(this);
        }

        #endregion
    }


}
