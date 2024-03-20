using System.Data;
using MID.DL;

class AssessmentDL
{
    private static DBConfig DBConfig = new DBConfig();
    private static string GetAllDataQuery = "SELECT * FROM Assessment";
    public static DataTable GetAssessmentData()
    {
        return DBConfig.GetData(GetAllDataQuery);
    }
    public static bool AddAssessment(string Title, int TotalMarks, int TotalWeightage)
    {
        string query = "Insert into Assessment(Title, DateCreated, TotalMarks, TotalWeightage) values('@Title', GetDate(), @TotalMarks, @TotalWeightage)";
        query = query.Replace("@Title", Title);
        query = query.Replace("@TotalMarks", TotalMarks.ToString());
        query = query.Replace("@TotalWeightage", TotalWeightage.ToString());
        return DBConfig.ExecuteCommand(query);
    }
    public static bool DeleteAssessment(int Id)
    {
        string query = "DELETE FROM Assessment WHERE Id = @Id";
        query = query.Replace("@Id", Id.ToString());
        return DBConfig.ExecuteCommand(query);
    }
    public static bool UpdateAssessment(int Id, string Title, int TotalMarks, int TotalWeightage)
    {
        string query = "UPDATE Assessment SET Title = '@Title', TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Id = @Id";
        query = query.Replace("@Title", Title);
        query = query.Replace("@TotalMarks", TotalMarks.ToString());
        query = query.Replace("@TotalWeightage", TotalWeightage.ToString());
        query = query.Replace("@Id", Id.ToString());
        return DBConfig.ExecuteCommand(query);
    }
}