using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360App.Model_api
{
    class NewStudent
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("applicantId")]
        public int ApplicantId { get; set; }

        [JsonProperty("coursesId")]
        public int CoursesId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("isLockedOut")]
        public bool IsLockedOut { get; set; }
    }
}
