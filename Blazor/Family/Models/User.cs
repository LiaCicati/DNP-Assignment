using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class User
    {
        [Required]
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [Required]
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [Required] [JsonPropertyName("city")] public string City { get; set; }

        [Required]
        [JsonPropertyName("birthYear")]
        public int BirthYear { get; set; }

        [Required] [JsonPropertyName("role")] public string Role { get; set; }

        [Required]
        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }

        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}