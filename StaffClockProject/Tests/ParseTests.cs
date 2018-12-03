
using NUnit.Framework;
using StaffClockProject.Execution.ExcelTimeSheet.Parse;
using System;

namespace StaffClockProject.Tests {

    [TestFixture]
    public class ParseTests {

        [Test]
        public void Must_Build_An_Event() {

            // Cenario
            DateTime expected = new DateTime(2018, 07, 31, 08, 23, 0);
            string userIdExpected = "021289287025";

            // Execution
            var result = ParseEvent.CreateEvent(
                "00000747833107201808230212892870253007");

            // Tests
            Assert.AreEqual(expected, result.DataEvento,
                "ParseEvent.CreateEvent() function is not parsing the date correctly.");

            Assert.AreEqual(userIdExpected, result.UserID,
                "ParseEvent.CreateEvent() function is not parsing the userID correctly.");

        }

    }
}
