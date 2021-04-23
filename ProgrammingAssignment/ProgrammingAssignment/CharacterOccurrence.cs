using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment
{
    public static class CharacterOccurrence
    {
        internal static Dictionary<char, int> FindCharacterOccurrenceInString(char[] inputString)
        {
            Dictionary<char, int> characterOccurence = new Dictionary<char, int>();

            if(inputString.Length >0)
            {
                foreach (char c in inputString)
                {

                    if (!characterOccurence.ContainsKey(c))
                    {
                        characterOccurence.Add(c, 1);
                    }
                    else
                    {
                        characterOccurence[c]++;
                    }

                }
            }
            return characterOccurence;
        }
    }
}
