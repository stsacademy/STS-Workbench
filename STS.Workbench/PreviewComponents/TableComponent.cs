using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private PictureBox pBoxIcon;

        public string TableName { get; set; }
        public Type[] TableTypes { get; set; }

        public TableComponent(Point cordinates, Size size, string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
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

            treeViewTypes.Nodes.Add(MakeTypeTree(keyTypes));
            treeViewTypes.Nodes.Add(MakeTypeTree(recordTypes));
            treeViewTypes.Nodes[0].Text = "Key types";
            treeViewTypes.Nodes[1].Text = "Record types";
            treeViewTypes.ExpandAll();

            //Label (table name).
            lblTableName = new Label();
            lblTableName.Location = location;
            lblTableName.Text = tableName;
            lblTableName.Dock = DockStyle.Top;

            //Picture box (icon)
            Icon icon = new Icon(@"TABLE.ICO.ico");
            pBoxIcon.Image = global::STS.Workbench.Properties.Resources.TABLE_ICO;
            pBoxIcon.Location = location;
            pBoxIcon.Name = "pictureBoxIcon" + tableName;
            pBoxIcon.Size = new System.Drawing.Size(32, 32);
            pBoxIcon.TabIndex = 3;

            //Group box.
            Location = location;
            Name = "TableGruopBox_" + tableName;
            Size = size;
            TabStop = false;
            Padding = new Padding(10, 10, 10, 15);

            Controls.Add(treeViewTypes);
            Controls.Add(lblTableName);
        }

        private TreeNode MakeTypeTree(params DataType[] dataTypes)
        {
            TreeNode node = new TreeNode("Slotes");

            for (int i = 0; i < dataTypes.Length; i++)
            {
                if (dataTypes[i].IsPrimitive)
                    node.Nodes.Add(dataTypes[i].ToString());

                if (dataTypes[i].IsSlotes)
                {
                    foreach (var t in dataTypes[i])
                        node.Nodes.Add(MakeTypeTree(t));
                }
            }

            return node;
        }
    }
}
