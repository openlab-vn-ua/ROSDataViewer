namespace ROSDataViewer.GUI
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
      this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
      this.openCsvFile = new System.Windows.Forms.ToolStripMenuItem();
      this.nextDataFromCsvFile = new System.Windows.Forms.ToolStripMenuItem();
      this.prevDataFromCsvFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mainDataGridView = new System.Windows.Forms.DataGridView();
      this.mainPictureBox = new System.Windows.Forms.PictureBox();
      this.navigationGroupBox = new System.Windows.Forms.GroupBox();
      this.positionInCsvFilePercentTrackBar = new WinForms.Controls.PercentTrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
      this.mainSplitContainer.Panel1.SuspendLayout();
      this.mainSplitContainer.Panel2.SuspendLayout();
      this.mainSplitContainer.SuspendLayout();
      this.mainMenuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
      this.navigationGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.positionInCsvFilePercentTrackBar)).BeginInit();
      this.SuspendLayout();
      // 
      // mainSplitContainer
      // 
      this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.mainSplitContainer.Name = "mainSplitContainer";
      this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // mainSplitContainer.Panel1
      // 
      this.mainSplitContainer.Panel1.Controls.Add(this.mainPictureBox);
      // 
      // mainSplitContainer.Panel2
      // 
      this.mainSplitContainer.Panel2.Controls.Add(this.mainDataGridView);
      this.mainSplitContainer.Size = new System.Drawing.Size(614, 515);
      this.mainSplitContainer.SplitterDistance = 447;
      this.mainSplitContainer.TabIndex = 3;
      // 
      // mainMenuStrip
      // 
      this.mainMenuStrip.AutoSize = false;
      this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
      this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
      this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCsvFile,
            this.prevDataFromCsvFile,
            this.nextDataFromCsvFile});
      this.mainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
      this.mainMenuStrip.Location = new System.Drawing.Point(3, 16);
      this.mainMenuStrip.Name = "mainMenuStrip";
      this.mainMenuStrip.Size = new System.Drawing.Size(208, 27);
      this.mainMenuStrip.TabIndex = 4;
      this.mainMenuStrip.Text = "menu";
      // 
      // openCsvFile
      // 
      this.openCsvFile.BackColor = System.Drawing.Color.Green;
      this.openCsvFile.Name = "openCsvFile";
      this.openCsvFile.Size = new System.Drawing.Size(50, 19);
      this.openCsvFile.Text = "OPEN";
      this.openCsvFile.Click += new System.EventHandler(this.openCsvFile_Click);
      // 
      // nextDataFromCsvFile
      // 
      this.nextDataFromCsvFile.Enabled = false;
      this.nextDataFromCsvFile.Name = "nextDataFromCsvFile";
      this.nextDataFromCsvFile.Size = new System.Drawing.Size(75, 19);
      this.nextDataFromCsvFile.Text = "NEXT >>>";
      this.nextDataFromCsvFile.Click += new System.EventHandler(this.nextDataFromCsvFile_Click);
      // 
      // prevDataFromCsvFile
      // 
      this.prevDataFromCsvFile.Enabled = false;
      this.prevDataFromCsvFile.Name = "prevDataFromCsvFile";
      this.prevDataFromCsvFile.Size = new System.Drawing.Size(73, 19);
      this.prevDataFromCsvFile.Text = "<<< PREV";
      this.prevDataFromCsvFile.Click += new System.EventHandler(this.prevDataFromCsvFile_Click);
      // 
      // mainDataGridView
      // 
      this.mainDataGridView.AllowUserToAddRows = false;
      this.mainDataGridView.AllowUserToDeleteRows = false;
      this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainDataGridView.Location = new System.Drawing.Point(0, 0);
      this.mainDataGridView.Name = "mainDataGridView";
      this.mainDataGridView.ReadOnly = true;
      this.mainDataGridView.Size = new System.Drawing.Size(614, 64);
      this.mainDataGridView.TabIndex = 0;
      // 
      // mainPictureBox
      // 
      this.mainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
      this.mainPictureBox.Name = "mainPictureBox";
      this.mainPictureBox.Size = new System.Drawing.Size(614, 447);
      this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.mainPictureBox.TabIndex = 1;
      this.mainPictureBox.TabStop = false;
      // 
      // navigationGroupBox
      // 
      this.navigationGroupBox.Controls.Add(this.positionInCsvFilePercentTrackBar);
      this.navigationGroupBox.Controls.Add(this.mainMenuStrip);
      this.navigationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.navigationGroupBox.Location = new System.Drawing.Point(0, 515);
      this.navigationGroupBox.Name = "navigationGroupBox";
      this.navigationGroupBox.Size = new System.Drawing.Size(614, 46);
      this.navigationGroupBox.TabIndex = 5;
      this.navigationGroupBox.TabStop = false;
      this.navigationGroupBox.Text = "navigation";
      // 
      // positionInCsvFilePercentTrackBar
      // 
      this.positionInCsvFilePercentTrackBar.AutoSize = false;
      this.positionInCsvFilePercentTrackBar.BackColor = System.Drawing.SystemColors.ControlDark;
      this.positionInCsvFilePercentTrackBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.positionInCsvFilePercentTrackBar.Enabled = false;
      this.positionInCsvFilePercentTrackBar.Location = new System.Drawing.Point(214, 16);
      this.positionInCsvFilePercentTrackBar.Maximum = ((long)(0));
      this.positionInCsvFilePercentTrackBar.Minimum = ((long)(0));
      this.positionInCsvFilePercentTrackBar.Name = "positionInCsvFilePercentTrackBar";
      this.positionInCsvFilePercentTrackBar.Size = new System.Drawing.Size(397, 27);
      this.positionInCsvFilePercentTrackBar.TabIndex = 1;
      this.positionInCsvFilePercentTrackBar.Value = ((long)(0));
      this.positionInCsvFilePercentTrackBar.Scroll += new System.EventHandler(this.positionInCsvFilePercentTrackBar_Scroll);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(614, 561);
      this.Controls.Add(this.mainSplitContainer);
      this.Controls.Add(this.navigationGroupBox);
      this.MainMenuStrip = this.mainMenuStrip;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ROSDataViewer";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.mainSplitContainer.Panel1.ResumeLayout(false);
      this.mainSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
      this.mainSplitContainer.ResumeLayout(false);
      this.mainMenuStrip.ResumeLayout(false);
      this.mainMenuStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
      this.navigationGroupBox.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.positionInCsvFilePercentTrackBar)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer mainSplitContainer;
    private System.Windows.Forms.MenuStrip mainMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem openCsvFile;
    private System.Windows.Forms.ToolStripMenuItem prevDataFromCsvFile;
    private System.Windows.Forms.ToolStripMenuItem nextDataFromCsvFile;
    private WinForms.Controls.PercentTrackBar positionInCsvFilePercentTrackBar;
    private System.Windows.Forms.PictureBox mainPictureBox;
    private System.Windows.Forms.DataGridView mainDataGridView;
    private System.Windows.Forms.GroupBox navigationGroupBox;
  }
}