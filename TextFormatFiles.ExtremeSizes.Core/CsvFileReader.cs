using System.Drawing;
using System;


namespace TextFormatFiles.ExtremeSizes.Core
{
  public class CsvFileReader : TextFileReader
  {
    public CsvFileReader(string fileName,bool isReadHeaders = true)
      : base(fileName)
    {
      if (isReadHeaders)
      {
        // read first line of file
        string line = CsvStreamReader.ReadLine();

        Headers     = new CsvTextParser(line).ParseStatistics();
      }
    }


    public string[] Headers { get; protected set; }


    public CsvData ReadNext()
    {
      return OnRead(ReadNextLine());
    }


    public CsvData ReadPrev()
    {
      return OnRead(ReadPrevLine());
    }


    public CsvData GoTo(long position)
    {
      return OnRead(GoToLine(position));
    }


    protected virtual CsvData OnRead(string lineFromCsvFile)
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