using System.Collections.Generic;
using Newtonsoft.Json;

namespace Privat24Info.Models
{
    public class Terminal
    {
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("address")]
        public string address { get; set; }
        [JsonProperty("devices")]
        public List<Device> devices { get; set; }
    }

    public class Device
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("cityRU")]
        public string cityRU { get; set; }
        [JsonProperty("cityUA")]
        public string cityUA { get; set; }
        [JsonProperty("cityEN")]
        public string cityEN { get; set; }
        [JsonProperty("fullAddressRu")]
        public string fullAddressRu { get; set; }
        [JsonProperty("fullAddressUa")]
        public string fullAddressUa { get; set; }
        [JsonProperty("fullAddressEn")]
        public string fullAddressEn { get; set; }
        [JsonProperty("placeRu")]
        public string placeRu { get; set; }
        [JsonProperty("placeUa")]
        public string placeUa { get; set; }
        [JsonProperty("latitude")]
        public string latitude { get; set; }
        [JsonProperty("longitude")]
        public string longitude { get; set; }
        [JsonProperty("tw")]
        public Tw tw { get; set; }
    }

    public class Tw
    {
        [JsonProperty("mon")]
        public string mon { get; set; }
        [JsonProperty("tue")]
        public string tue { get; set; }
        [JsonProperty("wed")]
        public string wed { get; set; }
        [JsonProperty("thu")]
        public string thu { get; set; }
        [JsonProperty("fri")]
        public string fri { get; set; }
        [JsonProperty("sat")]
        public string sat { get; set; }
        [JsonProperty("sun")]
        public string sun { get; set; }
        [JsonProperty("hol")]
        public string hol { get; set; }
    }
}
