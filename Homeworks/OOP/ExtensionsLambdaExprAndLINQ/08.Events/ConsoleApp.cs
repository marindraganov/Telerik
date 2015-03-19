namespace _08.Events
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            Console.CursorVisible = false;

            int progressIntervalSec = 1;
            Timer timer1 = new Timer(progressIntervalSec);
            var progressBar = new ProgressBar(5, ConsoleColor.Green);
            progressBar.Subscribe(timer1);

            int soundIntervalSec = 2;
            Timer timer2 = new Timer(soundIntervalSec);
            var beeper = new Beeper(timer2);
            beeper.Subscribe(timer2);

            Console.WriteLine("This demo has sound!");
            Console.WriteLine("The progress bar increases with {0} blocks on every {0} seconds.", progressIntervalSec);
            Console.WriteLine("The sound beeps on every {0} seconds", soundIntervalSec);
            Console.WriteLine("Press Enter to quit");

            timer1.StartAsync(progressIntervalSec);
            timer2.StartAsync(soundIntervalSec);
            Console.ReadLine();

            progressBar.Unsubscribe(timer1);
            beeper.Unsubscribe(timer2);
        }
    }
}
