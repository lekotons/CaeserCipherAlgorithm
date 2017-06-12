using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonRegister
{
    public class Cryptogram
    {
        public string EncryptText(string plainText, int key)
        {
            var outcome = string.Empty;

            foreach (var character in plainText)
            {
                outcome += Cipher(character, key);
            }

            return outcome;
        }

        public string DecipherText(string cipherText, int key)
        {
            return EncryptText(cipherText, 26 - key);
        }

        public int GenerateRandomKey()
        {
            var rnd = new Random();
            return rnd.Next(1, 9);
        }

        private static char Cipher(char character, int key)
        {
            if (!char.IsLetter(character))
            {
                return character;
            }

            var firstLetter = char.IsUpper(character) ? 'A' : 'a';
            var cipheredChar = (char)((((character + key) - firstLetter) % 26) + firstLetter);

            return cipheredChar;
        }
    }
}
