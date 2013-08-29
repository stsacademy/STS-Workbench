using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Helpers
{
    public class StringObjectToIDataTransformer : IDataTransformer<object[]>
    {
        private Func<object[], IData> toIData;
        private Func<IData, object[]> fromIData;

        public DataType[] SlotTypes { get; private set; }
        public Type Type { get; private set; }

        public Expression<Func<object[], IData>> LambdaToIData { get; private set; }
        public Expression<Func<IData, object[]>> LambdaFromIData { get; private set; }
        
        public StringObjectToIDataTransformer(params DataType[] slotTypes)
        {
            bool supported = slotTypes.All(x => x.IsPrimitive);
            if (!supported)
                throw new NotSupportedException("Not all types are primitive.");

            SlotTypes = slotTypes;
            Type = DataTypeUtils.GetDataType(SlotTypes);

            //prepare toIData
            LambdaToIData = CreateToIDataMethod();
            toIData = LambdaToIData.Compile();

            //prepare fromIData
            LambdaFromIData = CreateFromIDataMethod();
            fromIData = LambdaFromIData.Compile();
        }

        private Expression<Func<object[], IData>> CreateToIDataMethod()
        {
            var values = Expression.Parameter(typeof(object[]), "item");

            Expression[] parsedValues = new Expression[SlotTypes.Length];

            for (int i = 0; i < SlotTypes.Length; i++)
            {
                var value = Expression.ArrayAccess(values, Expression.Constant(i, typeof(int)));

                if (SlotTypes[i] == DataType.Boolean)
                    parsedValues[i] = Expression.Call(typeof(Boolean).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Convert(value, typeof(string)));
                else if (SlotTypes[i] == DataType.Byte)
                    parsedValues[i] = Expression.Call(typeof(Byte).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.SByte)
                    parsedValues[i] = Expression.Call(typeof(SByte).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.Char)
                    parsedValues[i] = Expression.Call(typeof(Char).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.Int16)
                    parsedValues[i] = Expression.Call(typeof(Int16).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.Int32)
                    parsedValues[i] = Expression.Call(typeof(Int32).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.Int64)
                    parsedValues[i] = Expression.Call(typeof(Int64).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.UInt16)
                    parsedValues[i] = Expression.Call(typeof(UInt16).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.UInt32)
                    parsedValues[i] = Expression.Call(typeof(UInt32).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.UInt64)
                    parsedValues[i] = Expression.Call(typeof(UInt64).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.Single)
                    parsedValues[i] = Expression.Call(typeof(Single).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.Double)
                    parsedValues[i] = Expression.Call(typeof(Double).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.Decimal)
                    parsedValues[i] = Expression.Call(typeof(Decimal).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.DateTime)
                    parsedValues[i] = Expression.Call(typeof(DateTime).GetMethod("Parse", new Type[] { typeof(string) }), Expression.Call(value, typeof(object).GetMethod("ToString")));
                else if (SlotTypes[i] == DataType.String)
                    parsedValues[i] = Expression.Convert(value, typeof(string));
                else if (SlotTypes[i] == DataType.ByteArray)
                    throw new NotImplementedException();
            }

            var primitiveTypes = SlotTypes.Select(x => x.PrimitiveType).ToArray();

            var body = Expression.New(Type.GetConstructor(primitiveTypes), parsedValues);
            var lambda = Expression.Lambda<Func<object[], IData>>(body, values);

            //IData toIData(object[] item)
            //{
            //    return new Data<int, string, double>(Int32.Parse(item[0]), (string)item[1], (double)item[2]);
            //}

            return lambda;
        }

        private Expression<Func<IData, object[]>> CreateFromIDataMethod()
        {
            var data = Expression.Parameter(typeof(IData), "data");

            var d = Expression.Variable(Type, "d");
            var assign = Expression.Assign(d, Expression.Convert(data, Type));

            Expression[] values = new Expression[SlotTypes.Length];

            for (int i = 0; i < SlotTypes.Length; i++)
            {
                var value = d.Slot(i);
                values[i] = Expression.Convert(value, typeof(object));
            }

            var newArray = Expression.NewArrayInit(typeof(object), values);

            var body = Expression.Block(typeof(object[]), new ParameterExpression[] { d }, assign, newArray);
            var lambda = Expression.Lambda<Func<IData, object[]>>(body, data);

            //object[] fromIData(IData data)
            //{
            //    Data<int, string, double> d = (Data<int, string, double>)data;
            //    return  new object[] { (object)d.Slot0, (object)d.Slot1, (object)d.Slot2 };
            //}            

            return lambda;
        }

        public object[] FromIData(IData data)
        {
            return fromIData(data);
        }

        public IData ToIData(object[] item)
        {
            return toIData(item);
        }
    }
}
