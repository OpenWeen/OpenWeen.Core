﻿using Newtonsoft.Json;

namespace OpenWeen.Core.Model
{
    public class EmotionModel
    {
        [JsonProperty("phrase")]
        public string Phrase { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("hot")]
        public bool Hot { get; set; }

        [JsonProperty("common")]
        public bool Common { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("picid")]
        public string PicID { get; set; }
    }
}