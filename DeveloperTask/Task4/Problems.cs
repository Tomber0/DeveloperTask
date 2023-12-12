using System;
using System.Linq;
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

        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < s.Length/2; i++, j--)
            {
                if (!(s[i] == s[j])) 
                {
                    return false;
                }
            }
            return true;
        }

        public static IEnumerable<int> MissingElements(int[] arr) 
        {
            List<int> seq = new();
            for (int i = arr[0]; i <= arr[arr.Length - 1]; i++)
            {
                seq.Add(i);
            }
            return seq.Except(arr);
        }
    }
}
