// provides access to the Stopwatch class for measuring elapsed time
// provides access to the Thread class for adding delays
using System.Diagnostics; 
using System.Threading; 
namespace Namespace3
{
    public class ReflectionActivity : Namespace.MindfulnessActivity
    {
        // an array of prompts to randomly select from
        private static readonly string[] Prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // a static Random object for generating random numbers
        // override the StartActivity method to implement the reflection activity
        // print an introduction message to the console
        // animate a spinner to simulate the generation of a prompt
        // randomly select a prompt from the Prompts array
        // print the selected prompt to the console
        // print the reflection duration to the console
        // create a Stopwatch object to measure elapsed time
        // loop until the reflection duration has elapsed
        // pause for 1 second
        // show that reflection activity is done
        private static readonly Random Random = new();
        public override void StartActivity(int duration)
        {
            Console.WriteLine("Reflection Activity: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            AnimateSpinner("Generating prompt", 5);

            string prompt = Prompts[Random.Next(Prompts.Length)];

            Console.WriteLine("Prompt: " + prompt);

            Console.WriteLine($"You have {duration} seconds to reflect on your prompt...");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Time's up!");
        }

        // a helper method to animate a spinner in the console
        // print a dot
        // pause for half a second
        // move to the next line in the console
        private static void AnimateSpinner(string message, int durationInSeconds)
        {
            Console.Write(message);
            for (int i = 0; i < durationInSeconds; i++)
            {
                Console.Write("."); 
                Thread.Sleep(500); 
            }
            Console.WriteLine(); 
        }
    }
}