﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace N_m3u8DL_RE.Common.JsonConverter;

internal class BytesBase64Converter : JsonConverter<byte[]>
{
    public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetBytesFromBase64();

    public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options) => writer.WriteStringValue(Convert.ToBase64String(value));
}