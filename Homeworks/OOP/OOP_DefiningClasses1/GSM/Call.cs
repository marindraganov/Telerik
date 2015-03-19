namespace GSM
{
    using System;

    public class Call
    {
        private int duration;

        public Call(DateTime date, string number, int duration)
        {
            this.CallDate = date;
            this.DialedPhoneNumber = number;
            this.Duration = duration;
        }

        public DateTime CallDate { get; private set; }

        public string DialedPhoneNumber { get; private set; }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Call duration can not be negative");
                }
                else
                {
                    this.duration = value;
                }
            }
        }
    }
}
