using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Models;

namespace Family.Models
{
    public class Adult : Person
    {
        public Job JobTitle { get; set; }
    }
}