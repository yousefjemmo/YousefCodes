using System;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board MyObj = new Board();
            

            bool repeat = false;

            while (!repeat)
            {
                string input = AskUser();
                if (input == "A")
                {
                    var Ticket = CreateTicket();
                    MyObj.AddTicket(Ticket);
                }
                else if (input == "B")
                {
                    TakeTicketInWork(MyObj);
                }
                else if (input == "C")
                {
                    EndTicket(MyObj);
                }
                else if (input == "D")
                {
                    ShowTickets(MyObj);
                }
                else if (input == "E")
                {
                    DeleteTickets(MyObj);
                }
                else if (input == "F")
                {
                    Console.WriteLine("End");
                    repeat = true;
                }
            }
            

        }

        public static string AskUser()
        {
            Console.WriteLine("What Action you want to take? Please Insert between A to F: ");
            Console.WriteLine("A. Create ticket ");
            Console.WriteLine("B. take ticket in work ");
            Console.WriteLine("C. end ticket ");
            Console.WriteLine("D. show tickets ");
            Console.WriteLine("E. Delete tickets ");
            Console.WriteLine("F. end ");

            return Console.ReadLine().ToUpper();
        }

        public static Ticket CreateTicket()
        {
            Ticket Ticket1;
            Console.WriteLine("Create ticket");
            Console.Write("Please Give a Autor Name: ");
            string Autor = Console.ReadLine().ToUpper();
            Console.Write("Please Give a Title Name: ");
            string Title = Console.ReadLine().ToUpper();

            Ticket1 = new Ticket(Autor);
            Ticket1.SetTitle(Title);

            return Ticket1;
        }

        public static void TakeTicketInWork(Board board)
        {           

            Console.WriteLine("take ticket in work ");
            Console.Write("Please Insert your name: ");
            string name = Console.ReadLine().ToUpper();            

            var newTicket = board.GetTicketsByState(State.New);
            foreach (var ticket in newTicket)
            {
                ticket.PutToWork(name);
            }
                       
               
        }

        public static void EndTicket(Board board)
        {
            Console.WriteLine("End Ticket");
            board.GetTicketsByState(State.Active);

            var newTicket = board.GetTicketsByState(State.Active);
            newTicket[0].FinishWork();
        }

        public static void ShowTickets( Board board)
        {
            Console.WriteLine("Show Ticket");
            Console.Write("Please insert a state New, Done or Active: ");
            string state = Console.ReadLine().ToLower();           

            if (state == "new")
            {
                var StateNew = board.GetTicketsByState(State.New);              

                foreach (var ticket in StateNew)
                {
                    Console.WriteLine(ticket.GetTitle());
                    Console.WriteLine(ticket.GetAuthor());
                    Console.WriteLine(ticket.GetAssignee());
                }
                
            }
            else if (state == "active")
            {
                var StateActive = board.GetTicketsByState(State.Active);               

                foreach (var ticket in StateActive)
                {
                    Console.WriteLine(ticket.GetTitle());
                    Console.WriteLine(ticket.GetAuthor());
                    Console.WriteLine(ticket.GetAssignee());
                }

            }
            else if (state == "done")
            {
                var StateDone = board.GetTicketsByState(State.Done);
                
                foreach (var ticket in StateDone)
                {
                    Console.WriteLine(ticket.GetTitle());
                    Console.WriteLine(ticket.GetAuthor());
                    Console.WriteLine(ticket.GetAssignee());
                }

            }
        }

        public static void DeleteTickets(Board board)
        {
            Console.WriteLine("Delete Tickets");
            board.RemoveAllFinishedTickets();
        }
    }
}
