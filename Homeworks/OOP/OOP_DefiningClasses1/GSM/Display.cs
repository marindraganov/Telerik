namespace GSM
{
    using System;
    using System.Text;

    public class Display
    {
        private int xResolution;
        private int yResolution;

        public Display(int xResolution, int yResolution, int numberOfColors)
        {
            this.XResolution = xResolution;
            this.YResolution = yResolution;
            this.NumberOfColors = numberOfColors;
        }

        public int XResolution
        {
            get
            {
                return this.xResolution;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The resolution can not be negative!");
                }
                else
                {
                    this.xResolution = value;
                }
            }
        }

        public int YResolution
        {
            get
            {
                return this.yResolution;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The resolution can not be negative!");
                }
                else
                {
                    this.yResolution = value;
                }
            }
        }

        public int NumberOfColors { get; private set; }

        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();
            displayInfo.AppendLine("resolution: " + this.XResolution + " x " + this.YResolution);
            displayInfo.Append("number of colors: " + this.NumberOfColors);

            return displayInfo.ToString();
        }
    }
}
