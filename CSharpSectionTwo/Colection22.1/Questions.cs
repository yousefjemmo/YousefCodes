using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colection22._1
{
    internal class Question : IQuestion
    {
        public string QuestionText { get; set; }
        public List<IOption> Options { get; set; }
        public char CorrectAnswerLetter { get; set; }
        public char OptionSelectedByStudent { get; set; }

        public int MarksSecured { get; set; }
        public void DisplayQuestion()
        {
            Console.WriteLine($"{QuestionText}:");
            foreach (var item in Options)
            {
                Console.WriteLine($"\n{item.OptionLetter}: {item.OptionText}");
            };
            Console.WriteLine();
        }
        public void DisplayQuestiionAndResult()
        {
            DisplayQuestion();
            Console.WriteLine($"The correct answer is:{CorrectAnswerLetter}");
            Console.WriteLine($"Your answer is:{OptionSelectedByStudent}");
            Console.WriteLine($"MarksSecured is:{MarksSecured}");
        }

        public void AnswerQuestion()
        {
            string answer;
            do
            {
                DisplayQuestion();
                Console.Write("Your choice: ");
                answer = Console.ReadLine(); 

            } while (!(answer.Length > 0 && Options.Any(item => item.OptionLetter == (answer.ToUpper())[0])));
            OptionSelectedByStudent = (answer.ToUpper())[0];

            if (CorrectAnswerLetter == (answer.ToUpper())[0])
            {               
                MarksSecured = 1;      
            }

            
        }
    }
}
