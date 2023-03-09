using System;
using System.Threading;

namespace Namespace
{
    // This is an abstract class that serves as a base class for all mindfulness activities.
    public abstract class MindfulnessActivity
    {
        // This is a virtual method that should be overridden by derived classes to provide
        // the actual implementation of the activity.
        // It takes a duration parameter which is the duration of the activity in seconds.
        public virtual void StartActivity(int duration)
        {
            // This is a placeholder implementation that throws a NotImplementedException.
            // It is intended to be overridden by derived classes.
            throw new NotImplementedException();
        }

        // This is a helper method that pauses for a specified duration and then starts the activity.
        // It takes a durationInSeconds parameter which is the duration of the pause in seconds.
        // This message is displayed to prepare the user for the activity.
        // This loop displays a countdown from 3 to 1.
        // Pause for 2 second.
        // This message is displayed to signal the start of the activity.
        // This method pauses for the specified duration.
        protected static void Pause(int durationInSeconds)
        {          
            Console.WriteLine("Prepare to begin in:");
            for (int i = 3; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
            Console.WriteLine("Go!");
            Thread.Sleep(durationInSeconds * 1000);
        }

        // This is a helper method that animates a message for a specified duration.
        // It takes a message parameter which is the message to be displayed, and a durationInSeconds parameter
        // which is the duration of the animation in seconds.
        // This loop displays the message for the specified duration.
        // This loop displays the message for the specified duration.
        protected static void Animate(string message, int durationInSeconds)
        {
            for (int i = 0; i < durationInSeconds; i++)
            {
                Console.WriteLine(message);
                Thread.Sleep(1000); 
            }
        }
    }
}