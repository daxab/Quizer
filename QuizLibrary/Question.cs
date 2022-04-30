using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizLibrary
{
    public enum QuestionType
    {
        Choice,
        Open
    }
    public class Question
    {
        public int Number;
        public string QuestionText;
        public QuestionType Type;
        public List<string> Answer;
    }
}
