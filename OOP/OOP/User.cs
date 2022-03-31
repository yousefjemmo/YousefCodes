using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class User
   {
        public string UserName;
        public bool IsAdult;
        private bool InGame;

       
        public User(string name, int age)
        {
            this.UserName = name;
            IsAdult = age >= 18;        
        }

        

        public void JoinGame()
        {
           if (InGame == false)
           {
                InGame = true;
           }
           else
           {
                throw new InvalidOperationException();
           }
        }
   }
    

}
