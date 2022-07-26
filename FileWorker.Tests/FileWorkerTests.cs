using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;

namespace FileWorker.Tests
{
    [TestFixture]
    public class FileWorkerTests
    {
        [Test]
        public void FileNameMustConsistOfCorrectChars()
        {
            string incorrect = @"couple'`/#?words$%,./*/+with,./1234?><=""delimeters";
            string expected = @"couple'`_#_words$%,.___+with,._1234___=_delimeters";
            var fileWorker = new FileWorker();

            PrivateObject privateObject = new PrivateObject(fileWorker);
            NUnit.Framework.Assert.AreEqual(expected, privateObject.Invoke("GetSafeFilename", incorrect));
        }
    }
}
