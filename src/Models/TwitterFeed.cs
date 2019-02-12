namespace TwitterFeed.Models
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;
    using System;

    public class TwitterFeed
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Topic")]
        public string Topic { get; set; }

        [JsonProperty(PropertyName = "SentimentScore")]
        public int SentimentScore { get; set; }

        [JsonProperty(PropertyName = "Author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}