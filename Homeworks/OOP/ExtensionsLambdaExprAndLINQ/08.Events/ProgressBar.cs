namespace _08.Events
{
    using System;

    internal sealed class ProgressBar
    {
        public ProgressBar(int rowOnConsole, ConsoleColor color)
        {
            this.Row = rowOnConsole;
            this.Color = color;
        }

        public int Row { get; set; }

        public ConsoleColor Color { get; set; }

        public void Subscribe(Timer t)
        {
            t.NewTick += this.Progress;
        }

        public void Unsubscribe(Timer t)
        {
            t.NewTick -= this.Progress;
        }

        private void Progress(object sender, NewTickArgs e)
        {
            this.ConsoleProgressBar(this.Color, this.Row, e.IntervalSec, e.Count);
        }

        private void ConsoleProgressBar(ConsoleColor color, int row, int progress, int count)
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
