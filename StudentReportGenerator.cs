using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern
{
    public class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о первашах");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отформатирован отчёт о первашах");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработаны данные о первашах");
        }
    }
}
