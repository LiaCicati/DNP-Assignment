using System.Collections.Generic;
using Family.Models;
using Family.Persistence;

namespace Family.Data.Impl
{
    public class AdultService : IAdultService
    {
        private FileContext familyFile;
        IList<Adult> adults = new List<Adult>();

        public AdultService(FileContext familyFile)
        {
            this.familyFile = familyFile;
        }

        public IList<Adult> GetAdults()
        {
            foreach (var item in familyFile.Families)
            {
                foreach (var adult in item.Adults)
                {
                    adults.Add(adult);
                }
            }

            return adults;
        }
    }
}