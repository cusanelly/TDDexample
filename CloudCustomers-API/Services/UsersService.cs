using CloudCustomers_API.Models;

namespace CloudCustomers_API.Services
{
    public interface IUsersService {
        public Task<List<User>> GetAllUsers();
    }
    public class UsersService : IUsersService
    {
        public UsersService()
        {
            
        }

        public Task<List<User>> GetAllUsers()
        {
            return null;
            //throw new NotImplementedException();
        }
    }
}
