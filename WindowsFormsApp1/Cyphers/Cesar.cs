using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherBase.Services;

namespace CipherBase.Services
{
    internal class Cesar : Alphabet, ICypher
    {
        private int checkIndexEncode(int index, int key)
        {
            int count = this.alphabet.Length - 1;

            if (index + key > count)
                return Math.Abs(count - (index + key - 1));

            return index + key;
        }

        private int checkIndexDecode(int index, int key)
        {
            int count = this.alphabet.Length - 1;

            if (index - key < 0)
                return Math.Abs(count + (index - key + 1));

            return Math.Abs(index - key);

        }
        public string decode(string text, string key = null)
        {
            string result = "";
            int keyInt = Convert.ToInt32(((string)key));

            foreach (char c in text)
            {
                if (c == ' ' || c == ',' || c == '.')
                {
                    result += c;
                }
                else
                {
                    result += this.alphabet[checkIndexDecode(this.alphabet.IndexOf(c), keyInt)];
                }
            }

            return result;
        }
        //щось тут написав
        public string encode(string text, string key = null)
        {
            int keyInt = Convert.ToInt32(((string)key));
            string result = "";

            foreach (char c in text)
            {
                if (c == ' ' || c == ',' || c == '.')
                {
                    result += c;
                }
                else
                {
                    int test = checkIndexEncode(this.alphabet.IndexOf(c), keyInt);
                    result += this.alphabet[checkIndexEncode(this.alphabet.IndexOf(c), keyInt)];
                }
            }

            return result;
        }
    }
}
