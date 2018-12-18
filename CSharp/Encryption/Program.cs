using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

#warning some warning

//#error some error

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start encryption");

            var dataProtect = "Super information";
            var dataProtectAsArray = Encoding.Unicode.GetBytes(dataProtect);


            #region File.Encrypt
            var fileName = "Text.txt";
            File.WriteAllText(fileName, dataProtect);
            File.Encrypt(fileName);
            #endregion

            #region Windows Data Protection

            var btEncryptedData = ProtectedData.Protect(dataProtectAsArray, null, DataProtectionScope.CurrentUser);

            var btUnEncryptedData = ProtectedData.Unprotect(btEncryptedData, null, DataProtectionScope.CurrentUser);

            var dataResult = Encoding.Unicode.GetString(btUnEncryptedData);

            Debug.Assert(dataProtect.Equals(dataResult), "Strings not equal");
            #endregion


            #region Hashing

            var password = "Pa$$word";

            var btPassword = Encoding.ASCII.GetBytes(password);

#if false

            byte[] hash = SHA256.Create().ComputeHash(btPassword);
#endif

#endregion

#if false

#elif true
            Console.Read();
#endif
        }
    }
}
