using MID.DL;
using System.Data;
using System.Data.SqlClient;

class RubricDL
{
    private static DBConfig DBConfig = new DBConfig();
    private static string GetAllDataQuery = "SELECT * FROM Rubric";

    // To fill the Data Grid View with Rubric Data
    public static DataTable GetRubricData()
    {
        return DBConfig.GetData(GetAllDataQuery);
    }
    // Return a list of Clo Ids
    // Can be used with a foreach loop to fill combo box for clo id
    public static List<int> GetCLOIds()
    {
        string query = "SELECT Id FROM Clo";
        DataTable dt = DBConfig.GetData(query);
        List<int> ids = new List<int>();
        foreach (DataRow dr in dt.Rows)
        {
            ids.Add(int.Parse(dr["Id"].ToString()));
        }
        return ids;
    }
    public static bool AddRubric(string Details, int CloId)
    {
        string query = "Insert into Rubric(Details, CloId) values('@Details', @CloId)";
        query = query.Replace("@Details", Details);
        query = query.Replace("@CloId", CloId.ToString());
        return DBConfig.ExecuteCommand(query);
    }
    public static bool DeleteRubric(int Id)
    {
        string query = "DELETE FROM Rubric WHERE Id = @Id";
        query = query.Replace("@Id", Id.ToString());
        return DBConfig.ExecuteCommand(query);
    }
    public static bool UpdateRubric(int Id, string Details, int CloId)
    {
        string query = "UPDATE Rubric SET Details = '@Details', CloId = @CloId WHERE Id = @Id";
        query = query.Replace("@Details", Details);
        query = query.Replace("@CloId", CloId.ToString());
        query = query.Replace("@Id", Id.ToString());
        return DBConfig.ExecuteCommand(query);
    }
}