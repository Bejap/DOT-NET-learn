using CsvHelper;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using ScottPlot; // Til at arbejde med ScottPlot-grafer
using ScottPlot.WinForms; // Hvis du bruger ScottPlot i WinForms (FormsPlot-kontrol)
using System.Windows.Forms.DataVisualization.Charting;


public class DataRecord
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }
}

var path = "bench-press095203.csv";
using var reader = new StreamReader(path);
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
var records = csv.GetRecords<DataRecord>().ToList();

var averageScore = records.Average(r => r.Score);
var maxAge = records.Max(r => r.Age);
var groupedByName = records.GroupBy(r => r.Name);

chart1.Series.Clear();
chart1.Series.Add("Score");
chart1.Series["Score"].ChartType = SeriesChartType.Column;

foreach (var record in records)
{
    chart1.Series["Score"].Points.AddXY(record.Name, record.Score);
}
