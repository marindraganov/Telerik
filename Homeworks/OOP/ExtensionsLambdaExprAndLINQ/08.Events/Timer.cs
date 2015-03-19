namespace _08.Events
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Timer
    {
        public Timer(int intervalSec)
        {
            this.IntervalSec = intervalSec;
        }

        public delegate void EventHandler<TEventArgs>(Timer t, TEventArgs e);

        public event EventHandler<NewTickArgs> NewTick;

        public int IntervalSec { get; set; }

        public void Start(int intervalInSeconds)
        {
            int counter = 0;

            while (true)
            {
                System.Threading.Thread.Sleep(intervalInSeconds * 1000);

                if (this.NewTick != null)
                {
                    this.OnNewTick(new NewTickArgs(counter, intervalInSeconds));
                    counter++;
                }
            }
        }

        public void StartAsync(int intervalInSeconds)
        {
            Task.Run(() => this.Start(intervalInSeconds));
        }

        protected virtual void OnNewTick(NewTickArgs e)
        {
            // Copy a reference to the delegate field now into a temporary field for thread safety
            EventHandler<NewTickArgs> temp = Volatile.Read(ref this.NewTick);

            if (temp != null)
            {
                temp(this, e);
            }
        }
    }
}
