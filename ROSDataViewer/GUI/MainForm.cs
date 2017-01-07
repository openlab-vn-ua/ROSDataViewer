using TextFormatFiles.ExtremeSizes.Core;
using System;
using System.Windows.Forms;


namespace ROSDataViewer.GUI
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }


    private void MainForm_Load(object sender,EventArgs e)
    {
    }


    private void openCsvFile_Click(object sender,EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog()
      {
        Filter = "csv|*.csv"
      };

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        CsvFilesReader = new CsvFileReader(openFileDialog.FileName);

        positionInCsvFilePercentTrackBar.Minimum = CsvFilesReader.BeginPositionOfReading;
        positionInCsvFilePercentTrackBar.Maximum = CsvFilesReader.EndPositionOfReading;

        SetupStatisticsDataGridView();
        
        positionInCsvFilePercentTrackBar.Enabled = true;
        prevDataFromCsvFile.Enabled              = true;
        nextDataFromCsvFile.Enabled              = true;

        ShowData(CsvFilesReader.ReadNext());
      }
    }


    private CsvFileReader CsvFilesReader { get; set; }


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


    private void ShowData(CsvData csvData)
    {
      if (csvData != null)
      {
        if (csvData.Images != null && csvData.Images.Length >= 1)
        {
          mainPictureBox.Image = csvData.Images[0];
        }
        //else
        //{
        //  IGNORE
        //}
      
        SetToStatisticsDataGridView(csvData.Statistics);
      }
      else
      {
        MessageBox.Show("The end of the input stream is reached.");
      }
    }


    private void SetToStatisticsDataGridView(string[] statistics)
    {
      for (int i = 0; i < mainDataGridView.Columns.Count; i++)
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