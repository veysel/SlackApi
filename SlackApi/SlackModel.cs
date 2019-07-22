using Newtonsoft.Json;

namespace SlackApi
{
    internal class SlackModel
    {
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "author_name")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "footer")]
        public string Footer { get; set; }
    }
}