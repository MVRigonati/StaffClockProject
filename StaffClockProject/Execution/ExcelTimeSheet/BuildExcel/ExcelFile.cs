using Microsoft.Office.Interop.Excel;

namespace StaffClockProject.Execution.ExcelTimeSheet.BuildExcel {

	class ExcelFile {

		// App to use the Excel API
		public Application App { get; set; }
		// One reference to a workbook
		public Workbook WorkBook { get; set; }

		// Initialization of the API and creation of one empty Workbook
		public ExcelFile() {
			this.App = new Application();
			this.WorkBook = App.Workbooks.Add();
		}

		public void AddWorksheet() {
			this.WorkBook.Sheets.Add();
		}

		public Worksheet GetWorksheet(int number) {
			return this.WorkBook.Sheets[number];
		}

		public void SaveAs(string path) {
			this.WorkBook.SaveAs(path);
		}

		public void Close() {
			this.WorkBook.Close();
			App.Quit();
		}

    }

}
