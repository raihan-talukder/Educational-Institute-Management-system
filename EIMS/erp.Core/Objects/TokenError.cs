using Newtonsoft.Json;

namespace Erp.Core.Objects
{
    public class TokenError
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }
    }
}
