using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace JMS
{
    class ExcelFunctions
    {
        public static void CreateExcelFile()
        {
            ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("Worksheet1");
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx|Excel Workbook|*.xls",
                Title = "Save report",
                AddExtension = true,
                InitialDirectory = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)),
                FileName = "report.xlsx"
            };
            save.ShowDialog();
            if (save.FileName == "")
            {
                MessageBox.Show("No file was selected.");
                return;
            }

            var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];

            List<string[]> headerrow = new List<string[]>()
            {
                new string[] {"Job Name", "Job Address", "Date Created", "Due Date"}
            };

            string headerRange = "A1:" + Char.ConvertFromUtf32(headerrow[0].Length + 64) + "1";
            excelWorksheet.Cells[headerRange].LoadFromArrays(headerrow);

            FileInfo excelFile = new FileInfo(save.FileName);
            excel.SaveAs(excelFile);
        }
    }
}
