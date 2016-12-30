using System.Windows.Forms;
using System;


namespace ROSDataViewer
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
 
      Application.Run(new GUI.MainForm());
    }
  }
}