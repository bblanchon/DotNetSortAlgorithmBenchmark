namespace DotNetSortAlgorithmBenchmark
{
    using System.Globalization;
    using System.IO;

    class CsvWriter
    {
        readonly TextWriter text;
        bool needComma;

        public CsvWriter(TextWriter text)
        {
            this.text = text;
        }

        public void Append(double value)
        {
            if (needComma) text.Write(",");

            text.Write(value.ToString(CultureInfo.InvariantCulture));
            needComma = true;
        }

        public void AppendLine()
        {
            text.WriteLine();
            needComma = false;
        }
    }
}
