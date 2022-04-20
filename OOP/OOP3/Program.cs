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
            var newTicket = board.GetTicketsByState(State.New);

            if (newTicket.Count == 0)
            {
                Console.WriteLine("There is no tickets. Please add tickets first");
            }
            else if (newTicket.Count >= 1)
            {
                Console.WriteLine("take ticket in work ");
                Console.Write("Please Insert your name: ");
                string name = Console.ReadLine().ToUpper();
                newTicket[0].PutToWork(name);
            }                                          
        }

        public static void EndTicket(Board board)
        {
            
            Console.WriteLine("End Ticket");
            board.GetTicketsByState(State.Active);

            var newTicket = board.GetTicketsByState(State.Active);            
            if (newTicket.Count == 0)
            {
                Console.WriteLine("There is no ticket");
            }
            else if (newTicket.Count >= 1)
            {
                newTicket[0].FinishWork();

                var ticket = newTicket[0];
                for (int i = 0; i < newTicket.Count; i++)
                {
                    Console.WriteLine(ticket.GetTitle());
                    Console.WriteLine(ticket.GetAuthor());
                    Console.WriteLine(ticket.GetAssignee());

                }
            }       

           
        }

        public static void ShowTickets(Board board)
        {
            Console.WriteLine("Show Ticket");
            Console.Write("Please insert a state New, Done or Active: ");
            string state = Console.ReadLine().ToLower();

            if (state == "new")
            {
 
                checkstate(board , State.New);

            }
            else if (state == "active")
            {
          
                checkstate(board, State.Active);

            }
            else if (state == "done")
            {
          
                checkstate(board , State.Done);
            }
        }

        public static void DeleteTickets(Board board)
        {
            Console.WriteLine("Delete Tickets");
            board.RemoveAllFinishedTickets();
        }

        public static void checkstate(Board board, State state)
        {
            var tiketsLists = board.GetTicketsByState(state);

            foreach (var ticket in tiketsLists)
            {
                Console.WriteLine(ticket.GetTitle());
                Console.WriteLine(ticket.GetAuthor());
                Console.WriteLine(ticket.GetAssignee());
            }
        }       
    }
}
