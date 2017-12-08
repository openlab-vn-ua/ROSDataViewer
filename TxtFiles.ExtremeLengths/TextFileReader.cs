using System.Collections.Generic;
using System;
using System.IO;


namespace TxtFiles.ExtremeLengths
{
  public class TextFileReader : IDisposable
  {
    protected StreamReader CsvStreamReader { get; private set; }
    private   Positions    PrevPositions   { get; set; }


    public TextFileReader(string fileName)
    {
      CsvStreamReader = new StreamReader(fileName);
      PrevPositions   = new Positions();
    }


    ~TextFileReader()
    {
      CsvStreamReader.Close();
    }


    public void Dispose()
    {
      CsvStreamReader.Close();

      GC.SuppressFinalize(this);
    }


    public string ReadNextLine()
    {
      PrevPositions.Push(CsvStreamReader.BaseStream.Position);

      return CsvStreamReader.ReadLine();
    }


    public string ReadPrevLine()
    {
      if (PrevPositions.Count == 0)
      {
        return null;
      }

      CsvStreamReader.BaseStream.Position = PrevPositions.Pop();

      AdjustTriggerPositionToBeginningOfLine();

      return CsvStreamReader.ReadLine();
    }


    public string GoToLine(long position)
    {
      CsvStreamReader.BaseStream.Position = position;

      AdjustTriggerPositionToBeginningOfLine();

      return CsvStreamReader.ReadLine();
    }


    /// <summary>
    /// Reads the data and set the trigger at the beginning of the next line.
    /// Can be a situation when you specify the
    /// position trigger is set to the middle or other position in the line.
    /// </summary>
    protected virtual void AdjustTriggerPositionToBeginningOfLine()
    {
      CsvStreamReader.ReadLine();
    }


    public long BeginPositionOfReading
    {
      get
      {
        return 0;
      }
    }


    public long EndPositionOfReading
    {
      get
      {
        return CsvStreamReader.BaseStream.Length;
      }
    }


    public long CurrentPositionOfReading
    {
      get
      {
        return CsvStreamReader.BaseStream.Position;
      }
    }
  }
}