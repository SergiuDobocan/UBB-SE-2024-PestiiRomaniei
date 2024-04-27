using AdminAPI.Models;

namespace AdminAPI.Repositories
{
   
        public interface IUserRepository
        {
            Task<int> Add(UserModel userModel);
            Task<bool> Update(UserModel userModel);
            Task<bool> Delete(int userId);
            Task<UserModel> Get(int userId);
            Task<IEnumerable<UserModel>> GetAll();
            Task<bool> UserExists(string username, string password); 
        }
    
}