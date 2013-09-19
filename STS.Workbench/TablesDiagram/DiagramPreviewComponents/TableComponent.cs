using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STSdb4.Data;
using System.Threading;

namespace STS.Workbench.PreviewComponents
{
    public partial class TableComponent : UserControl
    {
        private int OriginalSize = 0;

        private bool AllowResize = true;
        private bool isResizing = false;

        private List<PictureBox> Resizers = new List<PictureBox>();

        public bool IsResizing { get { return AllowResize && isResizing; } }

        public ResizeDirection Direction { get; private set; }

        public string TableName { get; private set; }
        public DataType[] KeyTypes { get; private set; }
        public DataType[] RecordTypes { get; private set; }

        public TableComponent(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            DoubleBuffered = true;

            TableName = tableName;
            KeyTypes = keyTypes;
            RecordTypes = recordTypes;

            InitializeComponent();

            PrepareSettings();
        }

        private void PrepareSettings()
        {
            lblTableName.Text = TableName;
            Name = TableName;

            Resizers.Add(pbBottomLeft);
            Resizers.Add(pbBottomRigth);
            Resizers.Add(pbTopLeft);
            Resizers.Add(pbTopRigth);
            Resizers.Add(pbTop);
            Resizers.Add(pbLeft);
            Resizers.Add(pbDown);
            Resizers.Add(pbRigth);
            DisableResizers();
            OnResize(new EventArgs());

            treeViewTypes.ImageList = new ImageList();
            treeViewTypes.ImageList.Images.Add("key", new Icon(global::STS.Workbench.Properties.Resources.key, 16, 16));
            treeViewTypes.ImageList.Images.Add("record", new Icon(global::STS.Workbench.Properties.Resources.record, 16, 16));
            treeViewTypes.ImageList.Images.Add("primitiveType", new Icon(global::STS.Workbench.Properties.Resources.empty, 16, 16));
            treeViewTypes.ImageList.Images.Add("userType", new Icon(global::STS.Workbench.Properties.Resources.userType, 16, 16));

            treeViewTypes.Nodes.Add(MakeTypeTree(KeyTypes));
            treeViewTypes.Nodes[0].Text = "Key types";
            treeViewTypes.Nodes[0].ImageKey = "key";
            treeViewTypes.Nodes[0].SelectedImageKey = "key";

            treeViewTypes.Nodes.Add(MakeTypeTree(RecordTypes));
            treeViewTypes.Nodes[1].Text = "Record types";
            treeViewTypes.Nodes[1].ImageKey = "record";
            treeViewTypes.Nodes[1].SelectedImageKey = "record";

            treeViewTypes.ExpandAll();

            foreach (var item in Controls)
                AttachControlsToEvents((Control)item);
        }

        private TreeNode MakeTypeTree(params DataType[] dataTypes)
        {
            TreeNode node = new TreeNode("Slotes");

            for (int i = 0; i < dataTypes.Length; i++)
            {
                if (dataTypes[i].IsPrimitive)
                {
                    TreeNode internalNode = new TreeNode(dataTypes[i].ToString());
                    internalNode.ImageKey = "primitiveType";
                    internalNode.SelectedImageKey = "primitiveType";
                    node.Nodes.Add(internalNode);
                }

                if (dataTypes[i].IsSlotes)
                {
                    foreach (var t in dataTypes[i])
                    {
                        TreeNode internalNode = MakeTypeTree(t);
                        internalNode.ImageKey = "userType";
                        internalNode.SelectedImageKey = "userType";
                        node.Nodes.Add(internalNode);
                    }
                }
            }

            return node;
        }

        private void AttachControlsToEvents(Control control)
        {
            control.Click += control_Click;
            control.DoubleClick += control_DoubleClick;
            control.MouseMove += control_MouseMove;
            control.MouseUp += control_MouseUp;
            control.MouseDown += control_MouseDown;

            foreach (var item in control.Controls)
                AttachControlsToEvents((Control)item);
        }
        
        private void control_Click(object sender, EventArgs e)
        {
            OnClick(e);

            if (AllowResize)
                EnableResizers();
            else
                DisableResizers();
        }

        private void control_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
            Direction = ResizeDirection.None;
            OnMouseUp(e);
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        public void EnableResizers()
        {
            foreach (var item in Resizers)
                ((PictureBox)item).Visible = true;
        }

        public void DisableResizers()
        {
            foreach (var item in Resizers)
                ((PictureBox)item).Visible = false;
        }

        private void TableComponent2_Resize(object sender, EventArgs e)
        {
            pbRigth.Location = new Point(Width - pbRigth.Size.Width, Height / 2 - pbRigth.Size.Height / 2);
            pbDown.Location = new Point(Width / 2 - pbDown.Size.Width / 2, Height - pbDown.Size.Height);
            pbLeft.Location = new Point(0, Height / 2 - pbLeft.Size.Height / 2);
            pbTop.Location = new Point(Width / 2 - pbDown.Size.Width / 2, 0);
        }

        #region Resizers MouseDownEvents

        private void pbBottomRigth_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.DownRigth;
        }

        private void pbTop_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.Up;
        }

        private void pbTopRigth_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.UpRigth;
        }

        private void pbTopLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.UpLeft;
        }

        private void pbLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.Left;
        }

        private void pbBottomLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.DownLeft;
        }

        private void pbDown_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.Down;
        }

        private void pbRigth_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            Direction = ResizeDirection.Rigth;
        }

        #endregion

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
                ShowInfo();
            else
                HideInfo();

            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void ShowInfo()
        {
            btnHide.BackgroundImage = global::STS.Workbench.Properties.Resources.HideDown;
            AllowResize = true;

            MinimumSize = new Size(150, 120);
            Height = OriginalSize;
        }

        private void HideInfo()
        {
            btnHide.BackgroundImage = global::STS.Workbench.Properties.Resources.HideLeft;
            AllowResize = false;

            OriginalSize = Height;
            MinimumSize = new Size(150, Height - splitContainer1.Panel2.Height - 4);
            Height = Height - splitContainer1.Panel2.Height - 4;
        }
    }

    public enum ResizeDirection
    {
        Up,
        Left,
        Rigth,
        Down,

        UpLeft,
        UpRigth,
        DownLeft,
        DownRigth,

        None
    }
}