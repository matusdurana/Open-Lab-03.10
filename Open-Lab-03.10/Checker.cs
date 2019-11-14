using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int result = str.Length - str.Replace(letter.ToString(), "").Length;
            return result;

        }
    }
}
