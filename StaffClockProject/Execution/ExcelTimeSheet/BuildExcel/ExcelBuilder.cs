using StaffClockProject.Execution.ExcelTimeSheet.BuildExcel;

namespace StaffClockProject.ExcelTimeSheet.BuildExcel {

    class BuildExcel {

        public static void BuildEmpty() {

			var excel = new ExcelFile();
			excel.GetWorksheet(1).Cells[1, 1] = "celula [1, 1]";
			excel.SaveAs("teste-excel");
			excel.Close();
			
        }

    }

}
