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
    public partial class TableComponent : UserControl, IEquatable<TableComponent>
    {
        private int OriginalSize = 0;

        private bool isResizing = false;

        private List<PictureBox> Resizers = new List<PictureBox>();

        public Color CurrentColor;

        private bool AllowResize { get { return Expanded; } }
        public bool IsResizing { get { return AllowResize && isResizing; } }
        public ResizeDirection Direction { get; private set; }

        public bool Expanded { get; private set; }

        public string TableName { get; private set; }
        public DataType[] KeyTypes { get; private set; }
        public DataType[] RecordTypes { get; private set; }

        public Color BackGroundColor
        {
            get { return splitContainer1.BackColor; }
            set { splitContainer1.BackColor = value; }
        }

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
            CurrentColor = BackColor;

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

            control.MouseEnter += TableComponent_MouseEnter;
            control.MouseLeave += TableComponent_MouseLeave;

            foreach (var item in control.Controls)
                AttachControlsToEvents((Control)item);
        }

        public bool Locked { get; private set; }

        public void Lock()
        {
            Locked = true;
        }

        public void Unlock()
        {
            Locked = false;
        }

        private void control_Click(object sender, EventArgs e)
        {
            if (Locked)
                return;

            OnClick(e);

            if (AllowResize)
                EnableResizers();
            else
                DisableResizers();
        }

        private void control_DoubleClick(object sender, EventArgs e)
        {
            if (Locked)
                return;

            OnDoubleClick(e);
        }

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            if (Locked)
                return;

            isResizing = false;
            Direction = ResizeDirection.None;
            OnMouseUp(e);
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            if (Locked)
                return;

            OnMouseDown(e);
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (Locked)
                return;

            OnMouseMove(e);
        }

        public void EnableResizers()
        {
            if (Locked)
                return;

            if (!Expanded)
                return;

            foreach (var item in Resizers)
                ((PictureBox)item).Visible = true;
        }

        public void DisableResizers()
        {
            if (Locked)
                return;

            foreach (var item in Resizers)
                ((PictureBox)item).Visible = false;
        }

        private void TableComponent2_Resize(object sender, EventArgs e)
        {
            if (Locked)
                return;

            pbRigth.Location = new Point(Width - pbRigth.Size.Width, Height / 2 - pbRigth.Size.Height / 2);
            pbDown.Location = new Point(Width / 2 - pbDown.Size.Width / 2, Height - pbDown.Size.Height);
            pbLeft.Location = new Point(0, Height / 2 - pbLeft.Size.Height / 2);
            pbTop.Location = new Point(Width / 2 - pbDown.Size.Width / 2, 0);

            Refresh();
        }

        #region Resizing

        public void UserResize(Control owner, int downSidePosition, int rigthSidePosition)
        {
            UserResize(owner, downSidePosition, rigthSidePosition, 0, 0);
        }

        public void UserResize(Control owner, int downSidePosition, int rigthSidePosition, int verticalScrollBarValue, int horizontalScrollBarValue)
        {
            if (Locked)
                return;

            var ownerCoordinates = owner.PointToClient(Cursor.Position);

            if (ownerCoordinates.X < 0 || ownerCoordinates.Y < 0)
                return;

            switch (Direction)
            {
                case ResizeDirection.Up:
                    Height = downSidePosition - ownerCoordinates.Y - verticalScrollBarValue;
                    if (Height > MinimumSize.Height)
                        Top = ownerCoordinates.Y + verticalScrollBarValue;
                    break;
                case ResizeDirection.Left:
                    Width = rigthSidePosition - ownerCoordinates.X - horizontalScrollBarValue;
                    if (Width > MinimumSize.Width)
                        Left = ownerCoordinates.X + horizontalScrollBarValue;
                    break;
                case ResizeDirection.Rigth:
                    Width = ownerCoordinates.X - Left + horizontalScrollBarValue;
                    break;
                case ResizeDirection.Down:
                    Height = ownerCoordinates.Y - Top + verticalScrollBarValue;
                    break;
                case ResizeDirection.UpLeft:
                    Height = downSidePosition - ownerCoordinates.Y - verticalScrollBarValue;
                    if (Height > MinimumSize.Height)
                        Top = ownerCoordinates.Y + verticalScrollBarValue;

                    Width = rigthSidePosition - ownerCoordinates.X - horizontalScrollBarValue;
                    if (Width > MinimumSize.Width)
                        Left = ownerCoordinates.X + horizontalScrollBarValue;
                    break;
                case ResizeDirection.DownLeft:
                    Height = ownerCoordinates.Y - Top + verticalScrollBarValue;

                    Width = rigthSidePosition - ownerCoordinates.X - horizontalScrollBarValue;
                    if (Width > MinimumSize.Width)
                        Left = ownerCoordinates.X + horizontalScrollBarValue;
                    break;
                case ResizeDirection.DownRigth:
                    Height = ownerCoordinates.Y - Top + verticalScrollBarValue;

                    Width = ownerCoordinates.X - Left + horizontalScrollBarValue;
                    break;
                case ResizeDirection.UpRigth:
                    Height = downSidePosition - ownerCoordinates.Y - verticalScrollBarValue;
                    if (Height > MinimumSize.Height)
                        Top = ownerCoordinates.Y + verticalScrollBarValue;

                    Width = ownerCoordinates.X - Left + horizontalScrollBarValue;
                    break;
                default:
                    break;
            }

            owner.Refresh();
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
            if (Locked)
                return;

            isResizing = true;
            Direction = direction;
        }

        #endregion

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (Locked)
                return;

            if (Expanded)
                Collapse();
            else
                Expand();
        }

        public void Expand()
        {
            if (Locked || Expanded)
                return;

            btnHide.BackgroundImage = global::STS.Workbench.Properties.Resources.HideDown;

            MinimumSize = new Size(150, 120);
            Height = OriginalSize;

            Expanded = true;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        public void Collapse()
        {
            if (Locked || !Expanded)
                return;

            btnHide.BackgroundImage = global::STS.Workbench.Properties.Resources.HideLeft;

            OriginalSize = Height;
            MinimumSize = new Size(150, Height - splitContainer1.Panel2.Height - 4);
            Height = Height - splitContainer1.Panel2.Height - 4;

            Expanded = false;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void TableComponent_MouseEnter(object sender, EventArgs e)
        {
            if (Locked)
                return;

            CurrentColor = BackColor;
            BackColor = Color.FromArgb(230, 170, 90);
        }

        private void TableComponent_MouseLeave(object sender, EventArgs e)
        {
            BackColor = CurrentColor;
        }

        public void SerializeSettings(BinaryWriter writer)
        {
            TableComponentSettings settings = new TableComponentSettings(TableName, Expanded, Location, Size, BackGroundColor);
            settings.Serialize(writer);
        }

        public static TableComponentSettings DeserializeSettings(BinaryReader reader)
        {
            return TableComponentSettings.Deserialize(reader);
        }

        public void ApplySettings(TableComponentSettings settings)
        {
            if (Locked)
                return;

            if (settings.Expanded)
                Expand();
            else
                Collapse();

            Location = settings.Location;
            Size = settings.Size;
            BackGroundColor = settings.BackgroundColor;
        }

        #region Hided members

        //[Browsable(false)]
        //public AccessibleRole AccessibleRole { get { return AccessibleRole; } set { value = AccessibleRole; } }
        //[Browsable(false)]
        //public string AccessibleDescription { get { return AccessibleDescription; } set { value = AccessibleDescription; } }
        //[Browsable(false)]
        //public string AccessibleName { get { return AccessibleName; } set { value = AccessibleName; } }

        #endregion

        public bool Equals(TableComponent other)
        {
            return this.Name == other.Name;
        }
    }

    public class TableComponentSettings
    {
        public string TableName;
        public bool Expanded;

        public Point Location;
        public Size Size;
        public Color BackgroundColor;

        public TableComponentSettings(string tableName, bool expanded, Point location, Size size, Color backColor)
        {
            TableName = tableName;
            Expanded = expanded;

            Location = location;
            Size = size;
            BackgroundColor = backColor;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(TableName);
            writer.Write(Expanded);

            writer.Write(Location.X);
            writer.Write(Location.Y);

            writer.Write(Size.Width);
            writer.Write(Size.Height);

            writer.Write(BackgroundColor.ToArgb());
        }

        public static TableComponentSettings Deserialize(BinaryReader reader)
        {
            string tableName = reader.ReadString();
            bool expanded = reader.ReadBoolean();
            Point location = new Point(reader.ReadInt32(), reader.ReadInt32());
            Size size = new Size(reader.ReadInt32(), reader.ReadInt32());
            int argb = reader.ReadInt32();

            return new TableComponentSettings(tableName, expanded, location, size, Color.FromArgb(argb));
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