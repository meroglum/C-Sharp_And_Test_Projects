using QuizApp;

/// <summary>
/// Created by Muhammed EROGLU
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        QuestionBrain questionBrain = new QuestionBrain();//Class initialization.
        questionBrain.QuestionHandler(); // Calls method from the class
        questionBrain.ShowResult(); // Shows the quiz result.
        using (StreamWriter writer = new StreamWriter("Wfile.txt"))
        {
             writer.WriteLine("demo data"); // Saves 
        }
       // writer.Close(); if using exists, there is no need to use close keywoed
    }
}