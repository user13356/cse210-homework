public class WritingAssignment : Assignment

{
    private string _title;

    //WritingAssignment constructor
    
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)

    {
        
        _title = title;
        
    }

    public string GetWritingInformation()
    
    {
        
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";

    }
}