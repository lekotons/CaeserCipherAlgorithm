using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonRegister
{
    class Program
    {

        public static void Main(string[] args)
        {
            var exit = string.Empty;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Title = "Caeser Cipher - Hackathon Registration Algorithm";


                Console.WriteLine("---------------- Personal Details ----------------");

                Console.Write("Enter name: ");
                var name = Console.ReadLine();

                Console.Write("Enter Email Address: ");
                var email = Console.ReadLine();

                Console.Write("Enter Course Student: ");
                var course = Console.ReadLine();

                var cipherAlgorithm = new Cryptogram();
                var randomizer = new Random();

                var key = cipherAlgorithm.GenerateRandomKey();
                var algorithm = randomizer.Next(0, 2);
                var cipherText = string.Empty;

                if (algorithm == 0)
                {
                    cipherText = cipherAlgorithm.EncryptText(name, key);
                }
                else if (algorithm == 1)
                {
                    cipherText = cipherAlgorithm.EncryptText(email, key);
                }
                else
                {
                    cipherText = cipherAlgorithm.EncryptText(course, key);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n------------------- Caeser Cipher --------------------");
                Console.WriteLine($"CipherText: {cipherText}");
                Console.WriteLine($"Key: {key}");
                Console.WriteLine("------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;

                var success = false;

                do
                {
                    Console.WriteLine("Enter Decrypted Text: ");
                    var decipheredUserInput = Console.ReadLine();

                    var decipheredCorrectText = cipherAlgorithm.DecipherText(cipherText, key);

                    if (decipheredCorrectText == decipheredUserInput.ToString())
                    {
                        success = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Decipher was successful");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------- Caeser Cipher --------------------");
                        Console.WriteLine("Decipher was unsuccessful");
                        Console.WriteLine("------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Beep();
                    }

                } while (success == false);

                Console.WriteLine("Press any key to continue or -999 to exit. . . ");
                Console.WriteLine("© Britehouse Graduate Programme ");
                exit = Console.ReadLine().ToString();

                Console.Clear();
            } while (exit != "-999");

        }


    }



}
