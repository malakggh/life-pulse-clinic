using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Excel(string path,int sheet)
        {
            this.path = path;
            workbook = excel.Workbooks.Open(path);
            worksheet = workbook.Worksheets[sheet];
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (worksheet.Cells[i, j].Value2 != null)
            {
                return worksheet.Cells[i, j].Value2;
            }
            else
            {
                return "";
            }
        }
    }
}
