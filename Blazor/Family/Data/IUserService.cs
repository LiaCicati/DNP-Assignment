using System.Threading.Tasks;
using Models;

namespace Family.Data
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}