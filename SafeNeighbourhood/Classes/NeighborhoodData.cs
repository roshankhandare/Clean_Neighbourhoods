﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuicktypeNeighborhood;
//
//    var neighborhoodData = NeighborhoodData.FromJson(jsonString);

namespace QuicktypeNeighborhood
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NeighborhoodData
    {
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("wfdb")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Wfdb { get; set; }
    }

    public partial class NeighborhoodData
    {
        public static List<NeighborhoodData> FromJson(string json) => JsonConvert.DeserializeObject<List<NeighborhoodData>>(json, QuicktypeNeighborhood.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<NeighborhoodData> self) => JsonConvert.SerializeObject(self, QuicktypeNeighborhood.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
