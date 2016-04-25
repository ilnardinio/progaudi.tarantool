using System;

using TarantoolDnx.MsgPack;

namespace tarantool_client.Converters
{
    public class TupleConverter<T1> : IMsgPackConverter<Tuple<T1>>
    {
        public void Write(Tuple<T1> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();

            t1Converter.Write(value.Item1, writer, context);
        }

        public Tuple<T1> Read(IMsgPackReader reader, MsgPackContext context, Func<Tuple<T1>> creator)
        {
            var t1Converter = context.GetConverter<T1>();

            var item1 = t1Converter.Read(reader, context, null);

            return Tuple.Create(item1);
        }
    }

    public class TupleConverter<T1, T2> : IMsgPackConverter<Tuple<T1, T2>>
    {
        public void Write(Tuple<T1, T2> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();

            t1Converter.Write(value.Item1, writer, context);
            t2Converter.Write(value.Item2, writer, context);
        }

        public Tuple<T1, T2> Read(IMsgPackReader reader, MsgPackContext context, Func<Tuple<T1, T2>> creator)
        {
            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();

            var item1 = t1Converter.Read(reader, context, null);
            var item2 = t2Converter.Read(reader, context, null);

            return Tuple.Create(item1, item2);
        }
    }

    public class TupleConverter<T1, T2, T3> : IMsgPackConverter<Tuple<T1, T2, T3>>
    {
        public void Write(Tuple<T1, T2, T3> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();

            t1Converter.Write(value.Item1, writer, context);
            t2Converter.Write(value.Item2, writer, context);
            t3Converter.Write(value.Item3, writer, context);
        }

        public Tuple<T1, T2, T3> Read(IMsgPackReader reader, MsgPackContext context, Func<Tuple<T1, T2, T3>> creator)
        {
            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();

            var item1 = t1Converter.Read(reader, context, null);
            var item2 = t2Converter.Read(reader, context, null);
            var item3 = t3Converter.Read(reader, context, null);

            return Tuple.Create(item1, item2, item3);
        }
    }

    public class TupleConverter<T1, T2, T3, T4> : IMsgPackConverter<Tuple<T1, T2, T3, T4>>
    {
        public void Write(Tuple<T1, T2, T3, T4> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();

            t1Converter.Write(value.Item1, writer, context);
            t2Converter.Write(value.Item2, writer, context);
            t3Converter.Write(value.Item3, writer, context);
            t4Converter.Write(value.Item4, writer, context);
        }

        public Tuple<T1, T2, T3, T4> Read(IMsgPackReader reader, MsgPackContext context, Func<Tuple<T1, T2, T3, T4>> creator)
        {
            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();

            var item1 = t1Converter.Read(reader, context, null);
            var item2 = t2Converter.Read(reader, context, null);
            var item3 = t3Converter.Read(reader, context, null);
            var item4 = t4Converter.Read(reader, context, null);

            return Tuple.Create(item1, item2, item3, item4);
        }
    }

    public class TupleConverter<T1, T2, T3, T4, T5> : IMsgPackConverter<Tuple<T1, T2, T3, T4, T5>>
    {
        public void Write(Tuple<T1, T2, T3, T4, T5> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();

            t1Converter.Write(value.Item1, writer, context);
            t2Converter.Write(value.Item2, writer, context);
            t3Converter.Write(value.Item3, writer, context);
            t4Converter.Write(value.Item4, writer, context);
            t5Converter.Write(value.Item5, writer, context);
        }

        public Tuple<T1, T2, T3, T4, T5> Read(IMsgPackReader reader, MsgPackContext context, Func<Tuple<T1, T2, T3, T4, T5>> creator)
        {
            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();

            var item1 = t1Converter.Read(reader, context, null);
            var item2 = t2Converter.Read(reader, context, null);
            var item3 = t3Converter.Read(reader, context, null);
            var item4 = t4Converter.Read(reader, context, null);
            var item5 = t5Converter.Read(reader, context, null);

            return Tuple.Create(item1, item2, item3, item4, item5);
        }
    }

    public class TupleConverter<T1, T2, T3, T4, T5, T6> : IMsgPackConverter<Tuple<T1, T2, T3, T4, T5, T6>>
    {
        public void Write(Tuple<T1, T2, T3, T4, T5, T6> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();
            var t6Converter = context.GetConverter<T6>();

            t1Converter.Write(value.Item1, writer, context);
            t2Converter.Write(value.Item2, writer, context);
            t3Converter.Write(value.Item3, writer, context);
            t4Converter.Write(value.Item4, writer, context);
            t5Converter.Write(value.Item5, writer, context);
            t6Converter.Write(value.Item6, writer, context);
        }

        public Tuple<T1, T2, T3, T4, T5, T6> Read(
            IMsgPackReader reader,
            MsgPackContext context,
            Func<Tuple<T1, T2, T3, T4, T5, T6>> creator)
        {
            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();
            var t6Converter = context.GetConverter<T6>();

            var item1 = t1Converter.Read(reader, context, null);
            var item2 = t2Converter.Read(reader, context, null);
            var item3 = t3Converter.Read(reader, context, null);
            var item4 = t4Converter.Read(reader, context, null);
            var item5 = t5Converter.Read(reader, context, null);
            var item6 = t6Converter.Read(reader, context, null);

            return Tuple.Create(item1, item2, item3, item4, item5, item6);
        }
    }

    public class TupleConverter<T1, T2, T3, T4, T5, T6, T7> : IMsgPackConverter<Tuple<T1, T2, T3, T4, T5, T6, T7>>
    {
        public void Write(Tuple<T1, T2, T3, T4, T5, T6, T7> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();
            var t6Converter = context.GetConverter<T6>();
            var t7Converter = context.GetConverter<T7>();

            t1Converter.Write(value.Item1, writer, context);
            t2Converter.Write(value.Item2, writer, context);
            t3Converter.Write(value.Item3, writer, context);
            t4Converter.Write(value.Item4, writer, context);
            t5Converter.Write(value.Item5, writer, context);
            t6Converter.Write(value.Item6, writer, context);
            t7Converter.Write(value.Item7, writer, context);
        }

        public Tuple<T1, T2, T3, T4, T5, T6, T7> Read(
            IMsgPackReader reader,
            MsgPackContext context,
            Func<Tuple<T1, T2, T3, T4, T5, T6, T7>> creator)
        {
            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();
            var t6Converter = context.GetConverter<T6>();
            var t7Converter = context.GetConverter<T7>();

            var item1 = t1Converter.Read(reader, context, null);
            var item2 = t2Converter.Read(reader, context, null);
            var item3 = t3Converter.Read(reader, context, null);
            var item4 = t4Converter.Read(reader, context, null);
            var item5 = t5Converter.Read(reader, context, null);
            var item6 = t6Converter.Read(reader, context, null);
            var item7 = t7Converter.Read(reader, context, null);

            return Tuple.Create(item1, item2, item3, item4, item5, item6, item7);
        }
    }

    public class TupleConverter<T1, T2, T3, T4, T5, T6, T7, TRest> : IMsgPackConverter<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>
    {
        public void Write(Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, IMsgPackWriter writer, MsgPackContext context)
        {
            if (value == null)
            {
                context.NullConverter.Write(null, writer, context);
                return;
            }

            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();
            var t6Converter = context.GetConverter<T6>();
            var t7Converter = context.GetConverter<T7>();
            var t8Converter = context.GetConverter<TRest>();

            t1Converter.Write(value.Item1, writer, context);
            t2Converter.Write(value.Item2, writer, context);
            t3Converter.Write(value.Item3, writer, context);
            t4Converter.Write(value.Item4, writer, context);
            t5Converter.Write(value.Item5, writer, context);
            t6Converter.Write(value.Item6, writer, context);
            t7Converter.Write(value.Item7, writer, context);
            t8Converter.Write(value.Rest, writer, context);
        }

        public Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> Read(
            IMsgPackReader reader,
            MsgPackContext context,
            Func<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>> creator)
        {
            var t1Converter = context.GetConverter<T1>();
            var t2Converter = context.GetConverter<T2>();
            var t3Converter = context.GetConverter<T3>();
            var t4Converter = context.GetConverter<T4>();
            var t5Converter = context.GetConverter<T5>();
            var t6Converter = context.GetConverter<T6>();
            var t7Converter = context.GetConverter<T7>();
            var t8Converter = context.GetConverter<TRest>();

            var item1 = t1Converter.Read(reader, context, null);
            var item2 = t2Converter.Read(reader, context, null);
            var item3 = t3Converter.Read(reader, context, null);
            var item4 = t4Converter.Read(reader, context, null);
            var item5 = t5Converter.Read(reader, context, null);
            var item6 = t6Converter.Read(reader, context, null);
            var item7 = t7Converter.Read(reader, context, null);
            var item8 = t8Converter.Read(reader, context, null);

            return new Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>(item1, item2, item3, item4, item5, item6, item7, item8);
        }
    }
}