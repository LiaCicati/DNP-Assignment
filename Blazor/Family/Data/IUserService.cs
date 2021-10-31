using System.Threading.Tasks;
using Models;

namespace Family.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
    }
}