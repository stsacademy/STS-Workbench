using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.STS_Data_Adapter
{
    class STSParameter : IDataParameter
    {
        #region IDataParameter

        DbType m_dbType = DbType.Object;
        ParameterDirection m_direction = ParameterDirection.Input;
        bool m_fNullable = false;
        string m_sParamName;
        string m_sSourceColumn;
        DataRowVersion m_sourceVersion = DataRowVersion.Current;
        object m_value;

        public STSParameter()
        {
        }

        public STSParameter(string parameterName, DbType type)
        {
            m_sParamName = parameterName;
            m_dbType = type;
        }

        public STSParameter(string parameterName, object value)
        {
            m_sParamName = parameterName;
            Value = value;
            // Setting the value also infers the type.
        }

        public STSParameter(string parameterName, DbType dbType, string sourceColumn)
        {
            m_sParamName = parameterName;
            m_dbType = dbType;
            m_sSourceColumn = sourceColumn;
        }

        public DbType DbType
        {
            get { return m_dbType; }
            set { m_dbType = value; }
        }

        public ParameterDirection Direction
        {
            get { return m_direction; }
            set { m_direction = value; }
        }

        public bool IsNullable
        {
            get { return m_fNullable; }
            set { m_fNullable = value; }
        }

        public string ParameterName
        {
            get { return m_sParamName; }
            set { m_sParamName = value; }
        }

        public string SourceColumn
        {
            get { return m_sSourceColumn; }
            set { m_sSourceColumn = value; }
        }

        public DataRowVersion SourceVersion
        {
            get { return m_sourceVersion; }
            set { m_sourceVersion = value; }
        }

        public object Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
                m_dbType = _inferType(value);
            }
        }

        private DbType _inferType(Object value)
        {
            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Empty:
                    throw new SystemException("Invalid data type");

                case TypeCode.Object:
                    return DbType.Object;

                case TypeCode.DBNull:
                case TypeCode.Char:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    // Throw a SystemException for unsupported data types.
                    throw new SystemException("Invalid data type");

                case TypeCode.Boolean:
                    return DbType.Boolean;

                case TypeCode.Byte:
                    return DbType.Byte;

                case TypeCode.Int16:
                    return DbType.Int16;

                case TypeCode.Int32:
                    return DbType.Int32;

                case TypeCode.Int64:
                    return DbType.Int64;

                case TypeCode.Single:
                    return DbType.Single;

                case TypeCode.Double:
                    return DbType.Double;

                case TypeCode.Decimal:
                    return DbType.Decimal;

                case TypeCode.DateTime:
                    return DbType.DateTime;

                case TypeCode.String:
                    return DbType.String;

                default:
                    throw new SystemException("Value is of unknown data type");
            }
        }

        #endregion
    }
}