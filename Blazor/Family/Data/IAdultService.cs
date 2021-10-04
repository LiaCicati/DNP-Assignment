using System.Collections.Generic;
using Family.Models;

namespace Family.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);

        void RemoveAdult(int adultId);
        //
        // Adult Get(int id);
    }
}