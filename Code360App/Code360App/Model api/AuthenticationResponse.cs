using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360App.Model_api
{
    class AuthenticationResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("expiration")]
        public DateTimeOffset Expiration { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }
    }
}
