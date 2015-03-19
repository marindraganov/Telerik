namespace GSM
{
    using System;
    using System.Text;

    public class Battery
    {
        private BatteryType type;

        public Battery(string model, BatteryType type, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.Type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model { get; private set; }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                if (!Enum.IsDefined(typeof(BatteryType), value))
                {
                    throw new ArgumentException("Invalid battery type");
                }
                else
                {
                    this.type = value;
                }
            }
        }

        public double HoursIdle { get; set; }

        public double HoursTalk { get; set; }

        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();
            batteryInfo.AppendLine("type: " + this.Type);
            batteryInfo.AppendLine("time idle: " + this.TimeInHoursAndMinutes(this.HoursIdle));
            batteryInfo.Append("time talk: " + this.TimeInHoursAndMinutes(this.HoursTalk));

            return batteryInfo.ToString();
        }

        private string TimeInHoursAndMinutes(double time)
        {
            int hours = (int)Math.Floor(time);
            int minutes = (int)Math.Floor((time - hours) * 60);

            return string.Format("{0}h {1}min", hours, minutes);
        }
    }
}
