
using NUnit.Framework;
using System.IO;
using System.Windows.Forms;

namespace StaffClockProject.Tests {

    [TestFixture]
    public class LeituraDeArquivoTest {

        [Test]
        public void Must_read_a_txt_file() {

            string result = "";
            foreach (string line in File.ReadAllLines(@"C:\Users\bcf\Downloads\YEAHH.txt")) {
                result += line;
            }

            MessageBox.Show(result);

        }

    }

}
