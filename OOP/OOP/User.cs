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

        public User(string name, int age)
        {
            UserName = name;
            IsAdult = age >= 18;
        }
   }
    

}
