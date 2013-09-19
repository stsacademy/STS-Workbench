using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.ServerControls
{
    public class VerticalProgressBar : UserControl
    {
        private int value;

        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                float step = (this.Size.Height) / (float)(MaxValue - MinValue);
                this.value = (int)(step * value);
                DoubleBuffered = true;
                Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;

            graphics.FillRectangle(new SolidBrush(Color.FromArgb(77, 87, 93)), new Rectangle(new System.Drawing.Point(0, 0), new System.Drawing.Size(this.Size.Width - 1, this.Size.Height - 1)));
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 151, 228)), new Rectangle(new Point(1, this.Size.Height - value), new System.Drawing.Size(this.Size.Width - 2, value)));

            float step = (this.Size.Height - 1) / 12;
            for (float i = 0; i < this.Size.Height; i += step)
            {
                graphics.DrawLine(new Pen(Color.FromArgb(88, 97, 105)), 0, i, this.Width, i);
            }

            graphics.DrawRectangle(Pens.Black, new Rectangle(new System.Drawing.Point(0, 0), new System.Drawing.Size(this.Size.Width - 1, this.Size.Height - 1)));
        }

        private void InitializeComponent()
        {
            MinValue = 0;
            MaxValue = 100;
            this.SuspendLayout();
            this.Load += new System.EventHandler(this.Progress_Load);
            this.ResumeLayout(false);
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
