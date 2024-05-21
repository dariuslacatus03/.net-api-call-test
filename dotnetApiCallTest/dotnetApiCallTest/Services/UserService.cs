using dotnetApiCallTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace dotnetApiCallTest.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7190")
            };
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                var users = await _httpClient.GetFromJsonAsync<List<User>>("/api/User");
                if (users == null)
                {
                    throw new Exception("Users list is empty");
                }
                return users;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("Error fetching users", ex);
            }
        }
    }
}
