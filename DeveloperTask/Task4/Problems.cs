using System.Text;

namespace DeveloperTask.Task4
{
    internal static class Problems
    {
        public static string ReverseString(string stringToReverse) 
        {
            StringBuilder reversedString = new();
            for (int i = stringToReverse.Length - 1; i >= 0 ; i--)
            {
                reversedString.Append(stringToReverse[i]);
            }
            return reversedString.ToString();
        }
    }
}
