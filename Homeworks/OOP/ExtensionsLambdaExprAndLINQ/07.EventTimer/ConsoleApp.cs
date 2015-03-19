namespace _07.EventTimer
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            Console.CursorVisible = false;

            Timer firstTimer = new Timer();
            firstTimer.MethodToExecute = delegate
            {
                // draw progress bar with progress 1 in the second console line
                ConsoleProgressBar(ConsoleColor.Green, 1, 1, firstTimer.InvokesCounter);
            };

            Timer secondTimer = new Timer();
            secondTimer.MethodToExecute = delegate
            {
                Console.Beep(200 + (100 * secondTimer.InvokesCounter), 100); 
            };

            Console.WriteLine("This demo has sound :)");

            // here we start two timers that work independently(asynchronous)
            firstTimer.InvokeMethodOnIntervalAsync(1, 10);
            secondTimer.InvokeMethodOnIntervalAsync(2, 5);

            Console.ReadLine();
        }

        private static void ConsoleProgressBar(ConsoleColor color, int row, int progress, int count)
        {
            for (int i = 0; i < progress; i++)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(i + (progress * count), row);
                Console.Write((char)166);
                Console.ResetColor();
            }
        }
    }
}
