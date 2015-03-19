namespace _07.EventTimer
{
    using System.Threading;
    using System.Threading.Tasks;

    public class Timer
    {      
        public Timer()
        {
            this.InvokesCounter = 0;
        }

        public delegate void Method();

        public int InvokesCounter { get; private set; }

        public Method MethodToExecute { get; set; }

        public void InvokeMethodOnIntervalAsync(int sec, int invokeCount)
        {
            Task.Run(() => this.InvokeMethodOnInterval(sec, invokeCount));    
        }

        private void InvokeMethodOnInterval(int sec, int invokeCount)
        {
            for (int i = 0; i < invokeCount; i++)
            {                
                Thread.Sleep(sec * 1000);
                this.MethodToExecute();
                this.InvokesCounter++;
            }    
        }
    }
}
