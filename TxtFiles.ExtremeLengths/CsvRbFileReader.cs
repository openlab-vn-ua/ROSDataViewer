using System.Drawing;
using System;


namespace TxtFiles.ExtremeLengths
{
  public class CsvRbFileReader : TextFileReader
  {
    public string[] Headers { get; protected set; }


    public CsvRbFileReader(string fileName,bool isReadHeaders = true)
      : base(fileName)
    {
      if (isReadHeaders)
      {
        // read first line of file
        string headersLine = CsvStreamReader.ReadLine();
        Headers            = CsvRbTextParser.ParseValues(headersLine);
      }
    }


    public CsvRbValue ReadNext()
    {
      return OnRead(ReadNextLine());
    }


    public CsvRbValue ReadPrev()
    {
      return OnRead(ReadPrevLine());
    }


    public CsvRbValue GoTo(long position)
    {
      return OnRead(GoToLine(position));
    }


    protected virtual CsvRbValue OnRead(string csvRbLine)
    {
      if (String.IsNullOrEmpty(csvRbLine))
      {
        return null;
      }
      else
      {
        CsvRbTextParser parser = new CsvRbTextParser(csvRbLine);

        return new CsvRbValue(parser.Values,parser.Images);
      }
    }
  }
}