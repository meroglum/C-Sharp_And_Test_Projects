using _2023._01._06_exercise;
using System.Xml.Linq;

/// <summary>
/// Created by Muhammed EROGLU
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        XMLDocumnet xMLDocumnet= new XMLDocumnet();
        xMLDocumnet.AddStudent();
        xMLDocumnet.LoadDocument();
    }
}