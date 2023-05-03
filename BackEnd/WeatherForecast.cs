using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BackEnd {
    public class WeatherForecast {
        [XmlAttribute("Fecha")]
        [JsonPropertyName("Fecha")]
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [XmlIgnore]
        public string? Summary { get; set; }
    }
}