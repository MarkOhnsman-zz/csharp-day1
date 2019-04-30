using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Console.WriteLine("Hello User, what is your Name?");
            // string name = Console.ReadLine().ToLower();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            // Console.WriteLine("Hello " + name + ". It sounds like "+ name + " is "+ age + "years old");
            // Console.WriteLine("Hello {0}. It sounds like {0} is {1} years old.", name, age);
            // Console.WriteLine($"Hello {name}. It sounds like {name} is {age} years old.");

            // int myNum = 82;
            // myNum = myNum * 2;
            // myNum *= 2;
            // Console.WriteLine(12 % 2);
            // if (name.ToLower() == "patrick" && age == "30")
            // {
            //     Console.WriteLine("YOU ROCK"); //True 
            // }
            // else if (name.ToLower() == "zach")
            // {
            //     Console.WriteLine("Whazzzup Bossman!!!"); // if line 26 is true
            // }
            // else if (age == "30")
            // {
            //     System.Console.WriteLine("Yo dawg I heard you like TV's");
            // }

            // switch (name)
            // {
            //     case "patrick":
            //         System.Console.WriteLine("you rock!");
            //         break;
            //     case "zach":
            //     case "jake":
            //         System.Console.WriteLine("Yo bossman");
            //         if (name == "jake")
            //         {
            //             System.Console.WriteLine("good luck sleeping");
            //         }
            //         break;
            //     default:
            //         System.Console.WriteLine("I don't know you");
            //         break;
            // }

            int intAge = 0;


            if (Int32.TryParse(age, out intAge))
            {
                if (intAge > 21)
                {
                    System.Console.WriteLine("welcome to the club");
                }
                else
                {
                    System.Console.WriteLine("Go back to school kid");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input");
            }

            System.Console.WriteLine("Goodbye");
        }
    }
}
