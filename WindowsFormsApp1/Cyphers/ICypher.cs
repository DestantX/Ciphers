using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherBase.Services;

namespace CipherBase.Services
{
    internal interface ICypher
    {
        string encode(string text, string key = null);
        string decode(string text, string key = null);
    }
    abstract class Alphabet
    {
        protected string alphabet = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
        public string getAlphabet() => alphabet;
    }
}
