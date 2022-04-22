using System.Net;
using System.Reflection.Metadata.Ecma335;
using System;
using NUnit.Framework;
using DateFormat;


namespace Tests
{
[TestFixture]
    public class DateTests
    {

        [Test]
        public void ChangeFormatTest()
        {
            //Cambiar orden de la fecha
            const string expected = "18-01-1995";
            string date = Program.ChangeFormat("18/01/1995");
            Assert.AreEqual(expected,date);
        }

        [Test]
        public void ReverseDateTest()
        {
            //cambiar / por -
            const string expected = "1995-01-18";
            string date = Program.ReverseDate("18/01/1995");
            Assert.AreEqual(expected,date);
        }
    }
}