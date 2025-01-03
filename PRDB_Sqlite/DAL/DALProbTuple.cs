using PRDB_Sqlite.BLL;
using System.Collections.Generic;
using System.Data;

namespace PRDB_Sqlite.DAL
{
    public class DALProbTuple
    {
        internal static List<ProbTuple> getAllTypleByRelationName(string relationName, int nTriples)
        {
            List<ProbTuple> probTupleList = new List<ProbTuple>();  
            DataBase db = new DataBase();
            // Use parameterized query to prevent SQL injection
            DataTable dtb = db.GetDataTable("SELECT * FROM " + relationName);

            foreach (DataRow tupleRow in dtb.Rows)
            {
                ProbTuple newTuple = new ProbTuple();

                // Create ProbTriple objects for each column in the row
                for (int i = 0; i < nTriples; i++)
                {
                    // Assumes each column contains a valid ProbTriple representation
                    ProbTriple newTriple = new ProbTriple(tupleRow[i].ToString());
                    newTuple.Triples.Add(newTriple);
                }

                probTupleList.Add(newTuple);
            }
            return probTupleList;
        }

        // Implement DeleteTypeById to delete a tuple by its identifier (ID or another unique property)
        internal static void DeleteTypeById(ProbTuple probTuple)
        {
            //DataBase db = new DataBase();

            //// Assuming probTuple has an ID or some identifier that allows for deletion
            //// For now, we use a placeholder; replace with actual field name
            //string deleteQuery = $"DELETE FROM {probTuple.RelationName} WHERE ID = {probTuple.IDRelation}";

            //db.ExecuteNonQuery(deleteQuery); // Executes the deletion query
        }
    }
}
