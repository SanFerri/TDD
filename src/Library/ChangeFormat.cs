using System;
namespace Library
{
    public class ChangeFormat
    {
        public static string ChangeTheFormat(string year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }
    }
}   