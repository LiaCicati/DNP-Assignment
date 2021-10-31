using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Family.Models;

namespace Family.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdults();
        Task<HttpStatusCode> AddAdult(Adult adult);
        Task RemoveAdult(int adultId);
    }
}