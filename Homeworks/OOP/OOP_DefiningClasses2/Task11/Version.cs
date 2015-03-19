namespace Task11
{
    public class Version : System.Attribute
    {
        private int major;
        private int minor;

        public Version(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
        }
    }
}
