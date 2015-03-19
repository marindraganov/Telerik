namespace _08.Events
{
    using System;

    public class Beeper
    {        
        public Beeper(Timer t)
        {
            t.NewTick += Beep;
        }

        public void Subscribe(Timer t)
        {
            t.NewTick += Beep;
        }

        public void Unsubscribe(Timer t)
        {
            t.NewTick -= Beep;
        }

        private static void Beep(Timer t, NewTickArgs e)
        {
            Console.Beep(200 + (e.Count * 100), 100);
        }
    }
}
