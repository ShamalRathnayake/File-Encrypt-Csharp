using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLocker
{
    public class NewProgressBar : ProgressBar
    {
        public NewProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) ;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height ;
            try
            {
                e.Graphics.FillRectangle(Brushes.Red, 2, 0, rec.Width, rec.Height);
            }
            catch (Exception)
            {

            }
            
        }
    }
}