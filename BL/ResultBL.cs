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
    private double Marks;
    public ResultBL(string studentRegNo, string assessmentTitle, string componentName, string rubricDetail, int rubricLevel, DateTime evaluationDate)
    {
        StudentRegNo = studentRegNo;
        AssessmentTitle = assessmentTitle;
        ComponentName = componentName;
        RubricDetail = rubricDetail;
        RubricLevel = rubricLevel;
        EvaluationDate = evaluationDate;
    }
    // Getters and Setters
    public string GetStudentRegNo()
    {
        return StudentRegNo;
    }
    public void SetStudentRegNo(string studentRegNo)
    {
        StudentRegNo = studentRegNo;
    }
    public string GetAssessmentTitle()
    {
        return AssessmentTitle;
    }
    public void SetAssessmentTitle(string assessmentTitle)
    {
        AssessmentTitle = assessmentTitle;
    }
    public string GetComponentName()
    {
        return ComponentName;
    }
    public void SetComponentName(string componentName)
    {
        ComponentName = componentName;
    }
    public string GetRubricDetail()
    {
        return RubricDetail;
    }
    public void SetRubricDetail(string rubricDetail)
    {
        RubricDetail = rubricDetail;
    }
    public int GetRubricLevel()
    {
        return RubricLevel;
    }
    public void SetRubricLevel(int rubricLevel)
    {
        RubricLevel = rubricLevel;
    }
    public DateTime GetEvaluationDate()
    {
        return EvaluationDate;
    }
    public void SetEvaluationDate(DateTime evaluationDate)
    {
        EvaluationDate = evaluationDate;
    }
    public double GetMarks()
    {
        return Marks;
    }
    public void SetMarks(double marks)
    {
        Marks = marks;
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
    public void CalculateMarks()
    {
        int RubricLevelID = GetRubricLevelId();
        int AssessmentComponentID = GetAssessmentComponentId();
        string query = "Select MeasurementLevel From RubricLevel Where Id = " + RubricLevelID;
        int ObtainedRubricLevel = Convert.ToInt32(dBConfig.GetData(query).Rows[0]["MeasurementLevel"]);
        query = "Select TotalMarks From AssessmentComponent Where Id = " + AssessmentComponentID;
        int TotalMarks = Convert.ToInt32(dBConfig.GetData(query).Rows[0]["TotalMarks"]);
        query = "Select Max(MeasurementLevel) From RubricLevel Where RubricId = (Select RubricId From AssessmentComponent Where Id = " + AssessmentComponentID + ")";
        int MaxRubricLevel = Convert.ToInt32(dBConfig.GetData(query).Rows[0][0]);
        Marks = ObtainedRubricLevel / MaxRubricLevel * TotalMarks;
    }

}