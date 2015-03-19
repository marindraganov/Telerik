namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static string iPone4SInfo = "This is info about IPhone4S and you do not need instance of GSM to access is";

        private decimal price;

        public GSM(string model, string manufacturer)
        {
            this.CallHistory = new List<Call>();
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = this.Owner;
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public static string IPhone4SInfo
        {
            get
            {
                return iPone4SInfo;
            }

            set
            {
                iPone4SInfo = value;
            }
        }

        public List<Call> CallHistory { get; private set; }

        public string Model { get; private set; }

        public string Manufacturer { get; private set; }

        public decimal Price 
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price can not be negative!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> AddCall(DateTime callTime, string phone, int duration)
        {
            Call currCall = new Call(callTime, phone, duration);
            this.CallHistory.Add(currCall);

            return this.CallHistory;
        }

        public void DeleteCall(int position)
        {
            if (this.CallHistory.Count < position)
            {
                return;
            }
            else
            {
                this.CallHistory.RemoveAt(position);
            }
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateCallsPrice(decimal pricePerMin)
        {
            decimal total = 0;

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                total += (this.CallHistory[i].Duration / 60) * pricePerMin;
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder gsmInfo = new StringBuilder();

            gsmInfo.AppendLine("-------------------------");
            gsmInfo.AppendLine("model: " + this.Model);
            gsmInfo.AppendLine("manufacturer: " + this.Manufacturer);
            gsmInfo.AppendLine("price: " + string.Format("{0:0.00} $", this.Price));
            gsmInfo.AppendLine("owner: " + (this.Owner ?? "not info"));
            gsmInfo.AppendLine("DISPLAY:");

            if (this.Display != null)
            {
                gsmInfo.AppendLine(this.Display.ToString());
            }
            else
            {
                gsmInfo.AppendLine("not info for the display");
            }

            gsmInfo.AppendLine("BATTERY:");

            if (this.Battery != null)
            {
                gsmInfo.AppendLine(this.Battery.ToString());
            }
            else
            {
                gsmInfo.AppendLine("not info for the battery");
            }

            gsmInfo.Append("-------------------------");

            return gsmInfo.ToString();
        }
    }
}
