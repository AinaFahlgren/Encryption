using Xunit;
using System;
using static System.Console;

namespace Caesar;
public class CaesarChiffer
{
    static void Main()
    {
        WriteLine("Please enter your firstname: ");
        string? myName = ReadLine();

        int shift = 3;
        string encryptedName = EncryptCaesar(myName, shift);

        WriteLine("Encrypted name: " + encryptedName);
        WriteLine("For decrypting your name press 1");


        if (int.TryParse(ReadLine(), out int keyPress) && keyPress == 1)
        {
            Clear();
            string decryptedName = DecryptCaesar(encryptedName, shift);
            WriteLine("Decrypted name: " + decryptedName);
        }
        else
        {
            WriteLine("Exiting the program");
        }
    }

    static string EncryptCaesar(string myName, int shift)
    {
        char[] encryptedCharName = new char[myName.Length];

        for (int i = 0; i < myName.Length; i++)
        {
            char originalCharName = myName[i];

            if (char.IsLetter(originalCharName))
            {
                char shiftChar = (char)(originalCharName + shift);

                if ((char.IsUpper(originalCharName) && shiftChar > 'Z') || (char.IsLower(originalCharName) && shiftChar > 'z'))
                {
                    shiftChar = (char)(shiftChar - 26);
                }

                encryptedCharName[i] = shiftChar;
            }
            else
            {
                encryptedCharName[i] = originalCharName;
            }
        }

        return new string(encryptedCharName);
    }

    static string DecryptCaesar(string myName, int shift)
    {
        return EncryptCaesar(myName, -shift);
    }

    internal string EncryptCaesarChiffer(string myName, int shift)
    {
        throw new NotImplementedException();
    }

    internal string Encrypt_CaesarChiffer(string myName, int shift)
    {
        throw new NotImplementedException();
    }

    internal string Decrypt_CaesarChiffer(string myName, int shift)
    {
        throw new NotImplementedException();
    }
}