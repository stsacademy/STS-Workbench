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
using System.IO;

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

        public bool Expanded { get; private set; }

        public string TableName { get; private set; }
        public DataType[] KeyTypes { get; private set; }
        public DataType[] RecordTypes { get; private set; }

        public TableComponent(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            TableName = tableName;
            KeyTypes = keyTypes;
            RecordTypes = recordTypes;

            InitializeComponent();

            PrepareSettings();
        }

        private void PrepareSettings()
        {
            Expanded = true;

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
            OnMouseDown(e);
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

        #region Resizing

        public void UserResize(Control owner, int downSidePosition, int rigthSidePosition)
        {
            var ownerCoordinates = owner.PointToClient(Cursor.Position);
            switch (Direction)
            {
                case ResizeDirection.Up:
                    Height = downSidePosition - ownerCoordinates.Y;
                    if (Height > MinimumSize.Height)
                        Top = ownerCoordinates.Y;
                    break;
                case ResizeDirection.Left:
                    Width = rigthSidePosition - ownerCoordinates.X;
                    if (Width > MinimumSize.Width)
                        Left = ownerCoordinates.X;
                    break;
                case ResizeDirection.Rigth:
                    Width = ownerCoordinates.X - Left;
                    break;
                case ResizeDirection.Down:
                    Height = ownerCoordinates.Y - Top;
                    break;
                case ResizeDirection.UpLeft:
                    Height = downSidePosition - ownerCoordinates.Y;
                    if (Height > MinimumSize.Height)
                        Top = owner.PointToClient(Cursor.Position).Y;

                    Width = rigthSidePosition - ownerCoordinates.X;
                    if (Width > MinimumSize.Width)
                        Left = ownerCoordinates.X;
                    break;
                case ResizeDirection.DownLeft:
                    Height = ownerCoordinates.Y - Top;

                    Width = rigthSidePosition - ownerCoordinates.X;
                    if (Width > MinimumSize.Width)
                        Left = ownerCoordinates.X;
                    break;
                case ResizeDirection.DownRigth:
                    Height = ownerCoordinates.Y - Top;

                    Width = ownerCoordinates.X - Left;
                    break;
                case ResizeDirection.UpRigth:
                    Height = downSidePosition - ownerCoordinates.Y;
                    if (Height > MinimumSize.Height)
                        Top = ownerCoordinates.Y;

                    Width = ownerCoordinates.X - Left;
                    break;
                default:
                    break;
            }
        }


        private void pbTop_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.Up);
        }

        private void pbDown_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.Down);
        }

        private void pbLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.Left);
        }

        private void pbRigth_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.Rigth);
        }

        private void pbTopRigth_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.UpRigth);
        }

        private void pbTopLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.UpLeft);
        }

        private void pbBottomLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.DownLeft);
        }

        private void pbBottomRigth_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateResize(ResizeDirection.DownRigth);
        }

        private void ActivateResize(ResizeDirection direction)
        {
            isResizing = true;
            Direction = direction;
        }

        #endregion

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (Expanded)
                Collapse();
            else
                Expand();
        }

        public void Expand()
        {
            if (Expanded)
                return;

            btnHide.BackgroundImage = global::STS.Workbench.Properties.Resources.HideDown;
            AllowResize = true;

            MinimumSize = new Size(150, 120);
            Height = OriginalSize;

            Expanded = true;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        public void Collapse()
        {
            if (!Expanded)
                return;

            btnHide.BackgroundImage = global::STS.Workbench.Properties.Resources.HideLeft;
            AllowResize = false;

            OriginalSize = Height;
            MinimumSize = new Size(150, Height - splitContainer1.Panel2.Height - 4);
            Height = Height - splitContainer1.Panel2.Height - 4;

            Expanded = false;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        public void SerializeMesures(BinaryWriter writer)
        {
            writer.Write(Location.X);
            writer.Write(Location.Y);
            writer.Write(Width);
            writer.Write(Height);
        }

        public static KeyValuePair<Point, Size> DeserializeMesures(BinaryReader reader)
        {
            int X = reader.ReadInt32();
            int Y = reader.ReadInt32();
            int width = reader.ReadInt32();
            int heigth = reader.ReadInt32();

            return new KeyValuePair<Point, Size>(new Point(X, Y), new Size(width, heigth));
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