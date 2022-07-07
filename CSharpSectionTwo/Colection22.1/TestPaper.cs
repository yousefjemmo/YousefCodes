using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colection22._1
{
    public  class TestPaper : ITestPaper
    {
        public string SubjectName
        {
            get;
            set;
        }

        public string TestPaperName
        {
            get;
            set;
        }

        public List<IQuestion> Questions
        {
            get;
            set;
        }
    
        public void TakeTest()
        {
            foreach (var item in Questions)
            {
                item.AnswerQuestion();
            }
        }
        public int GetTotalScores()
        {
            int totalScores = 0;
            foreach (var item in Questions)
            {
                totalScores += item.MarksSecured;
            }
            return totalScores;
        }
    }
}
