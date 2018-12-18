using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Ribbon;

namespace HelloExcel
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnHello_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.Application != null)
            {
                var activeWorksheet = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1];

                Worksheet worksheet = Globals.Factory.GetVstoObject(activeWorksheet);

                var cell = worksheet.Range["A1"];
                cell.Value2 = "Hello, Excel";
            }
        }
    }
}
