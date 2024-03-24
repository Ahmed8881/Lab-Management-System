using System.Data;
using System.Data.SqlClient;
using MID.DL;

class ResultBL
{
    private static DBConfig dBConfig = new DBConfig();
    private string StudentRegNo;
    private string AssessmentTitle;
    private string ComponentName;
    private string RubricDetail;
    private int RubricLevel;
    private DateTime EvaluationDate;
    public ResultBL(string studentRegNo, string assessmentTitle, string componentName, string rubricDetail, int rubricLevel, DateTime evaluationDate)
    {
        StudentRegNo = studentRegNo;
        AssessmentTitle = assessmentTitle;
        ComponentName = componentName;
        RubricDetail = rubricDetail;
        RubricLevel = rubricLevel;
        EvaluationDate = evaluationDate;
    }
    public int GetStudentID()
    {
        string query = "SELECT Id FROM Student WHERE RegistrationNumber = '" + StudentRegNo + "'";
        return Convert.ToInt32(dBConfig.GetData(query).Rows[0]["Id"]);
    }
    public int GetAssessmentComponentId()
    {
        string query = "SELECT Id FROM AssessmentComponent WHERE Name = '" + ComponentName + "'";
        return Convert.ToInt32(dBConfig.GetData(query).Rows[0]["Id"]);
    }
    public int GetRubricLevelId()
    {
        string query = $"SELECT Id FROM RubricLevel WHERE MeasurementLevel = {RubricLevel} AND RubricId = (SELECT Id from Rubric Where Details = '{RubricDetail}')";
        return Convert.ToInt32(dBConfig.GetData(query).Rows[0]["Id"]);
    }
    public DateTime GetEvaluationDate()
    {
        return EvaluationDate;
    }

}