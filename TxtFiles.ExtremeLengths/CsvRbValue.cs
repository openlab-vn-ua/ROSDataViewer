using System.Drawing;


namespace TxtFiles.ExtremeLengths
{
  public class CsvRbValue
  {
    public string[] Values { get; set; }
    public Image[]  Images { get; set; }


    public CsvRbValue(string[] values,Image[] images)
    {
      Values = values;
      Images = images;
    }
  }
}