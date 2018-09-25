
using NUnit.Framework;
using StaffClockProject.Execution.ExcelTimeSheet.Parse;
using System;
using System.IO;
using System.Windows.Forms;

namespace StaffClockProject.Tests {

    [TestFixture]
    public class LeituraDeArquivoTest {

        [Test]
        public void Must_read_a_txt_file() {

            //string test = "00000747833107201808230212892870253007";

            string test = "00000747833107201808230212892870253007 jjsjsjsjs kklkl";

            var file = new StreamReader(@"C:\Users\Acer\Downloads\arquivo-origem.txt");

            string result = file.ReadLine();
            while (result != null) {
                result = file.ReadLine();
            }

        }

    }

}
