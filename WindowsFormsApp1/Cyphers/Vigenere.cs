using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherBase.Services;

namespace CipherBase.Services
{
    internal class Vigenere : Alphabet, ICypher
    {
        public string decode(string text, string key = null)
        {
            throw new NotImplementedException();
        }

        public string encode(string text, string key = null)
        {
            throw new NotImplementedException();
        }
    }
}
