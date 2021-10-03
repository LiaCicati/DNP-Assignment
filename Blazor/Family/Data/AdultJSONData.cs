
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;


namespace Family.Data
{
    public class AdultJSONData : IAdultData
    {
        private string AdultFile = "adults.json";
        private IList<Adult> adults;

        public AdultJSONData()
        {
            if (!File.Exists(AdultFile))
            {
                Seed();
                WriteTodosToFile();
            }
            else
            {
                string content = File.ReadAllText(AdultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        private void Seed()
        {
            Adult[] ad =
            {
                new Adult {Id = 1,  FirstName = "Loredana", LastName = "Cicati",  HairColor = "brown", EyeColor = "brown",Age = 20,Height = 164,JobTitle = "kitchen assistent",Sex = "F",Weight = 48},
                new Adult {Id = 1,  FirstName = "Lia", LastName = "John",  HairColor = "brown", EyeColor = "brown",Age = 20,Height = 166,JobTitle = "Web developer",Sex = "F",Weight = 47}
           ,
            };
            adults = ad.ToList();
        }


        public IList<Adult> GetAdults()
        {
            List<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }


  

        public Adult Get(int id)
        {
            return adults.FirstOrDefault(t => t.Id == id);
        }

        private void WriteTodosToFile()
        {
            string todosAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(AdultFile, todosAsJson);
        }
    }
}
        
//         public AdultJSONData()
//         {
//             if (!File.Exists(AdultFile))
//             {
//                 FileStream fs = new FileStream(AdultFile, FileMode.CreateNew);
//                 adults = new List<Adult>();
//                 string productAsJson = JsonSerializer.Serialize(adults);
//                 File.WriteAllText(AdultFile, productAsJson);
//             }
//             else
//             {
//                 ReadAdultsFromFile();
//             }
//         }
//
//         private void WriteAdultsToFile()
//         {
//             string productAsJson = JsonSerializer.Serialize(adults);
//             File.WriteAllText(AdultFile, productAsJson);
//         }
//
//         private void ReadAdultsFromFile()
//         {
//             string content = File.ReadAllText(AdultFile);
//             adults = JsonSerializer.Deserialize<List<Adult>>(content);
//         }
//
//         public IList<Adult> getAdults()
//         {
//             List<Adult> tmp = new List<Adult>(adults);
//             return tmp;
//         }
//
//         public void AddAdult(Adult adult)
//         {
//             int max = adults.Max(adult => adult.Id);
//             adult.Id = ++max;
//             adults.Add(adult);
//             WriteAdultsToFile();
//         }
//
//         public void RemoveAdult(int adultID)
//         {
//             Adult toRemove = adults.First(t => t.Id == adultID);
//             adults.Remove(toRemove);
//             WriteAdultsToFile();
//         
//         }
//     }
// }