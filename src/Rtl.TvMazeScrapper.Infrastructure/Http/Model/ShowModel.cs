﻿using Newtonsoft.Json;

namespace Rtl.TvMazeScrapper.Infrastructure.Http.Model
{
    public class ShowModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
