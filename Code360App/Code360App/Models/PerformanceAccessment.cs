using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360App.Models
{
    class PerformanceAccessment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("studentId")]
        public int StudentId { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
