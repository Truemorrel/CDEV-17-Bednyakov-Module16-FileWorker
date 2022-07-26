using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileWorker.Tests
{
    [TestClass]
    public class FileWorkerTests
    {
        [TestMethod]
        public void FileNameMustConsistOfCorrectChars()
        {
            string incorrect = @"couple'`/#?words$%,./*/+with,./1234?><=""delimeters";
            string expected = @"couple'`_#_words$%,.___+with,._1234___=_delimeters";
            var fileWorker = new FileWorker();

            PrivateObject privateObject = new PrivateObject(fileWorker);
            Assert.AreEqual(expected, privateObject.Invoke("GetSafeFilename", incorrect));
        }
    }
}
