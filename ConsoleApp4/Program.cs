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
          Console.WriteLine("Please Insert your card");
          Console.ReadLine();
          Console.WriteLine("Enter your 4 digit pin");
          var pin = Int32.Parse(Console.ReadLine());
          var regPin = 8888; var accountBalance = 350000; 
          if (pin == regPin)
            {

              Console.WriteLine("Please select your option");
              Console.WriteLine("1)TRANSFERS     2)RECHARGE     3) DSTV BILL PAYMENT");
              var options = int.Parse(Console.ReadLine());

              if (options == 1)
                {
                   Console.WriteLine("Enter destination account number:");
                   var acct = Console.ReadLine();

                   if (acct.Length == 10)
                    {
                     Console.WriteLine("Enter Amount:");
                     var amount = int.Parse(Console.ReadLine());

                     if (amount <= accountBalance)
                      {
                        var balance = accountBalance - amount;
                        Console.WriteLine($"Transaction Successful, your new balance is #{balance}");
                      }
                     else
                      {
                        Console.WriteLine("##INSUFFICIENT FUNDS##");
                      }
                     
                    }
                   else
                    {
                     Console.WriteLine("##Incorrect account number##");
                    }
                }

              if (options == 2)
               {
                    Console.WriteLine("Please select your option");
                    Console.WriteLine("1)Self Recharge     2)Third Party Recharge");
                    options = int.Parse(Console.ReadLine());

                    if (options == 1)
                    {
                        Console.WriteLine("Enter Amount:");
                        var amt = int.Parse(Console.ReadLine());

                        if (amt <= accountBalance)
                        {
                            Console.WriteLine($"YOUR LINE HAS BEEN SUCCESSFULLY REECHARGED WITH {amt}");
                        }
                        else
                        {
                            Console.WriteLine("##INSUFFICIENT FUNDS##");
                        }
                    }
                    else if (options == 2)
                    {
                        Console.WriteLine("ENTER RECIPIENT PHONENUMBER:");
                        var number = Console.ReadLine();
                        Console.WriteLine("ENTER AMOUNT:");
                        var amt = int.Parse(Console.ReadLine());
                        if (amt<= accountBalance)
                        {
                            Console.WriteLine($"{number} has been creditted {amt} successfully");
                        }
                        else
                        {
                            Console.WriteLine("##INSUFFICIENT FUND##");
                        }
                    }
                    else
                    {
                        Console.WriteLine("##INVALID INPUT");
                    }
                }
              if (options == 3)
               {
                   Console.WriteLine("ENTER YOUR DSTV SMART CARD NUMBER:");
                   var cardNumber = Console.ReadLine();
                   var card = "112233445566";
                   if (card == cardNumber)
                    {
                     Console.WriteLine("Select Plan:");
                     Console.WriteLine("1)Full package  2)DSTV Mini  3)DSTV4All");
                     var plan = int.Parse(Console.ReadLine());

                     switch(plan)
                        {
                            case 1:
                                Console.WriteLine("PAY 15000 TO SUBSCRIBE NOW:");
                                Console.WriteLine("1) YES   2)NO");
                                var input = int.Parse(Console.ReadLine());
                                if (input == 1)
                                {
                                    Console.WriteLine("YOU HAVE SUCCESSFULLY SUBSCRIBED FOR THE FULL PACKAGE");
                                }
                            break;

                            case 2:
                                Console.WriteLine("PAY 10000 TO SUBSCRIBE NOW:");
                                Console.WriteLine("1) YES   2)NO");
                                input = int.Parse(Console.ReadLine());
                                if (input == 1)
                                {
                                    Console.WriteLine("YOU HAVE SUCCESSFULLY SUBSCRIBED FOR THE MINI PACKAGE");
                                }
                            break;

                            case 3:
                                Console.WriteLine("PAY 7000 TO SUBSCRIBE NOW:");
                                Console.WriteLine("1) YES   2)NO");
                                input = int.Parse(Console.ReadLine());
                                if (input == 1)
                                {
                                    Console.WriteLine("YOU HAVE SUCCESSFULLY SUBSCRIBED FOR DSTV4ALL");
                                }
                            break;

                            default:
                                Console.WriteLine("INCORRECT SELECTION");
                            break;

                        }
                      
                    }
                    else
                    {
                        Console.WriteLine("##INVALID CARD NUMBER##");
                    }
               }
            }
         else
            {
            Console.WriteLine("##Incorrect pin##");
            }
            Console.ReadKey();
        }
    }
}
