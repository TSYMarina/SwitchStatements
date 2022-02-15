using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What was your favorite subject in high school?");

            var userInputSubject = (Console.ReadLine());

            switch (userInputSubject.ToLower())
            {
                case "algebra":
                    Console.WriteLine("Algebra! Nice. I can relate! I like Math in general and I am good at it!");
                    break;

                case "english":
                    Console.WriteLine("Great! Say something in English!");
                    break;

                case "science":
                    Console.WriteLine("Nice! Which direction specifically? Biology, Chemistry, Phuysics, anything else?");
                    break;

                case "history":
                    Console.WriteLine("That sounds cool! I have Google for historical, geographical and economical facts and numbers.");
                    break;

                case "pe":
                    Console.WriteLine("Alright.");
                    break;

                default:
                    Console.WriteLine("Oops, sorry my programmer did not think of this one :|  ");
                    break;



            }

        }
    }
}