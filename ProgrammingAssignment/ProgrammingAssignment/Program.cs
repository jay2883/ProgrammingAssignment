using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidateInputData;

namespace ProgrammingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string doUserWishToContinue = string.Empty;

            do
            {
                doUserWishToContinue = SelectProgramToRun();
            } while (doUserWishToContinue == "yes");

        }


        private static string SelectProgramToRun()
        {
            int[] userInputArrayOfIntegers = null;
            string input = string.Empty;
            string userStringError = string.Empty;

            Console.WriteLine("===============================================");
            Console.WriteLine("Select the program to run by typing 1 or 2 or 3");
            Console.WriteLine("");
            Console.WriteLine("1 : Find the occurrence of character in a string");
            Console.WriteLine("");
            Console.WriteLine("2 : Find the possible substrings of a given string");
            Console.WriteLine("");
            Console.WriteLine("3 : Get the total score from a array of Integers");

            Console.WriteLine("===============================================");
            string programToRun = Console.ReadLine();

            switch (programToRun)
            {
                case "1":

                    Console.WriteLine("Enter the string.");
                    input = Console.ReadLine();
                    userStringError = ValidateUserInput.ValidateInputStringForCharcaterCount(input);

                    while (!string.IsNullOrEmpty(userStringError))
                    {
                        Console.WriteLine(userStringError);
                        input = Console.ReadLine();
                        userStringError = ValidateUserInput.ValidateInputStringForCharcaterCount(input);
                    }

                    GetCharacterCountAndPrint(input);

                    break;

                case "2":

                    Console.WriteLine("Enter the string.");
                    input = Console.ReadLine();

                    userStringError = ValidateUserInput.ValidateInputStringForCharcaterCount(input);

                    while (!string.IsNullOrEmpty(userStringError))
                    {
                        Console.WriteLine(userStringError);
                        input = Console.ReadLine();
                        userStringError = ValidateUserInput.ValidateInputStringForCharcaterCount(input);
                    }

                    GetAllSubstringAndPrint(input);

                    break;

                case "3":

                    Console.WriteLine("Enter the array of integers separated by comma.");
                    input = Console.ReadLine();

                    string userArrayOFIntegersError = ValidateUserInput.ValidateInputStringForTotalScore(input, out userInputArrayOfIntegers);

                    while (!string.IsNullOrEmpty(userArrayOFIntegersError))
                    {
                        Console.WriteLine(userArrayOFIntegersError);
                        input = Console.ReadLine();
                        userArrayOFIntegersError = ValidateUserInput.ValidateInputStringForTotalScore(input, out userInputArrayOfIntegers);
                    } 

                    GetTotalScoreOfIntegersAndPrint(userInputArrayOfIntegers);

                    break;

                default:

                    Console.WriteLine("No program selected to run");

                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Do you want to run another program? yes : no ");
            Console.WriteLine("");

            return Console.ReadLine();
        }

        private static void GetCharacterCountAndPrint(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                Dictionary<char, int> characterOccurence = CharacterOccurrence.FindCharacterOccurrenceInString(userInput.ToCharArray());

                if (characterOccurence.Count != 0)
                {
                    foreach (KeyValuePair<char, int> keyValuePair in characterOccurence)
                    {
                        Console.WriteLine("Count for Char :" + keyValuePair.Key + " is " + keyValuePair.Value.ToString());
                    }
                }
            }
        }


        private static void GetTotalScoreOfIntegersAndPrint(int[] input)
        {
            if (input.Length>0)
            {
                int count = TotalScore.FindTotalScoreinArray(input);

                Console.WriteLine("Score count of array of integers is "+ count.ToString());
            }
        }


        private static void GetAllSubstringAndPrint(string userInput)
        {
            List<string> subStringList = null;

            if (!string.IsNullOrEmpty(userInput))
            {
                subStringList = PossibleSubstrings.GetAllSubstring(userInput);

                if(subStringList.Count() > 0)
                {
                    Console.WriteLine("The possible substring for " + userInput );

                    foreach (string subString in subStringList)
                        Console.WriteLine(subString);
                }
            }
        }
    }
}
