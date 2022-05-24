using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace life_pulse_clinic
{
    class Excel
    {
        string path = "";
        _Excel.Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;
        _Excel.Range range;
        public Excel(string path,int sheet)
        {
            try
            {
                this.path = path;
                workbook = excel.Workbooks.Open(path);
                worksheet = workbook.Worksheets[sheet];
                range = worksheet.UsedRange;
            }
            catch (Exception)
            {
                throw new Exception("Error Occured While Opening File\n");
            }
        }
        public static _Excel.Application MakeNewExcel(string path)
        {
            _Excel.Application excel1 = new _Excel.Application();
            Workbook workbook1 = excel1.Workbooks.Add(Type.Missing);
            workbook1.SaveCopyAs(path);
            return excel1;
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (worksheet.Cells[i, j].Value2 != null)
            {
                return worksheet.Cells[i, j].Value2.ToString();
            }
            else
            {
                return "";
            }
        }
        public void WriteLastRow(string username,string password,string id)
        {
            int index = 1;
            while (ReadCell(index-1,0)!="")
            {
                index++;
            }
            worksheet.Cells[index, 1] = username;
            worksheet.Cells[index, 2] = password;
            worksheet.Cells[index, 3] = id;
            excel.Visible = false;
            excel.UserControl = false;
            workbook.Save();
        }
        public void WriteCell(int i, int j,string value)
        {
            i++;
            j++;
            excel.Visible = false;
            excel.UserControl = false;
            worksheet.Cells[i, j] = value;
        }
        public void SaveWork()
        {
            workbook.Save();
        }
        public void closeXl()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(range);
            Marshal.FinalReleaseComObject(worksheet);
            workbook.Close();
            Marshal.FinalReleaseComObject(workbook);
            excel.Quit();
            Marshal.FinalReleaseComObject(excel);
        }
    }
}
