using System.CodeDom.Compiler;

class Scripture
{
    private string _reference = "John 1:1";
    private List<string> _scripture = new List<string>()
    {
        "for", "God", "so", "loved", "the", "world."
    };

    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (string word in _scripture)
        {
            Console.Write(word + ' ');
        }
    }
}