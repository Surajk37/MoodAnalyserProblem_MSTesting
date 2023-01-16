namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Mood Analyser Problem using MSTest\n");
            Console.WriteLine("Please Select option");
            Console.WriteLine("\n1. Analyse Mood Happy or Sad \n2. Exception Handling if Invalid input");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    //UC1:-Respond Happy and Sad Mood
                    MoodAnalyzer analyser = new MoodAnalyzer("I am in Sad Mood");
                    Console.WriteLine("I am in Sad Mood:- " + analyser.AnalyzeMood());
                    MoodAnalyzer analysermood = new MoodAnalyzer("I am in Happy Mood");
                    Console.WriteLine("I am in Any Mood:- " + analysermood.AnalyzeMood());
                    break;
                case 2:
                    //UC2:-Null mood Should Return Happy
                    MoodAnalyzer moodAnalyser = new MoodAnalyzer("");
                    Console.WriteLine("Given Null Message:- " + moodAnalyser.AnalyzeMood());
                    break;
            }
            Console.ReadLine();
        }
    }
}