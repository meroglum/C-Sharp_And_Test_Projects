using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
     interface IQuestionBrain
    {
        public void SaveGivenAnswers(string givenAnswer);
        public void QuestionHandler();
        public void ShowQuestion();
        public void NextQuestion();
        public void ShowTheEnd();
        public void ShowResult();
        public void WriteOnYourOwnQuestions(List<string> YourQuestionList);
    }
}
