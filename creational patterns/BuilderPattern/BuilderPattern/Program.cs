using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
        }
    }
    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
    class ExcelReport : ReportBuilder
    {
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
    public class PDFReport : ReportBuilder
    {
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            return reportBuilder.GetReport();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }
    }
}