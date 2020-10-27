using System;

namespace Switchstatements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var subject = Console.ReadLine(); //evaluate a string

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is mind bending");
                    break;

                case "english":
                     Console.WriteLine("I speak English!");
                    break;

                case "science":
                    Console.WriteLine("Science is interesting");
                    break;

                case "art":
                    Console.WriteLine("Art is a great way to show a creative side");
                    break;

                case "history":
                    Console.WriteLine("History wil show what mistakes the furute will hold");
                    break;
            }

        }
    }
}
