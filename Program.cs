using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator studentReport = new StudentReportGenerator();
            studentReport.GenerateReport();

            Console.WriteLine();

            ReportGenerator courseReport = new CourseReportGenerator();
            courseReport.GenerateReport();

            Console.Read();
        }
    }
}
