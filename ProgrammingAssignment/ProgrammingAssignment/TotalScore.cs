using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment
{
    public static class TotalScore
    {
        internal static int FindTotalScoreinArray(int[] inputArray)
        {
            int count = 0;

            foreach (int point in inputArray)
            {
                count = point == 8 ? count + 5 : (point % 2 == 0 ? count + 1 : count + 3);
            }

            return count;
        }
    }
}
