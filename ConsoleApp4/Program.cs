using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           /Console.WriteLine("Please Insert your card");
       Console.ReadLine();
       Console.WriteLine("Enter your 4 digit pin");
       var pin = Int32.Parse(Console.ReadLine());
       var regPin = 8888;
       if (pin == regPin)
       {
         
       
       Console.WriteLine("Enter account number");
       var acct = Console.ReadLine();
       if (acct.Length != 10)
       {
         Console.WriteLine("Incorrect password");
       }
       }
       else
       {
         Console.WriteLine("Incorrect pin");
       }
        }
    }
}
