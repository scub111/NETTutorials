using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class FileTest
    {
        [Test]
        public void TestCase()
        {
            var dir = Directory.GetCurrentDirectory();

            const string fileName = "Info.txt";

            File.WriteAllText(fileName, dir);

            var outStr = File.ReadAllText(fileName);

            dir.Should().Be(outStr, "error");

            foreach (var item in Directory.GetFiles(dir))
                Console.WriteLine("{0} - {1}", Path.GetFileName(item), new FileInfo(item).Length);
        }
    }
}
