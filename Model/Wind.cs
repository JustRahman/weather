﻿using Newtonsoft.Json;

namespace weather.Model
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
        [JsonProperty("deg")]
        public int Deg { get; set; }
    }
}