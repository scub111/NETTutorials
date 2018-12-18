using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class EncryptionTest
    {
        [Test]
        public void TestCase()
        {
            Console.WriteLine("Start encryption");

            const string dataProtect = "Super information";
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

            dataProtect.Should().Be(dataResult);

            #endregion

            #region Hash
            var password = "Pa$$word";
            var btPassword = Encoding.ASCII.GetBytes(password);
            var hash = SHA256.Create().ComputeHash(btPassword);
            #endregion

            Console.WriteLine("End encryption");
        }
    }
}
