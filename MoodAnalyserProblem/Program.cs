namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Mood Analyser Problem using MSTest\n");
            
            //UC1:-Respond Happy and Sad Mood
            MoodAnalyzer analyser = new MoodAnalyzer("I am in Sad Mood");
            Console.WriteLine("I am in Sad Mood:- " + analyser.AnalyzeMood());
            MoodAnalyzer analysermood = new MoodAnalyzer("I am in Happy Mood");
            Console.WriteLine("I am in Any Mood:- " + analysermood.AnalyzeMood());

            Console.ReadLine();
        }
    }
}