using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateInputData
{
    /// <summary>
    /// Class to validate the user input string
    /// </summary>
    public static class ValidateUserInput
    {
        public static string ValidateInputStringForCharcaterCount(string userInput)
        {
            if (string.IsNullOrEmpty(userInput.Trim()))
                return "Input string cannot be blank. Please retry";

            return string.Empty;
        }

        public static string ValidateInputStringForTotalScore(string userInput, out int[] userInputArrayOfIntegers)
        {
            int[] input = new int[userInput.Length];
            userInputArrayOfIntegers = null;

            if (string.IsNullOrEmpty(userInput.Trim()))
                return "Input string cannot be blank. Please retry";

            char[] userInputString = userInput.ToCharArray();
            int number = 0;

            for (int i=0;i< userInputString.Length; i++)
            {
                bool success = Int32.TryParse(userInputString[i].ToString(), out number);

                if (success)
                {
                    input[i] = number;
                }
                else
                {
                    return "Input string cannot be blank or contain characters. Please retry";
                }
            }

            userInputArrayOfIntegers = input;
            input = null;

            return string.Empty;
        }
    }
}
