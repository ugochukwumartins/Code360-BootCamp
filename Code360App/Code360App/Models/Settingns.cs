using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360App.Models
{
    class Settingns
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("testPassPercentage")]
        public int TestPassPercentage { get; set; }

        [JsonProperty("testTolerancePercentage")]
        public int TestTolerancePercentage { get; set; }

        [JsonProperty("questionsNumber")]
        public int QuestionsNumber { get; set; }

        [JsonProperty("preworkDate")]
        public DateTimeOffset PreworkDate { get; set; }

        [JsonProperty("performancePercentage")]
        public int PerformancePercentage { get; set; }
    }
}
