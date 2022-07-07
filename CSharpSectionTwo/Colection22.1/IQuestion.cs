using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colection22._1
{
    public interface IQuestion
    {
        string QuestionText { get; set; }
        List<IOption> Options { get; set; }
        char CorrectAnswerLetter { get; set; }
        char OptionSelectedByStudent { get; set; }
        int MarksSecured { get; set; }
        void DisplayQuestion();
        void AnswerQuestion();
    }
}
