using System.Drawing;
using System;


namespace CSV.ROSData.Core
{
  public class CsvData
  {
    public CsvData(string[] statistics,Image[] images)
    {
      Statistics = statistics;
      Images     = images;
    }

    public string[] Statistics { get; set; }
    public Image[]  Images     { get; set; }
  }



  public class CsvFileReader : TextFileReader
  {
    public CsvFileReader(string fileName)
      : base(fileName)
    {
      // read first line of file
      string line = CsvStreamReader.ReadLine();
      Headers     = new CsvTextParser(line).ParseStatistics();
    }

    public string[] Headers { get; private set; }


    public CsvData ReadNext()
    {
      return Read(ReadNextLine());
    }

    public CsvData ReadPrev()
    {
      return Read(ReadPrevLine());
    }


    public CsvData GoTo(long position)
    {
      return Read(GoToLine(position));
    }


    protected static CsvData Read(string lineFromCsvFile)
    {
      if (String.IsNullOrEmpty(lineFromCsvFile))
      {
        return null;
      }
      else
      {
        CsvTextParser parser = new CsvTextParser(lineFromCsvFile);

        string[] values = parser.ParseStatistics();
        Image[]  images = parser.ParseImages();

        return new CsvData(values,images);
      }
    }
  }
}