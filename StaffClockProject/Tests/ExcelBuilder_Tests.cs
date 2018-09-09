using NUnit.Framework;
using StaffClockProject.ExcelTimeSheet.BuildExcel;

namespace StaffClockProject.Tests {

    [TestFixture]
    public class ExcelBuilderTest {

        [Test]
        public void Must_Build_Empty_Excel() {
			BuildExcel.BuildEmpty();
		}
		
    }

}
