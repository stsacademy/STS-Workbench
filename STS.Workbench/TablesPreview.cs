﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STS.Workbench.PreviewComponents;
using STSdb4.Data;

namespace STS.Workbench
{
    public partial class TablesPreview : UserControl
    {
        private Dictionary<int, TableComponent> tables = new Dictionary<int, TableComponent>();
        private TableAddComponent tableAddComponent = new TableAddComponent(new Point(3, 30));

        public TablesPreview()
        {
            InitializeComponent();
            tableAddComponent.Hide();
        }

        #region TableVisualization

        private Point MousePoint = new Point();
        private bool IsMoving = false;
        private bool IsPlacing = false;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MousePoint = e.Location;
                IsMoving = true;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            IsMoving = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (IsMoving && e.Button == MouseButtons.Left)
            {
                Control control = (Control)sender;
                control.Left += e.X - MousePoint.X;
                control.Top += e.Y - MousePoint.Y;
            }
        }

        private void TablesPreview_Click(object sender, EventArgs e)
        {
            if (IsPlacing)
            {
                Size size = new Size(160, 200);
                DataType[] keyType = new DataType[] { DataType.Slotes(DataType.Int32), DataType.Int32 };
                DataType[] recType = new DataType[] { DataType.Int32, DataType.String };

                TableComponent table = new TableComponent(PointToClient(MousePosition), size, tableAddComponent.TableName, tableAddComponent.KeyTypes, tableAddComponent.RecordTypes);
                table.MouseDown += OnMouseDown;
                table.MouseUp += OnMouseUp;
                table.MouseMove += OnMouseMove;

                Controls.Add(table);

                IsPlacing = false;

                tableAddComponent.Hide();
                tableAddComponent.Dispose();
            }
        }

        #endregion

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            IsPlacing = true;

            tableAddComponent = new TableAddComponent(new Point(3, 30));
            Controls.Add(tableAddComponent);
        }
    }
}
