namespace _01.SBExtension
{
    using System.Text;

    public static class SBExtensions
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int length)
        {
            StringBuilder subBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                subBuilder.Append(strBuilder[index + i]);
            }

            return subBuilder;
        }
    }
}
