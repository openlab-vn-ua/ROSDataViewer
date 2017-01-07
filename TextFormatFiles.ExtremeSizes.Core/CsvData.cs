using System.Drawing;


namespace TextFormatFiles.ExtremeSizes.Core
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
}