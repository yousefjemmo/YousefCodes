using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colection22._1
{
    internal class Student : IStudent
    {
        public int RollNo { get; set; }

        public string StudentName { get; set; }

        public List<ITestPaper> TestPapers { get; set; }
        public Student()
        {
            TestPapers = new List<ITestPaper>();
        }

        public void TakeTest(ITestPaper itestpaper)
        {
            

            foreach (var item in itestpaper.Questions)
            {
                ((Question)item).AnswerQuestion();               
            }
            TestPapers.Add(itestpaper);
            Console.WriteLine();
            foreach (var item in itestpaper.Questions)
            {
                ((Question)item).DisplayQuestiionAndResult();                
            }
            Console.WriteLine($"{StudentName}'s total scores in SubjectName({itestpaper.SubjectName}),  TestPaperName({itestpaper.TestPaperName}):{((TestPaper)itestpaper).GetTotalScores()}");

        }
    }
}
