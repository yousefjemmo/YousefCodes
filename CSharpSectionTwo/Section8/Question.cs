using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    internal class Question
    {
       
            public string questionText;
            public string optionA;
            public string optionB;
            public string optionC;
            public string optionD;
            public char correctAnswerLetter;
            private static char defaultCorrectAnswerLetter = 'X';

           
            public Question()
            {
                questionText = null;
                optionA = null;
                optionB = null;
                optionC = null;
                optionD = null;
                correctAnswerLetter = Question.defaultCorrectAnswerLetter; 
            }

          
            public Question(string questionText)
            {
                this.questionText = questionText;
                optionA = null;
                optionB = null;
                optionC = null;
                optionD = null;
                correctAnswerLetter = Question.defaultCorrectAnswerLetter; 
            }

            
            public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
            {
                this.questionText = questionText;
                this.optionA = optionA;
                this.optionB = optionB;
                this.optionC = optionC;
                this.optionD = optionD;
                if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D') 
                    this.correctAnswerLetter = correctAnswerLetter;
                else
                    this.correctAnswerLetter = Question.defaultCorrectAnswerLetter; 
            }

            
            public bool AreOptionsValid()
            {
                return (optionA != null || optionB != null) && (optionC != null || optionD != null);
            }
        
    }
}
