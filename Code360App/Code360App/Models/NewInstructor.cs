using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360App.Models
{
    class NewInstructor
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
