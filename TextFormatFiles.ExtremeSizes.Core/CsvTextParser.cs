using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Drawing;


namespace TextFormatFiles.ExtremeSizes.Core
{
  public class CsvTextParser
  {
    public CsvTextParser(string csvString)
    {
      string[] statisticsAndImagesAsString = Regex.Split(csvString,COLS_VALS_IMAGES_DELIMITER);

      StatisticsAsString = statisticsAndImagesAsString[0];

      if (statisticsAndImagesAsString.Length == 1)
      {
        ImagesAsString = null;
      }
      else if (statisticsAndImagesAsString.Length > 1)
      {
        ImagesAsString = GetImagesAsString(statisticsAndImagesAsString);
      }
    }


    private static string[] GetImagesAsString(string[] csvData)
    {
      string[] imagesAsString = new string[csvData.Length - 1];

      for (int i = 1; i < csvData.Length; i++)
      {
        imagesAsString[i - 1] = Regex.Replace
        (
          csvData[i],
          REGEX_ONLY_DIGITS_WITH_DELIMITER,String.Empty
        );
      }

      return imagesAsString;
    }


    protected const string VALS_DELIMITER                 = ",";
    protected const string COLS_VALS_IMAGES_DELIMITER     = ",\"";
   
    private const string REGEX_ONLY_DIGITS_WITH_DELIMITER = @"[^\d^\,]";


    protected string   StatisticsAsString { get; set; }
    protected string[] ImagesAsString     { get; set; }


    public string[] ParseStatistics()
    {
      return Regex.Split(StatisticsAsString,VALS_DELIMITER);
    }


    public Image[] ParseImages()
    {
      if (ImagesAsString == null)
      {
        return null;
      }

      Image[] images = new Image[ImagesAsString.Length];

      for (int i = 0; i < images.Length; i++)
      {
        images[i] = ParseImage(ImagesAsString[i]);
      }

      return images;
    }


    protected static Image ParseImage(string frameAsString)
    {
      string[] frameBufferAsString = Regex.Split(frameAsString,VALS_DELIMITER);
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
  }
}