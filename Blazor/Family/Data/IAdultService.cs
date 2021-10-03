using System.Collections.Generic;
using Family.Models;
using Models;

namespace Family.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
    }
}