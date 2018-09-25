using Microsoft.Office.Interop.Excel;
using StaffClockProject.Execution.Model;

namespace StaffClockProject.Execution.ExcelTimeSheet.BuildExcel {

	class ExcelFile {

        // App to use the Excel API
        private Application App;
        // One reference to a workbook
        private Workbook WorkBook;

		// Initialization of the API
		public ExcelFile() {
            this.App = new Application();
        }

        // Building a book for the specific user
        public void BuildBookFor(User usuarioEventos) {

            this.WorkBook = this.App.Workbooks.Add();
            Worksheet sheet = this.WorkBook.Sheets[1];
            sheet.Cells[2, 2] = usuarioEventos.Name + "!";

        }

        public void SaveWorkBookAs(string pathName) {
            this.WorkBook.SaveAs(pathName);
        }

        public void Close() {
            this.WorkBook.Close();
            App.Quit();
        }

    }

}
