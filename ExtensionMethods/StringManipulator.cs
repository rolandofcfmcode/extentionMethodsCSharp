using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringManipulator
    {
        public static string CharSplitter(this string stringToSplit, char splitCharacter)
        {
            var stringResult = "";
            foreach (var item in stringToSplit.ToArray())
            {
                stringResult = stringResult + item + splitCharacter;
            }

            return stringResult;
        }
    }
}
