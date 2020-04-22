﻿namespace ProGaudi.Tarantool.Client.Model.Enums
{
    public enum Key : uint
    {
        // Request keys
        Code = 0x00,
        Sync = 0x01,
        SchemaId = 0x05,
        SpaceId = 0x10,
        IndexId = 0x11,
        Limit = 0x12,
        Offset = 0x13,
        Iterator = 0x14,
        Key = 0x20,
        Tuple = 0x21,
        FunctionName = 0x22,
        Username = 0x23,
        Expression = 0x27,
        Ops = 0x28,
        FieldName = 0x00,

        // Response keys
        Data = 0x30,
        Error = 0x31,
        Metadata = 0x32,

        // Sql keys
        SqlQueryText = 0x40,
        SqlParameters = 0x41,
        SqlOptions = 0x42,
        SqlInfo = 0x42,
        SqlRowCount = 0x00,

        // Replication keys
        ServerId = 0x02,
        Lsn = 0x03,
        Timestamp = 0x04,
        ServerUuid = 0x24,
        ClusterUuid = 0x25,
        Vclock = 0x26,
    }
}