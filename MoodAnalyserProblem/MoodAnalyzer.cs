using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer()  //Default Constructor
        {

        }

        /// Parameterised Constructor.
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        //UC1:-Analyse Happy And Sad Mood
        ///if messege Contain Sad then return Sad
        ///if message contain Happy then return Happy
        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (message.ToLower().Equals(string.Empty))
                {
                    Console.WriteLine(message);
                    throw new CustomMoodAnalyserException("Message should not be empty", CustomMoodAnalyserException.ExceptionTypes.EMPTY_MESSAGE);
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                throw new CustomMoodAnalyserException("Message should not be empty", CustomMoodAnalyserException.ExceptionTypes.EMPTY_MESSAGE);
            }

        }
    }
}
