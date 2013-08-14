using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.PreviewComponents
{
    public class TableComponent : GroupBox
    {
        private TreeView treeViewTypes;
        private Label lblTableName;

        public string TableName { get; set; }
        public DataType[] KeyTypes { get; set; }
        public DataType[] RecordTypes { get; set; }

        public TableComponent(Point cordinates, Size size, string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            TableName = tableName;
            KeyTypes = keyTypes;
            RecordTypes = recordTypes;

            InitializeComponents(cordinates, size, tableName, keyTypes, recordTypes);
        }

        private void InitializeComponents(Point location, Size size, string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            //Tree view (table types).
            treeViewTypes = new TreeView();
            treeViewTypes.Location = location;
            treeViewTypes.Name = "TableTreeTypes_" + tableName;
            treeViewTypes.Width = size.Width;
            treeViewTypes.Height = size.Height;
            treeViewTypes.Dock = DockStyle.Fill;

            treeViewTypes.ImageList = new ImageList();
            treeViewTypes.ImageList.Images.Add("key", new Icon(global::STS.Workbench.Properties.Resources.key, 16, 16));
            treeViewTypes.ImageList.Images.Add("record", new Icon(global::STS.Workbench.Properties.Resources.record, 16, 16));
            treeViewTypes.ImageList.Images.Add("primitiveType", new Icon(global::STS.Workbench.Properties.Resources.empty, 16, 16));
            treeViewTypes.ImageList.Images.Add("userType", new Icon(global::STS.Workbench.Properties.Resources.userType, 16, 16));

            treeViewTypes.Nodes.Add(MakeTypeTree(keyTypes));
            treeViewTypes.Nodes[0].Text = "Key types";
            treeViewTypes.Nodes[0].ImageKey = "key";
            treeViewTypes.Nodes[0].SelectedImageKey = "key";

            treeViewTypes.Nodes.Add(MakeTypeTree(recordTypes));
            treeViewTypes.Nodes[1].Text = "Record types";
            treeViewTypes.Nodes[1].ImageKey = "record";
            treeViewTypes.Nodes[1].SelectedImageKey = "record";

            treeViewTypes.ExpandAll();

            //Label (table name).
            lblTableName = new Label();
            lblTableName.Location = location;
            lblTableName.Image = new Icon(global::STS.Workbench.Properties.Resources.table, 16, 16).ToBitmap();
            lblTableName.ImageAlign = ContentAlignment.MiddleLeft;
            lblTableName.TextAlign = ContentAlignment.MiddleCenter;
            lblTableName.Text = tableName;
            lblTableName.Font = new Font(lblTableName.Font.FontFamily.Name, 10, FontStyle.Bold);
            lblTableName.Dock = DockStyle.Top;

            //Group box.
            Location = location;
            Name = "TableGruopBox_" + tableName;
            Size = size;
            TabStop = false;
            Padding = new Padding(10, 10, 10, 10);

            Controls.Add(treeViewTypes);
            Controls.Add(lblTableName);
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
    }
}
