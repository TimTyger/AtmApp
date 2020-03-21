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
            

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your height in cm?");
            var height = Console.ReadLine();
            Console.WriteLine("What is your best food?");
            var bestFood = Console.ReadLine();
            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();
            Console.WriteLine("What football club do you support");
            var footBallClub = Console.ReadLine();
            Console.WriteLine("What is your hobby?");
            var hobby = Console.ReadLine();
            Console.WriteLine("What is your complexion?");
            var complexion = Console.ReadLine();

            Arinze a = new Arinze();
            {
                a.age = Int32.Parse(age);
                a.bestFood = bestFood;
                a.complexion = complexion;
                a.footBallClub = footBallClub;
                a.Height = Int32.Parse(height);
                a.Hobby = hobby;
                a.Name = name;
            }

            if (footBallClub == "Manchester United")
            {
                Console.WriteLine($"Welcome {name}, you are {age} years old, {height}cm tall, and {complexion} in complexion. Your best food is {bestFood}, you love {hobby} and you support {footBallClub} football club.");
            }
            else
            {
                Console.Write("ERROR!!!, Stop supporting inferior clubs");
            }

            Console.ReadKey();
        }
    }
}
