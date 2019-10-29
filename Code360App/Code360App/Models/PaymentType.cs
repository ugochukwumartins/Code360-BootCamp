using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360App.Models
{
    class PaymentType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
