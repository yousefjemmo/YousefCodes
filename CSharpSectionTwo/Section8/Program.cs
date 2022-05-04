using System;

namespace Section8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question question1 = new Question(); 
            Question question2 = new Question("In which continent is costa rica situated?"); 
            Question question3 = new Question("In which continent is costa rica situated?", "Asia", "North America", "South America", "Africa", 'B'); 
            Question question4 = new Question() { questionText = "In which continent is costa rica situated?", optionA = "Asia", optionB = "North America", optionC = "South America", optionD = "Africa" }; 
            
        }
    }
}
