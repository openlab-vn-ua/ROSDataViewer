using System.Collections.Generic;
using System;
using System.IO;


namespace TextFormatFiles.ExtremeSizes.Core
{
  public class TextFileReader : IDisposable
  {
    public TextFileReader(string fileName)
    {
      CsvStreamReader = new StreamReader(fileName);
      PrevPositions   = new Stack<long>();
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


    protected StreamReader CsvStreamReader { get; private set; }
    private   Stack<long>  PrevPositions   { get; set; }


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
    private void AdjustTriggerPositionToBeginningOfLine()
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