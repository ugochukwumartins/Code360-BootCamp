﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360App.Model_api
{
  public  class LoginClassDetail
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
