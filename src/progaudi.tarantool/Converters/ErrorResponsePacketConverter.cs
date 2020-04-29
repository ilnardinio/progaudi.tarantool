using System;

using ProGaudi.MsgPack.Light;

using ProGaudi.Tarantool.Client.Model.Enums;
using ProGaudi.Tarantool.Client.Model.Responses;
using ProGaudi.Tarantool.Client.Utils;

namespace ProGaudi.Tarantool.Client.Converters
{
    internal class ErrorResponsePacketConverter : IMsgPackConverter<ErrorResponse>
    {
        private IMsgPackConverter<Key> _keyConverter;
        private IMsgPackConverter<string> _stringConverter;

        public void Initialize(MsgPackContext context)
        {
            _keyConverter = context.GetConverter<Key>();
            _stringConverter = context.GetConverter<string>();
        }

        public void Write(ErrorResponse value, IMsgPackWriter writer)
        {
            throw new NotImplementedException();
        }

        public ErrorResponse Read(IMsgPackReader reader)
        {
            string errorMessage = null;
            var length = reader.ReadMapLength();

            for (int i = 0; i < length.Value; i++)
            {
                var key = _keyConverter.Read(reader);

                switch (key)
                {
                    case Key.Error:
                        errorMessage = _stringConverter.Read(reader);
                        break;
                    default:
                        reader.SkipToken();
                        break;
                }
            }
            return new ErrorResponse(errorMessage);
        }
    }
}