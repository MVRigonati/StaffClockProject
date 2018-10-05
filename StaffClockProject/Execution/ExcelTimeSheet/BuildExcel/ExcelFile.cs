using Microsoft.Office.Interop.Excel;
using StaffClockProject.Execution.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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

        // Building a book of all user's events
        public void BuildBookFor(User userObj) {

            this.WorkBook = this.App.Workbooks.Add();

            List<Event> orderedEvents = userObj.Events.OrderBy( obj => obj.Data ).ToList(); // Retreving the event list ordered by the dates

            int linha = 2, coluna = 3;
            DateTime beingAnalysing = DateTime.MinValue;
            if (orderedEvents.Count > 0) {
                beingAnalysing = orderedEvents[0].Data;
            }
            foreach (var oneEvent in orderedEvents) {

                if(oneEvent.Data.Date != beingAnalysing.Date) {
                    FinishLine();
                    beingAnalysing = oneEvent.Data;
                    linha++;
                    coluna = 3;
                }

                MakeOnLineFor(oneEvent, linha, coluna++);

            }

        }

        public void MakeOnLineFor(Event oneEvent, int linha, int coluna) {

            Worksheet sheet = this.WorkBook.Sheets[1];

            sheet.Cells[linha, 2].EntireColumn.NumberFormat = "dd/mm"; // Setting the cell format
            sheet.Cells[linha, coluna].EntireColumn.NumberFormat = "hh:mm"; // Setting the cell format
            sheet.Cells[linha, coluna] = oneEvent.Data.ToOADate(); // Using the double value for dates


        }

        private void FinishLine() {
            
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
