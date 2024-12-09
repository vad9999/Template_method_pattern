using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern
{
    public class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны дынные о курсах");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработаны данные о курсах");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отформатирован отчёт о курсах");
        }
    }
}
