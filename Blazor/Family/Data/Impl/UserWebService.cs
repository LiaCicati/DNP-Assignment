using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Family.Data.Impl
{
    public class UserWebService : IUserService
    {
        public async Task AddUserAsync(User user)
        {
            HttpClient client = new HttpClient();
            string usersAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(usersAsJson, Encoding.UTF8, "application/json");
             await client.PostAsync( "https://localhost:5003/users", content);
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync($"https://localhost:5003/users?userName={userName}&password={password}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser;
            }

            throw new Exception("User not found");
        }
    }
}