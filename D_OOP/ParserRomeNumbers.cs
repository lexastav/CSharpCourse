using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{

    class ParserRomeNumbers
    {
        private static Dictionary<char, int> map = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        public static int Parse(string romeNumb)
        {
            int result = 0;
            for (int i = 0; i < romeNumb.Length; i++)
            {
                if (i + 1 < romeNumb.Length && IsSubtractive(romeNumb[i], romeNumb[i + 1]))
                {
                    result -= map[romeNumb[i]];
                }
                else
                {
                    result += map[romeNumb[i]];
                }
            }
            return result;
        }

        private static bool IsSubtractive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
}
