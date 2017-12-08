using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Drawing;


namespace TxtFiles.ExtremeLengths
{
  public class CsvRbTextParser
  {
    private const string REGEX_ONLY_DIGITS_WITH_DELIMITER = @"[^\d^\,]";

    private const string VALUES_DELIMITER                 = ",";
    private const string COLS_VALUES_IMAGES_DELIMITER     = ",\"";


    public string[] Values { get; set; }
    public Image[]  Images { get; set; }


    public CsvRbTextParser(string csvRbLine)
    {
      string[] valuesAndImages = ParseValuesAndImages(csvRbLine);

      Values = ParseValues(valuesAndImages[0]);

      if (valuesAndImages.Length == 1)
      {
        Images = null;
      }
      else if (valuesAndImages.Length > 1)
      {
        Images = ParseImages(GetImagesAsString(valuesAndImages));
      }
    }


    private static string[] ParseValuesAndImages(string csvRbLine)
    {
      return Regex.Split(csvRbLine,COLS_VALUES_IMAGES_DELIMITER);
    }


    public static string[] ParseValues(string csvRbLine)
    {
      return Regex.Split(csvRbLine,VALUES_DELIMITER);
    }


    public static Image[] ParseImages(string[] csvRbLine)
    {
      if (csvRbLine == null)
      {
        return null;
      }

      Image[] images = new Image[csvRbLine.Length];

      for (int i = 0; i < images.Length; i++)
      {
        images[i] = ParseImage(csvRbLine[i]);
      }

      return images;
    }


    private static Image ParseImage(string frameAsString)
    {
      string[] frameBufferAsString = ParseValues(frameAsString);
      byte[]   frameBuffer         = new byte[frameAsString.Length];

      for (int i = 0; i < frameBufferAsString.Length; i++)
      {
        frameBuffer[i] = byte.Parse(frameBufferAsString[i]);
      }

      using (MemoryStream memoryStream = new MemoryStream(frameBuffer))
      {
        return Image.FromStream(memoryStream);
      }
    }


    private static string[] GetImagesAsString(string[] csvRbLine)
    {
      string[] imagesAsString = new string[csvRbLine.Length - 1];

      for (int i = 1; i < csvRbLine.Length; i++)
      {
        imagesAsString[i - 1] =
          Regex.Replace(csvRbLine[i],REGEX_ONLY_DIGITS_WITH_DELIMITER,String.Empty);
      }

      return imagesAsString;
    }
  }
}