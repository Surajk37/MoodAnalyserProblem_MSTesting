using System.Runtime.Serialization;

namespace MoodAnalyserProblem
{
    [Serializable]
    public class CustomMoodAnalyserException : Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE
        }
        public CustomMoodAnalyserException(string msg, ExceptionTypes exceptionTypes) : base(msg)
        {
            this.exceptionTypes = exceptionTypes;
            Console.WriteLine(msg);
        }
    }
}