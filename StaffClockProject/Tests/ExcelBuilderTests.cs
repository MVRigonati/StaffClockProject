using NUnit.Framework;
using StaffClockProject.ExcelTimeSheet.BuildExcel;
using StaffClockProject.Execution.Model;
using System.Collections.Generic;

namespace StaffClockProject.Tests {

    [TestFixture]
    public class ExcelBuilderTest {
        
        [Test]
        public void Must_Build_Empty_Excel() {

            // Cenario
            var users = new List<User> {
                new User(1234, "Marcus"),
                new User(4321, "Rigonati")
            };

            // Execução
            BuildExcel.BuildExcelFor(users, "testando");

		}
		
    }

}
