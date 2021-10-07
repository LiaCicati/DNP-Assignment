using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Family.Models;
using Models;

namespace Family.Models
{
    public class Famili
    {
        //public int Id { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public List<Adult> Adults { get; set; }
        public List<Child> Children { get; set; }
        public List<Pet> Pets { get; set; }

        public Famili()
        {
            Adults = new List<Adult>();
        }
    }
}