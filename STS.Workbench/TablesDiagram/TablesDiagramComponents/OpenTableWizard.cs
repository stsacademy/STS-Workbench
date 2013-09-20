using STS.Workbench.PreviewComponents;
using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.DiagramPreviewComponents
{
    public partial class OpenTableWizard : Form
    {
        public object Owner { get; private set; }

        public OpenTableWizard()
            : this(null)
        {
        }

        public OpenTableWizard(object owner)
        {
            Owner = owner;

            InitializeComponent();

            grdvTypes.Rows.Add(true, "Int32");
            grdvTypes.Rows.Add(false, "String");
        }

        public string TableName { get { return tbxTableName.Text; } }

        public DataType[] KeyTypes { get; private set; }
        public DataType[] RecordTypes { get; private set; }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            var owner = (TablesDiagramPreview)Owner;

            try
            {
                KeyTypes = GetKeyTypes();
                RecordTypes = GetRecTypes();

                TableComponent t;
                if (owner.Tables.TryGetValue(TableName, out t))
                    throw new Exception("table alredy exist.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnOk.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private DataType[] GetKeyTypes()
        {
            List<DataType> types = new List<DataType>();

            foreach (var item in grdvTypes.Rows)
            {
                var row = (DataGridViewRow)item;

                if ((bool)row.Cells[0].FormattedValue && row.Cells[1].Value != null)
                    types.Add(GetDataType(row.Cells[1].Value.ToString()));

            }

            if (types.Count == 0)
                throw new Exception("Key types must be greater than 0");

            return types.ToArray();
        }

        private DataType[] GetRecTypes()
        {
            List<DataType> types = new List<DataType>();

            foreach (var item in grdvTypes.Rows)
            {
                var row = (DataGridViewRow)item;

                if (!(bool)row.Cells[0].FormattedValue && row.Cells[1].Value != null)
                    types.Add(GetDataType(row.Cells[1].Value.ToString()));

            }

            if (types.Count == 0)
                throw new Exception("Record types must be greater than 0");

            return types.ToArray();
        }

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
    }
}
