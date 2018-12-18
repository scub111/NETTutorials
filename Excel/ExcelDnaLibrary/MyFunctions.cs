using ExcelDna.Integration;

public static class MyFunctions
{
    [ExcelFunction(Description = "My first .NET function")]
    public static string SayHello(string name)
    {
        return "Hello " + name;
    }


    [ExcelFunction(Description = "My second .NET function")]
    public static double AddValue(double value1, double value2)
    {
        return value1 + value2;
    }
}