using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.Helpers
{
    public class SelectorTool
    {
        private Rectangle lastSelection;

        private Graphics graphics;

        private List<Control> selectedItems = new List<Control>();
        private List<Control> seekedItems = new List<Control>();

        public readonly Control Owner;
        public Pen Pen;

        public SelectorTool(Control owner, Pen pen)
        {
            Owner = owner;
            Pen = pen;

            graphics = Owner.CreateGraphics();
        }

        public List<Control> GetSelectedItems(IEnumerable<Control> items)
        {
            List<Control> list = new List<Control>();
            foreach (var item in items)
            {
                if (item.HasPointInsideRectangle(lastSelection))
                    list.Add(item);
            }

            return list;
        }

        public void ClearLastSelection()
        {
            lastSelection = new Rectangle();
        }

        public void DrawRectangle(Point center, Point offset)
        {
            Owner.Refresh();
            var rect = CalculateRectangle(center, offset);
            graphics.DrawRectangle(Pen, rect);
        }

        public Rectangle CalculateRectangle(Point center, Point offset)
        {
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

            var rect = new Rectangle(x, y, width, heigh);
            lastSelection = rect;

            return rect;
        }
    }
}
