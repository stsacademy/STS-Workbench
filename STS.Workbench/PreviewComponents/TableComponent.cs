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
        private TreeView treeTypes;
        private Label lbltableName;

        public string TableName { get; set; }
        public Type[] TableTypes { get; set; }

        public TableComponent(Point cordinates, Size size, string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            InitializeComponents(cordinates, size, tableName, keyTypes, recordTypes);
        }

        private void InitializeComponents(Point cordinates, Size size, string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            //Tree view (table types).
            treeTypes = new TreeView();
            treeTypes.Location = cordinates;
            treeTypes.Name = "TableTreeTypes_" + tableName;
            treeTypes.Width = size.Width;
            treeTypes.Height = size.Height;
            treeTypes.Dock = DockStyle.Fill;
            treeTypes.Margin = new Padding(10, 30, 10, 15);

            //Label (table name).
            lbltableName = new Label();
            lbltableName.Location = cordinates;
            lbltableName.Text = tableName;
            lbltableName.Dock = DockStyle.Top;
            lbltableName.Margin = new Padding(5, 5, 5, 5);

            treeTypes.Nodes.Add(MakeTypeTree(keyTypes));
            treeTypes.Nodes.Add(MakeTypeTree(recordTypes));
            treeTypes.Nodes[0].Text = "Key types";
            treeTypes.Nodes[1].Text = "Record types";

            //Group box.
            Location = cordinates;
            Name = "TableGruopBox_" + tableName;
            Size = size;
            TabStop = false;
            Padding = new Padding(10, 10, 10, 15);

            Controls.Add(treeTypes);
            Controls.Add(lbltableName);
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
