using BuilderDesignPatternApp.Models;

namespace BuilderDesignPatternApp.Reports
{
    public class PdfReport : ReportBuilder
    {
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content";
        }
    }
}