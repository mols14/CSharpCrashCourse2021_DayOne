using System;
using System.Linq;

namespace CrashCourse2021ExercisesDayOne.Utils
{
    internal class StringUtil
    {
        internal int LengthOfString(string stringToMeasure)
        {
            if (stringToMeasure == null)
            {
                throw new NullReferenceException(Constants.StringCannotBeNull);
            }

            return stringToMeasure.Length;
        }

        internal string SumStrings(string value1, string value2)
        {
            var sum = Int32.Parse(value1) + Int32.Parse(value2);
            return sum.ToString();
        }

        internal string DivideString(string value1, string value2)
        {
            var quotient = Int32.Parse(value1)/Int32.Parse(value2);
            return quotient.ToString();
        }

        internal string StringContains(string value1, string value2)
        {
            if (value1.Contains(value2))
            {
                return "YES";
            }

            return "NO";
        }

        internal string StringToUpperCase(string value1)
        {
            return value1.ToUpper();
        }

        internal string AdditionFromPlusString(string inputString)
        {
            
            int sum = inputString.Split('+').Sum(x => int.Parse(x));

            return sum.ToString();
            

        }

        internal string EvenNumber(int numbertoTest)
        {
            if (numbertoTest % 2 == 0)
            {
                return "EVEN";
            }

            return "ODD";
        }
    }
}