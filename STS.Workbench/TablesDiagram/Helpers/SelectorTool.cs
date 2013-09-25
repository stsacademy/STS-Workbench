using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.Helpers
{
    public class SelectorTool
    {
        private Graphics g;

        public readonly Control Owner;

        public SelectorTool(Control owner)
        {
            Owner = owner;
            g = owner.CreateGraphics();
        }

        public void DrawRectangle(Pen pen, Point center, Point offset)
        {
            Owner.Refresh();
            var rect = CalculateRectangle(center, offset);
            g.DrawRectangle(pen, rect);
        }

        public Rectangle CalculateRectangle(Point center, Point offset)
        {
            //center = Owner.PointToClient(center);
            //offset = Owner.PointToClient(offset);

            int x = 0;
            int y = 0;
            int width = 0;
            int heigh = 0;

            if (center.X > offset.X)
            {
                x = offset.X;
                width = center.X - offset.X;
            }
            else
            {
                x = center.X;
                width = offset.X - center.X;
            }

            if (center.Y > offset.Y)
            {
                y = offset.Y;
                heigh = center.Y - offset.Y;
            }
            else
            {
                y = center.Y;
                heigh = offset.Y - center.Y;
            }

            return new Rectangle(x, y, width, heigh);
        }
    }
}
