using ConsoleApp.Services;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataReaderService = new DataReaderService();
            dataReaderService.ImportAndPrintData("data.csv");
        }
    }
}
