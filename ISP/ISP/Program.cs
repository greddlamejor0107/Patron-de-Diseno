using ISP.Class;
using ISP.Interface;
using System;

namespace ISP.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document { Name = "Reporte", Description = "Reporte de personas peleando" };

            IPrint simplePrinter = new SimplePrinter();
            simplePrinter.Print(document);

            IPrint multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print(document);

            IScan scanner = new MultiFunctionPrinter();
            scanner.Scan(document);

        }
    }
}
