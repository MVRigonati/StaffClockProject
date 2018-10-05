using StaffClockProject.Execution.ExcelTimeSheet.BuildExcel;
using StaffClockProject.Execution.Model;
using System.Collections.Generic;

namespace StaffClockProject.ExcelTimeSheet.BuildExcel {

    class BuildExcel {
        
        public static void BuildExcelFor(List<User> usuarios, string pathName) {

            var excel = new ExcelFile();

            foreach (User user in usuarios) {
                excel.BuildBookFor(user);
                excel.SaveWorkBookAs(pathName + "\\" + user.Name);
            }
            
            excel.Close();

        }

    }
}
