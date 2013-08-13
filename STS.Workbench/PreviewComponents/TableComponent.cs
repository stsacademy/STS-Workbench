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

        public string TableName { get; set; }
        public Type[] TableTypes { get; set; }

        public TableComponent(Point cordinates, Size size, string tableName, params DataType[] tableTypes)
        {
            treeTypes = new TreeView();
            treeTypes.Location = new Point(cordinates.X, cordinates.Y);
            treeTypes.Name = "TableTreeTypes_" + tableName;
            treeTypes.Width = size.Width - 20;
            treeTypes.Height = size.Height;
            treeTypes.Dock = DockStyle.Fill;
            treeTypes.Nodes.Add(MakeTypeTree(tableTypes));

            Controls.Add(treeTypes);
            Location = cordinates;
            Name = "TableGruopBox_" + tableName;
            Size = size;
            TabStop = false;
            Text = tableName;
            Padding = new Padding(10, 20, 10, 15);
        }

        public TreeNode MakeTypeTree(params DataType[] dataTypes)
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
