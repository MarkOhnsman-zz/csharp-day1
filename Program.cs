using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello User, what is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            // Console.WriteLine("Hello " + name + ". It sounds like "+ name + " is "+ age + "years old");
            // Console.WriteLine("Hello {0}. It sounds like {0} is {1} years old.", name, age);
            Console.WriteLine($"Hello {name}. It sounds like {name} is {age} years old.");

            int myNum = 82;
            myNum = myNum * 2;
            myNum *= 2;
            Console.WriteLine(12 % 2);

            bool isAwesome = true;

        }
    }
}
