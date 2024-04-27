using AdminAPI.Models;
using AdminAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminAPI.Service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Add(UserModel userModel)
        {
            try
            {
                return await _userRepository.Add(userModel);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to add user.", ex);
            }
        }

        public async Task<bool> Update(UserModel userModel)
        {
            try
            {
                return await _userRepository.Update(userModel);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to update user.", ex);
            }
        }

        public async Task<bool> Delete(int userId)
        {
            try
            {
                return await _userRepository.Delete(userId);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to delete user.", ex);
            }
        }

        public async Task<UserModel> Get(int userId)
        {
            try
            {
                return await _userRepository.Get(userId);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to get user.", ex);
            }
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            try
            {
                return await _userRepository.GetAll();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to get all users.", ex);
            }
        }

        public async Task<bool> UserExists(string username, string password)
        {
            try
            {
                return await _userRepository.UserExists(username, password);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to check if user exists.", ex);
            }
        }
    }
}
