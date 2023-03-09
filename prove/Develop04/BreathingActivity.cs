using System;
using System.Threading;

namespace Namespace2
{
    public class BreathingActivity : Namespace.MindfulnessActivity
    {
        // override the base class method with our own implementation
        // print some introductory messages
        // wait for 4 seconds
        // instruct the user to take a deep breath in 
        // animate a message instructing the user to hold their breath for 3 seconds
        // instruct the user to exhale slowly
        // calculate the number of cycles needed to reach the given duration
        // each cycle takes 7 seconds



        public override void StartActivity(int duration)
        {
            Console.WriteLine("Breathing Activity: This activity will guide you through a breathing exercise to help you relax and focus.");
            Console.WriteLine("Take a comfortable seat and close your eyes.");
            Pause(4);
            Console.WriteLine("Take a deep breath in through your nose, filling your lungs completely.");
            Animate("Hold your breath for 4 seconds.", 4);
            Console.WriteLine("Slowly exhale through your mouth, emptying your lungs completely.");
            Animate("Pause for 1 second.", 1);
            Console.WriteLine("Repeat this cycle for " + duration + " seconds.");
            int cycles = duration / 7; 

            // loop through the required number of cycles
            // instruct the user to inhale
            // animate a message instructing the user to hold their breath for 3 seconds
            // instruct the user to exhale
            // animate a message instructing the user to pause for 1 second
            // print a message indicating that the activity is complete

            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("Inhale..."); 
                Animate("Hold for 4 seconds...", 4);
                Console.WriteLine("Exhale...");
                Animate("Pause for 1 second...", 1);
            }
            Console.WriteLine("You've completed the breathing exercise. Take a moment to notice how you feel.");
        }
        private new void Pause(int v)
        {
            throw new NotImplementedException();
        }
    }
}