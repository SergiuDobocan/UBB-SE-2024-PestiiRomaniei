// <copyright file="UserService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using SpookifyApi.Models;
using SpookifyApi.Repositories;

namespace SpookifyApi.Service
{


    /// <summary> User service class. </summary>
    public class UserService : IUserService
    {
        private readonly UserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class. Creates the repo. </summary>
        /// <param name="userRepo"> constructor. </param>
        /// <returns> null. </returns>
        public UserService(UserRepository userRepo)
        {
            this.userRepository = userRepo;
        }

        /// <summary>
        /// Add new user to the user repository.
        /// </summary>
        /// <param name="userModel"> The model of the user to add. </param>
        /// <returns> integer. </returns>
        /// <exception cref="Exception"> handle user insertion with exception. </exception>
        public async Task<int> Add(UserModel userModel)
        {
            try
            {
                return await this.userRepository.Add(userModel);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add user.", ex);
            }
        }

        /// <summary>
        ///  Update user in repo.
        /// </summary>
        /// <param name="userModel"> The user info we want to update existing user with. </param>
        /// <returns> boolean. </returns>
        /// <exception cref="Exception"> Handle update with exception. </exception>
        public async Task<bool> Update(UserModel userModel)
        {
            try
            {
                return await this.userRepository.Update(userModel);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update user.", ex);
            }
        }

        /// <summary>
        /// Delete user from repo.
        /// </summary>
        /// <param name="userId"> The id of the user we want to delete. </param>
        /// <returns> boolean. </returns>
        /// <exception cref="Exception">Handle deletion with exception. </exception>
        public async Task<bool> Delete(int userId)
        {
            try
            {
                return await this.userRepository.Delete(userId);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to delete user.", ex);
            }
        }

        /// <summary>
        /// Get existing user by id.
        /// </summary>
        /// <param name="userId">The id of the user we want to find. </param>
        /// <returns> Found user as UserModel. </returns>
        /// <exception cref="Exception"> Handle getting the user with exception. </exception>
        public async Task<UserModel> Get(int userId)
        {
            try
            {
                return await this.userRepository.Get(userId);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to get user.", ex);
            }
        }

        /// <summary>
        /// Get all users from the repo.
        /// </summary>
        /// <returns> List of users. </returns>
        /// <exception cref="Exception"> Handle getting the list of users with exception. </exception>
        public async Task<IEnumerable<UserModel>> GetAll()
        {
            try
            {
                return await this.userRepository.GetAll();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to get all users.", ex);
            }
        }

        /// <summary>
        /// Find if a given user exists.
        /// </summary>
        /// <param name="username"> The username of the user to find. </param>
        /// <param name="password"> The password of the user to find. </param>
        /// <returns> boolean. </returns>
        /// <exception cref="Exception"> Handle search with exception. </exception>
        public async Task<bool> UserExists(string username, string password)
        {
            try
            {
                return await this.userRepository.UserExists(username, password);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("Failed to check if user exists.", ex);
            }
        }
    }
}
