using System;
using System.Collections.Generic;

namespace Null
{
    class Program
    {
        static void Main()
        {
            var people = Attendance();
            if (people == null)
            {
                Console.WriteLine("Don't have people");
            }
            else
            {
                WhoIsHere(people);
            }
  

            ValidationNull();
            NullCoalescingOperator();
            Console.ReadLine();
        }

        static void ValidationNull()
        {
            int? a = null;
            int? b = a ?? 20;

            Console.WriteLine(b);

            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User didn't answer the question");
            }

        }

        static void NullCoalescingOperator()
        {

            //Logic without coalescing operator
            int? TicketOnSale = 10;
            int AvailableTickets;

            if (TicketOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketOnSale;
            }

            Console.WriteLine("AvaialableTickets = {0} using normal operation", AvailableTickets);


            //logic with coalescing operator
            int? TicketOnSaleCoalescing = null;
            int AvailableTicketsCoalescing = TicketOnSaleCoalescing ?? 0;


            Console.WriteLine("AvaialableTickets = {0} using coalescing operation", AvailableTicketsCoalescing);
        }

        static IEnumerable<Person>? Attendance()
        {
            return null;
        }

        static void WhoIsHere(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person.Details!.FirstName);
            }
        }
    }
}
