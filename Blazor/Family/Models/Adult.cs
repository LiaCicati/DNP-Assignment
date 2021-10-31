using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Models;

namespace Family.Models
{
    public class Adult : Person
    {
        [JsonPropertyName("jobTitle")] public Job JobTitle { get; set; }
    }
}