public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base"

    public MathAssignment(string studentName, string topic, string texbookSection, string probblems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSection = _textbookSection;
        _problems = probblems;
    }

    public string GetHomeworkList()
    {
        return $"section {_textbookSection} problems {_problems}"
    }
}