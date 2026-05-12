// ============================================
// Program #199 — TemplateMethod
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Defines a template method for exporting data
// ============================================

using System;

namespace CSharp30Programs.DesignPatterns
{
    abstract class DataExporter
    {
        public void Export()
        {
            Connect();
            var data = FetchData();
            var formatted = FormatData(data);
            Save(formatted);
        }

        protected abstract void Connect();
        protected abstract string FetchData();
        protected abstract string FormatData(string data);
        protected abstract void Save(string formattedData);
    }

    class CsvExporter : DataExporter
    {
        protected override void Connect() => Console.WriteLine("CSV exporter connected.");
        protected override string FetchData() => "name,score\nLina,90";
        protected override string FormatData(string data) => data.ToUpperInvariant();
        protected override void Save(string formattedData) => Console.WriteLine($"Saved CSV:\n{formattedData}");
    }

    class JsonExporter : DataExporter
    {
        protected override void Connect() => Console.WriteLine("JSON exporter connected.");
        protected override string FetchData() => "{\"name\":\"Lina\",\"score\":90}";
        protected override string FormatData(string data) => data;
        protected override void Save(string formattedData) => Console.WriteLine($"Saved JSON: {formattedData}");
    }

    class Program_199_TemplateMethod
    {
        static void Main(string[] args)
        {
            DataExporter csv = new CsvExporter();
            DataExporter json = new JsonExporter();

            csv.Export();
            Console.WriteLine("---");
            json.Export();
        }
    }
}
