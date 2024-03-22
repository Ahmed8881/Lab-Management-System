using MID.DL;
using System.Data;

class AssessmentComponentDL
{
    private static DBConfig dBConfig = new DBConfig();
    public static DataTable GetData()
    {
        return dBConfig.GetData("SELECT * FROM AssessmentComponent");
    }
    // To fill rubric id combo box
    public static List<int> GetRubricIds()
    {
        DataTable ids = dBConfig.GetData("SELECT Id FROM Rubric");
        List<int> rubricIds = new List<int>();
        foreach (DataRow dr in ids.Rows)
        {
            rubricIds.Add(int.Parse(dr["Id"].ToString()));
        }
        return rubricIds;
    }
    // To fill Assessment id combo box
    public static List<int> GetAssessmentIds()
    {
        DataTable ids = dBConfig.GetData("SELECT Id FROM Assessment");
        List<int> assessmentIds = new List<int>();
        foreach (DataRow dr in ids.Rows)
        {
            assessmentIds.Add(int.Parse(dr["Id"].ToString()));
        }
        return assessmentIds;
    }
    public static bool AddData(string Name, int RubricId, int AssessmentId, int TotalMarks)
    {
        string query = "INSERT INTO AssessmentComponent(Name, RubricId, AssessmentId, TotalMarks) VALUES('@Name', @RubricId, @AssessmentId, @TotalMarks)";
        query = query.Replace("@Name", Name);
        query = query.Replace("@RubricId", RubricId.ToString());
        query = query.Replace("@AssessmentId", AssessmentId.ToString());
        query = query.Replace("@TotalMarks", TotalMarks.ToString());
        return dBConfig.ExecuteCommand(query);
    }
    public static bool UpdateData(int Id, string Name, int RubricId, int AssessmentId, int TotalMarks)
    {
        string query = "UPDATE AssessmentComponent SET Name = '@Name', RubricId = @RubricId, AssessmentId = @AssessmentId, TotalMarks = @TotalMarks WHERE Id = @Id";
        query = query.Replace("@Name", Name);
        query = query.Replace("@RubricId", RubricId.ToString());
        query = query.Replace("@AssessmentId", AssessmentId.ToString());
        query = query.Replace("@TotalMarks", TotalMarks.ToString());
        query = query.Replace("@Id", Id.ToString());
        return dBConfig.ExecuteCommand(query);
    }
    public static bool DeleteData(int Id)
    {
        return dBConfig.ExecuteCommand("DELETE FROM AssessmentComponent WHERE Id = " + Id);
    }
}