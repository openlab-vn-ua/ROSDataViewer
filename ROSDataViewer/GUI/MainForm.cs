using TxtFiles.ExtremeLengths;
using System;
using System.Windows.Forms;


namespace ROSDataViewer.GUI
{
  public partial class MainForm : Form
  {
    private CsvRbFileReader CsvFilesReader { get; set; }


    public MainForm()
    {
      InitializeComponent();
    }


    private void openCsvFile_Click(object sender,EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog()
      {
        Filter = "csv|*.csv"
      };

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        CsvFilesReader = new CsvRbFileReader(openFileDialog.FileName);

        positionInCsvFilePercentTrackBar.Minimum = CsvFilesReader.BeginPositionOfReading;
        positionInCsvFilePercentTrackBar.Maximum = CsvFilesReader.EndPositionOfReading;

        SetupStatisticsDataGridView();
        
        positionInCsvFilePercentTrackBar.Enabled = true;
        prevDataFromCsvFile.Enabled              = true;
        nextDataFromCsvFile.Enabled              = true;

        ShowData(CsvFilesReader.ReadNext());
      }
    }


    private void SetupStatisticsDataGridView()
    {
      mainDataGridView.Rows.Clear();
      mainDataGridView.Columns.Clear();

      for (int i = 0; i < CsvFilesReader.Headers.Length - 1; i++)
      {
        mainDataGridView.Columns.Add
        (
          CsvFilesReader.Headers[i] + i,
          CsvFilesReader.Headers[i]
        );
      }

      mainDataGridView.Rows.Add();
    }


    private void ShowData(CsvRbValue csvRbValue)
    {
      if (csvRbValue != null)
      {
        if (csvRbValue.Images != null && csvRbValue.Images.Length >= 1)
        {
          mainPictureBox.Image = csvRbValue.Images[0];
        }
        //else
        //{
        //  IGNORE
        //}
      
        SetToStatisticsDataGridView(csvRbValue.Values);
      }
      else
      {
        MessageBox.Show("The end of the input stream is reached.");
      }
    }


    private void SetToStatisticsDataGridView(string[] statistics)
    {
      int length = Math.Min(statistics.Length,mainDataGridView.Columns.Count);

      for (int i = 0; i < length; i++)
      {
        mainDataGridView[i,0].Value = statistics[i];
      }
    }


    private void nextDataFromCsvFile_Click(object sender,EventArgs e)
    {
      ShowData(CsvFilesReader.ReadNext());
    }


    private void prevDataFromCsvFile_Click(object sender,EventArgs e)
    {
      ShowData(CsvFilesReader.ReadPrev());
    }


    private void positionInCsvFilePercentTrackBar_Scroll(object sender,EventArgs e)
    {
      long position = positionInCsvFilePercentTrackBar.Value;

      ShowData(CsvFilesReader.GoTo(position));
    }
  }
}