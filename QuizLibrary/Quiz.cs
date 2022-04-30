using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
    class Quiz
    {
        public List<Question> Questions;

        public Quiz()
        {
            Questions = new List<Question>();
        }

        public static Quiz GetTestQuiz()
        {
            Quiz quiz = new Quiz();


            Question q = new Question();
            q.Number = 1;
            q.QuestionText = "dsds";
            q.Type = QuestionType.Choice;
            q.Answer.Add("dsd");
            q.Answer.Add("ds");
            q.Answer.Add("dsasdasd");

            quiz.Questions.Add(q);

            return quiz;
        }
    }
}
