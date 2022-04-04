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
            this.UserName = name;
            IsAdult = age >= 18;
            State = UserState.ReadyForGame;
            
        }

        

        public void JoinGame(string GameName)
        {
           if (State == UserState.ReadyForGame || State == UserState.InGame)
           {
                this.GameName = GameName;
           }
           else if (State == UserState.Offline)
           {
                throw new ArgumentException();
           }
        }       

        public enum UserState
        {
            InGame,
            ReadyForGame,
            Offline,
        }

        public UserState State { get; set; }

        private string GameName { get; set; }

        public void Logout()
        {
            State = UserState.Offline;
            GameName = "";
        }


    }
    

}
