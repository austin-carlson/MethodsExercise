using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Survivors, I would like to know a little more about you!");
            Console.WriteLine("First let's start with your name, Nick. What's your full name again?");
            var nicksName = Console.ReadLine();
            Console.WriteLine("Very good Nick. How old are you right now?");
            var nicksAge = Console.ReadLine();
            Console.WriteLine($"Okay, {nicksName} I guess you're already {nicksAge} years old.");

            Console.WriteLine($"Alright {nicksName} how many times have you played our game Survivor?");
            var nicksPlay = Console.ReadLine();  

            Console.WriteLine("And how many of those did you win?");
            var nicksWins = Console.ReadLine();

            Console.WriteLine("Okay that's not too bad. One last question. If I were standing next to you right now, what would you do to me? :p");

            var nicksDirty = Console.ReadLine();    

            Console.WriteLine($"So, let me get this this straight... Your name is {nicksName} and you're already old as shit {nicksAge} years old.");
            Console.WriteLine($"You have only played our game {nicksPlay} times and won it {nicksWins} times, is that correct?");

            var nicksAnswer = Console.ReadLine();   

            Console.WriteLine($"Oooohh{nicksAnswer}. Well, my young lad. Judging by this, '{nicksDirty}', I don't think we can have you back for a third time.");


        }
    }
}
