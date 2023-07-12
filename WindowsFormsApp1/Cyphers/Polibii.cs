using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherBase.Services;

namespace CipherBase.Services
{
    internal class Polibii : Alphabet, ICypher
    {

        private int checkIndexEncode(int index)
        {
            int count = this.alphabet.Length - 1;
            if (index + 6 > count)
            {
                if (index == 28 || index == 29 || index == 30)
                {
                    return Math.Abs(count - (index + 9 - 1));
                }
                return Math.Abs(count - (index + 6 - 1));
            }
            return index + 6;
        }

        private int checkIndexDecode(int index)
        {
            int count = this.alphabet.Length - 1;

            if (index - 6 < 0)
                return Math.Abs(count + (index - 6 + 1));

            return Math.Abs(index - 6);

        }
        public string decode(string text, string key = null)
        {

            string result = "";

            foreach (char c in text)
            {
                if (c == ' ' || c == ',' || c == '.')
                {
                    result += c;
                }
                else
                {
                    result += this.alphabet[checkIndexDecode(this.alphabet.IndexOf(c))];
                }
            }

            return result;
        }

        public string encode(string text, string key = null)
        {
            string result = "";

            foreach (char c in text)
            {
                if (c == ' ' || c == ',' || c == '.')
                {
                    result += c;
                }
                else
                {
                    result += this.alphabet[checkIndexEncode(this.alphabet.IndexOf(c))];
                }
            }

            return result;
        }
    }
}
