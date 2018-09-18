using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace PedroH.Software.Desenvolvimento.APIs.ClimaTempo
{
    class ClimaResponse
    {
        
        public partial class Clima
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public partial class Data
        {
            [JsonProperty("temperature")]
            public long Temperature { get; set; }

            [JsonProperty("wind_direction")]
            public string WindDirection { get; set; }

            [JsonProperty("wind_velocity")]
            public long WindVelocity { get; set; }

            [JsonProperty("humidity")]
            public long Humidity { get; set; }

            [JsonProperty("condition")]
            public string Condition { get; set; }

            [JsonProperty("pressure")]
            public long Pressure { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("sensation")]
            public long Sensation { get; set; }

            [JsonProperty("date")]
            public DateTimeOffset Date { get; set; }
        }
    }

    public partial class Clima
    {
        public static Clima FromJson(string json) => JsonConvert.DeserializeObject<Clima>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Clima self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
        };
    }
}
