using System;
using BuilderDesignPatternApp.Models;
using BuilderDesignPatternApp.Reports;

namespace BuilderDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report;
            var reportDirector = new ReportDirector();

            var pdfReport = new PdfReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();

            Console.ReadLine();
        }
    }
}
