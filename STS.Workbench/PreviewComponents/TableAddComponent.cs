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
    public class TableAddComponent : GroupBox
    {
        private Label lbltableName = new Label();
        private TextBox tbxTableName = new TextBox();

        private TreeView treeViewTypes = new TreeView();

        private Button btnAdd = new Button();
        private Button btnRemove = new Button();

        private ComboBox cbxTypes = new ComboBox();

        public string TableName { get { return tbxTableName.Text; } }
        public DataType[] KeyTypes { get { return GetDataTypes(treeViewTypes.Nodes[0]); } }
        public DataType[] RecordTypes { get { return GetDataTypes(treeViewTypes.Nodes[1]); } }

        public TableAddComponent()
        {
            InitalizeComponents(new Point(0, 0));
        }

        public void ResetFields()
        {
            //table name
            tbxTableName.Text = "table";

            //tree view types
            treeViewTypes.Nodes.Clear();
            treeViewTypes.Nodes.Add("keyTypes", "Key types", "imgKey", "imgKey");
            treeViewTypes.Nodes.Add("recordTypes", "Record types", "imgRecord", "imgRecord");

            treeViewTypes.Nodes[0].Nodes.Add("Int32", "Int32", "imgPrimitiveType", "imgPrimitiveType");
            treeViewTypes.Nodes[1].Nodes.Add("String", "String", "imgPrimitiveType", "imgPrimitiveType");
            treeViewTypes.ExpandAll();
        }

        private void treeViewTypes_AfterSelect(object sender, EventArgs e)
        {
            string imgKey = treeViewTypes.SelectedNode.ImageKey;
            btnAdd.Enabled = imgKey == "imgKey" || imgKey == "imgRecord" || imgKey == "imgUserType";

            btnRemove.Enabled = treeViewTypes.SelectedNode.Level > 0;

            Console.WriteLine(treeViewTypes.SelectedNode.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = cbxTypes.Text;
            string imageKey = type == "Slotes" ? "imgUserType" : "imgPrimitiveType";

            treeViewTypes.SelectedNode.Nodes.Add(type, type, imageKey, imageKey);
            treeViewTypes.SelectedNode.Expand();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            treeViewTypes.Nodes.Remove(treeViewTypes.SelectedNode);
        }

        #region DataTypeUtils

        private DataType GetDataType(string dataType)
        {
            switch (dataType)
            {
                case "Slotes":
                    return DataType.Slotes();
                case "Boolean":
                    return DataType.Boolean;
                case "Char":
                    return DataType.Char;
                case "SByte":
                    return DataType.SByte;
                case "Byte":
                    return DataType.Byte;
                case "Int16":
                    return DataType.Int16;
                case "UInt16":
                    return DataType.UInt16;
                case "Int32":
                    return DataType.Int32;
                case "UInt32":
                    return DataType.UInt32;
                case "Int64":
                    return DataType.Int64;
                case "UInt64":
                    return DataType.UInt64;
                case "Single":
                    return DataType.Single;
                case "Double":
                    return DataType.Double;
                case "Decimal":
                    return DataType.Decimal;
                case "DateTime":
                    return DataType.DateTime;
                case "String":
                    return DataType.String;
                case "ByteArray":
                    return DataType.ByteArray;
                default:
                    throw new NotSupportedException(dataType);
            }
        }

        private DataType[] GetDataTypes(TreeNode node)
        {
            DataType[] dataType = new DataType[node.Nodes.Count];

            int i = 0;
            foreach (var n in node.Nodes)
            {
                string nodeName = ((TreeNode)n).Name;

                if (nodeName == "Slotes")
                    dataType[i] = DataType.Slotes(GetDataTypes((TreeNode)n));
                else
                    dataType[i] = GetDataType(((TreeNode)n).Name);

                i++;
            }

            return dataType;
        }

        #endregion

        private void InitalizeComponents(Point location)
        {
            //Group box
            Location = location;
            Name = "panelPlaceTable";
            Size = new Size(210, 250);
            Padding = new Padding(2);

            //Label table name
            lbltableName.AutoSize = true;
            lbltableName.Location = new Point(location.X + 9, location.Y + 16);
            lbltableName.Name = "lblTableName";
            lbltableName.Size = new Size(66, 13);
            lbltableName.TabIndex = 5;
            lbltableName.Text = "Table name:";

            //TextBox table name
            tbxTableName.Location = new Point(location.X + 78, location.Y + 13);
            tbxTableName.Name = "tbxTableName";
            tbxTableName.Size = new Size(106, 20);
            tbxTableName.TabIndex = 5;
            tbxTableName.Text = "table";

            //Tree view types
            treeViewTypes = new TreeView();
            treeViewTypes.Location = new Point(location.X + 9, location.Y + 39); ;
            treeViewTypes.Size = new Size(175, 133);

            treeViewTypes.ImageList = new ImageList();
            treeViewTypes.ImageList.Images.Add("imgKey", new Icon(global::STS.Workbench.Properties.Resources.key, 16, 16));
            treeViewTypes.ImageList.Images.Add("imgRecord", new Icon(global::STS.Workbench.Properties.Resources.record, 16, 16));
            treeViewTypes.ImageList.Images.Add("imgPrimitiveType", new Icon(global::STS.Workbench.Properties.Resources.empty, 16, 16));
            treeViewTypes.ImageList.Images.Add("imgUserType", new Icon(global::STS.Workbench.Properties.Resources.userType, 16, 16));

            treeViewTypes.Nodes.Add("keyTypes", "Key types", "imgKey", "imgKey");
            treeViewTypes.Nodes.Add("recordTypes", "Record types", "imgRecord", "imgRecord");

            treeViewTypes.Nodes[0].Nodes.Add("Int32", "Int32", "imgPrimitiveType", "imgPrimitiveType");
            treeViewTypes.Nodes[1].Nodes.Add("String", "String", "imgPrimitiveType", "imgPrimitiveType");
            treeViewTypes.ExpandAll();

            treeViewTypes.AfterSelect += treeViewTypes_AfterSelect;

            //Combo box types
            cbxTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypes.FormattingEnabled = true;
            cbxTypes.Location = new Point(location.X + 9, location.Y + 178);
            cbxTypes.Name = "comboBox1";
            cbxTypes.Size = new Size(175, 21);
            cbxTypes.Items.AddRange(new object[] {
            "Slotes",
            "Boolean",
            "Char",
            "SByte",
            "Byte",
            "Int16",
            "UInt16",
            "Int32",
            "UInt32",
            "Int64",
            "UInt64",
            "Single",
            "Double",
            "Decimal",
            "DateTime",
            "String",
            "ByteArray"});
            cbxTypes.Text = "Slotes";

            //Button add
            btnAdd.Location = new Point(location.X + 9, location.Y + 205);
            btnAdd.Name = "btnAddTable";
            btnAdd.Size = new Size(84, 23);
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            //Button remove
            btnRemove.Location = new Point(location.X + 97, location.Y + 205);
            btnRemove.Name = "btnDeleteTable";
            btnRemove.Size = new Size(84, 23);
            btnRemove.Text = "remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Enabled = false;
            btnRemove.Click += btnRemove_Click;

            Controls.Add(lbltableName);
            Controls.Add(tbxTableName);
            Controls.Add(cbxTypes);
            Controls.Add(treeViewTypes);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
        }
    }
}
