﻿using System;

using ProGaudi.MsgPack.Light;

using ProGaudi.Tarantool.Client.Model;
using ProGaudi.Tarantool.Client.Model.Enums;

namespace ProGaudi.Tarantool.Client.Converters
{
    public class SpaceFieldConverter:IMsgPackConverter<SpaceField>
    {
        private IMsgPackConverter<string> _stringConverter;
        private IMsgPackConverter<FieldType> _typeConverter;

        public void Initialize(MsgPackContext context)
        {
            _stringConverter = context.GetConverter<string>();
            _typeConverter = context.GetConverter<FieldType>();
        }

        public void Write(SpaceField value, IMsgPackWriter writer)
        {
            throw new NotImplementedException();
        }

        public SpaceField Read(IMsgPackReader reader)
        {
            var dictLength = reader.ReadMapLength();

            string name = null;
            var type = (FieldType) (-1);

            for (int i = 0; i < dictLength.Value; i++)
            {
                var key = _stringConverter.Read(reader);
                switch (key)
                {
                    case "name":
                        name = _stringConverter.Read(reader);
                        break;
                    case "type":
                        type = _typeConverter.Read(reader);
                        break;
                    default:
                        reader.SkipToken();
                        break;
                }
            }

            return new SpaceField(name, type);
        }
    }
}