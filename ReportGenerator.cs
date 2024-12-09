using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }

        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();
        private void ExportReport()
        {
            Console.WriteLine("Отчёт экспортирован в файл");
        }
    }
}
