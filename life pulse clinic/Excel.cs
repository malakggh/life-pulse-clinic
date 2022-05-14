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
        Workbook wb;
        Worksheet ws;
        public Excel(string path,int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            this.ws = (Worksheet?)wb.Worksheets[Sheet];
        }
        //public string ReadMyCell(int i , int j)
        //{
        //    return ws.Cells[i, j].Value;
        //}
        //public string ReadCell(int i,int j)
        //{
        //    i++;
        //    j++;
        //    if(ws.Cells[i,j] != null)
        //    {
        //        return ws.Cells[i, j].ToString();
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}
    }
}
