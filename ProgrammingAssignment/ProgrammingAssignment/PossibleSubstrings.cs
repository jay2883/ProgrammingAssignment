using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment
{
    public static class PossibleSubstrings
    {
        internal static List<string> GetAllSubstring(String userInputString)
        {
            List<string> subStringList = new List<string>();
            int length = userInputString.Length;
            string subString = string.Empty;

            if (!string.IsNullOrEmpty(userInputString))
            {
                for (int i = 0; i < length; i++)
                {
                    //This loop adds the next character every iteration for the substring and then print
                    for (int j = 0; j < length - i; j++)
                    {
                        subString = userInputString.Substring(i, j + 1) + " ";
                        if (!subStringList.Contains(subString))
                            subStringList.Add(subString);
                    }
                }

                return subStringList;
            }
            return null;
        }
     }
}

