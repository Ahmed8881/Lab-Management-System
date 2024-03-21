using MID.DL;
using System.Data;

class RubricLevelDL
{
    private static DBConfig DBConfig = new DBConfig();
    private static string GetAllDataQuery = "SELECT * FROM RubricLevel";

    // To fill the Data Grid View with RubricLevel Data
    public static DataTable GetRubricLevelData()
    {
        return DBConfig.GetData(GetAllDataQuery);
    }
    public static List<int> GetRubricId()
    {
        string query = "SELECT Id FROM Rubric";
        DataTable dt = DBConfig.GetData(query);
        List<int> ids = new List<int>();
        foreach (DataRow dr in dt.Rows)
        {
            ids.Add(int.Parse(dr["Id"].ToString()));
        }
        return ids;
    }
    public static bool AddRubricLevel(string Details, int RubricId, int MeasurementLevel)
    {
        string query = "Insert into RubricLevel(Details, RubricId, MeasurementLevel) values('@Details', @RubricId, @MeasurementLevel)";
        query = query.Replace("@Details", Details);
        query = query.Replace("@RubricId", RubricId.ToString());
        query = query.Replace("@MeasurementLevel", MeasurementLevel.ToString());
        return DBConfig.ExecuteCommand(query);
    }
    public static bool DeleteRubricLevel(int Id)
    {
        string query = "DELETE FROM RubricLevel WHERE Id = @Id";
        query = query.Replace("@Id", Id.ToString());
        return DBConfig.ExecuteCommand(query);
    }
    public static bool UpdateRubricLevel(int Id, string Details, int RubricId, int MeasurementLevel)
    {
        string query = "UPDATE RubricLevel SET Details = '@Details', RubricId = @RubricId, MeasurementLevel = @MeasurementLevel WHERE Id = @Id";
        query = query.Replace("@Details", Details);
        query = query.Replace("@RubricId", RubricId.ToString());
        query = query.Replace("@MeasurementLevel", MeasurementLevel.ToString());
        query = query.Replace("@Id", Id.ToString());
        return DBConfig.ExecuteCommand(query);
    }
}