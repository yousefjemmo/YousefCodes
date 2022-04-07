using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{    
    internal class Ticket
    {
        private string Author , Title, Assignee;
        private State state;


        public Ticket(string author)
        {
            Author = author;
            state = State.New;
        }

        public void PutToWork(string assignee)
        {
            Assignee = assignee;
            state = State.Active;
        }

        public void FinishWork()
        {
            Assignee = "";
            state = State.Done;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAssignee()
        {
            return Assignee;
        }

        public State GetState()
        {
            return state;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }
    }

    
}
