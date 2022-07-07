using System;
using System.Collections.Generic;
using System.Linq;

namespace Colection22._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testPaperA = new TestPaper() { SubjectName = "General Questions", TestPaperName = "Middle term" };
            
            List<Question> questionsA = new List<Question>()
            {
                                 new Question () {QuestionText = "What is the capital of the USA?",
                                 Options = new List<IOption>(){ new Option() {OptionLetter='A', OptionText = "London"}, new Option() {OptionLetter='B', OptionText = "New York"}, new Option() {OptionLetter='C', OptionText = "Washington, D.C."}, new Option() {OptionLetter='D', OptionText = "San Diego"}},
                                 CorrectAnswerLetter='C'},

                                 new Question () {QuestionText = "what is the biggest continent",
                                 Options = new List<IOption>(){ new Option() {OptionLetter='A', OptionText = "Europa"}, new Option() {OptionLetter='B', OptionText = "Asia"},
                                 new Option() {OptionLetter='C', OptionText = "Africa"}, new Option() {OptionLetter='D', OptionText = "North Amercia"}},
                                 CorrectAnswerLetter='B'},

                                 new Question () {QuestionText = "Who won 2018 World Cup?",
                                 Options = new List<IOption>(){ new Option() {OptionLetter='A', OptionText = "Germany"}, new Option() {OptionLetter='B', OptionText = "Spain"}, new Option() {OptionLetter='C', OptionText = "France"}, new Option() {OptionLetter='D', OptionText = "Brazil"}},
                                 CorrectAnswerLetter='C'},

                      
            };

            
            testPaperA.Questions = questionsA.ToList<IQuestion>();
            var testPaperB = new TestPaper() { SubjectName = "Internet", TestPaperName = "Final Exam" };          
            List<Question> questionsB = new List<Question>()
            {
                                 new Question () {QuestionText = "What are people who write computer code called?",
                                 Options = new List<IOption>(){ new Option() {OptionLetter='A', OptionText = "Professors"}, new Option() {OptionLetter='B', OptionText = "Cryptographers"},
                                            new Option() {OptionLetter='C', OptionText = "Programmers"} },
                                 CorrectAnswerLetter='C'},
                                 new Question () {QuestionText = "Which of theses is NOT a programming language?",
                                 Options = new List<IOption>(){ new Option() {OptionLetter='A', OptionText = "Ruby"}, new Option() {OptionLetter='B', OptionText = "Python"}, new Option() {OptionLetter='C', OptionText = "Banana"},
                                                                new Option() {OptionLetter='D', OptionText = "Java"}},
                                 CorrectAnswerLetter='C'},
                                 new Question () {QuestionText = "What is computer coding?",
                                 Options = new List<IOption>(){ new Option() {OptionLetter='A', OptionText = "A TV show"}, new Option() {OptionLetter='B', OptionText = "Telling a computer what to do"},
                                        new Option() {OptionLetter='C', OptionText = "A list of functions"}, new Option() {OptionLetter='D', OptionText = "A radio show"}},
                                 CorrectAnswerLetter='B'},
                        
            };
            testPaperB.Questions = questionsB.ToList<IQuestion>();
            var student = new Student() { RollNo = 1, StudentName = "Yousef" };
            student.TakeTest(testPaperA);
            Console.WriteLine("\n");
            Console.WriteLine("---------- Paper 2 exam starts now ----------");
            Console.WriteLine("\n");
            student.TakeTest(testPaperB);

        }
    }
}
