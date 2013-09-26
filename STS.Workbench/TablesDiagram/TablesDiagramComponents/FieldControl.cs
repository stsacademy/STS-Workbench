﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.DiagramPreviewComponents
{
    public partial class FieldControl : UserControl
    {
        public FieldControl()
        {
            InitializeComponent();

            foreach (var item in Controls)
                AttachChildsToEvent((Control)item);
        }

        #region mainFeild

        private Size DefaultSize = new Size(2048, 1152);
        private int sizeBounds = 0;

        public bool AllowIncrase { get { return sizeBounds < 3; } }
        public bool AllowDecrase { get { return sizeBounds > 0; } }

        public void SetDefaultSize()
        {
            sizeBounds = 0;
            mainField.Size = DefaultSize;
        }

        public void DecraseSizeQuatter()
        {
            if (AllowDecrase)
            {
                sizeBounds--;
                mainField.Size = new Size(mainField.Size.Width - DefaultSize.Width / 4, mainField.Size.Height - DefaultSize.Height / 4);
            }
        }

        public void IncraseSizeQuatter()
        {
            if (AllowIncrase)
            {
                sizeBounds++;
                mainField.Size = new Size(mainField.Size.Width + DefaultSize.Width / 4, mainField.Size.Height + DefaultSize.Height / 4);
            }
        }

        #endregion

        #region events

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void control_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        public void Add(Control control)
        {
            mainField.Controls.Add(control);
        }

        public Point PointToClient(Point p)
        {
            return mainField.PointToClient(p);
        }

        private void AttachChildsToEvent(Control control)
        {
            control.Click += control_Click;
            control.MouseDown += control_MouseDown;
            control.MouseMove += control_MouseMove;
            control.MouseUp += control_MouseUp;

            foreach (var item in control.Controls)
                AttachChildsToEvent((Control)item);
        }

        #endregion

        #region Scroll

        public bool IsScrolledMaxUp()
        {
            return VerticalScroll.Value == 0;
        }

        public bool IsScrolledMaxDown()
        {
            return VerticalScroll.LargeChange == mainField.Bottom;
        }

        public bool IsScrolledMaxRigth()
        {
            return HorizontalScroll.LargeChange == mainField.Right;
        }

        public bool IsScrolledMaxLeft()
        {
            return HorizontalScroll.Value == 0;
        }

        public void ResetScrollBars()
        {
            VerticalScroll.Value = 0;
            HorizontalScroll.Value = 0;
        }

        #endregion
    }

    public enum FiledSize
    {
        _1280x600,
        _1600x900,
        _2048x1152,
        _4096x2160
    }
}
