using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Manoj.NewFolder
{
    public class ReadXlData
    {
        [Test]
        public void ReadTheDataFromXl()
        {
            string path = "C:\\Users\\HP\\source\\repos\\Manoj\\TestData\\TestData.xlsx";
            XLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet Sheet = wb.Worksheet("Sheet1");
            string data = Sheet.Row(2).Cell(2).GetValue<string>();
            Console.WriteLine(data);
        }
    }
}
