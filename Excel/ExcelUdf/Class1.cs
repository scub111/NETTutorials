using Microsoft.Office.Excel.Server.Udf;

namespace ExcelUdf
{
    [UdfClass]
    public class ExcelUdfClass
    {
        [UdfMethod]
        public static double AddValues(double val1, double val2)
        {
            return val1 + val2;
        }
    }
}
