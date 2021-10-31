using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Person
    {
        [JsonPropertyName("id")] public int Id { get; set; }

        [JsonPropertyName("firstName")]
        [Required(ErrorMessage = "First Name Field is Required")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        [Required(ErrorMessage = "Last Name Field is Required")]
        public string LastName { get; set; }

        [JsonPropertyName("hairColor")]
        [Required(ErrorMessage = "Hair color Field is Required")]
        public string HairColor { get; set; }

        [JsonPropertyName("eyeColor")]
        [Required(ErrorMessage = "Eye color Field is Required")]
        public string EyeColor { get; set; }

        [JsonPropertyName("age")]
        [Required, Range(18, 120)]
        public int Age { get; set; }

        [JsonPropertyName("weight")]
        [Required, Range(1, 250)]
        public float Weight { get; set; }

        [JsonPropertyName("height")]
        [Required, Range(30, 250)]
        public int Height { get; set; }

        [JsonPropertyName("sex")]
        [Required(ErrorMessage = "Sex Field is Required")]
        public string Sex { get; set; }
    }
}