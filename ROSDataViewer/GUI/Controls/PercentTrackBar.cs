using System.Windows.Forms;
using System;


namespace ROSDataViewer.GUI.Controls
{
  public sealed class PercentTrackBar : TrackBar
  {
    private const int MAX_PERCENT = 100;
    private const int MIN_PERCENT = 1;


    public PercentTrackBar()
    {
      base.Maximum = MAX_PERCENT;
      base.Minimum = MIN_PERCENT;
    }

    public new long Maximum { get; set; }
    public new long Minimum { get; set; }


    public new long Value
    {
      get
      {
        return this.Maximum * base.Value / MAX_PERCENT;
      }

      set
      {
        if (value >= MIN_PERCENT && this.Maximum >= MIN_PERCENT)
        {
          int percent = (int)(value * MAX_PERCENT / this.Maximum);

          if (percent > 0)
          {
            base.Value = percent;
          }
        }
      }
    }
  }
}