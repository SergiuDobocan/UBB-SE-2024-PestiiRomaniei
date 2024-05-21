// <copyright file="IUserRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using SpookifyApi.Models;

namespace SpookifyApi.Repositories
{

    /// <summary> User Repository Interface. </summary>
    public interface IUserRepository
        {
        /// <summary> Add a new user to the repo. </summary>
        /// <param name="userModel"> The user added. </param>
        /// <returns> integer. </returns>
        Task<int> Add(UserModel userModel);

        /// <summary> Updates user from the repo. </summary>
        /// <param name="userModel"> The user to be modified. </param>
        /// <returns> bolean. </returns>
        Task<bool> Update(UserModel userModel);

        /// <summary> Deletes user from the repo. </summary>
        /// <param name="userId"> The id of the user to delete. </param>
        /// <returns> boolean. </returns>
        Task<bool> Delete(int userId);

        /// <summary> Get user by id. </summary>
        /// <param name="userId"> The id of the user to find. </param>
        /// <returns> UserModel. </returns>
        Task<UserModel> Get(int userId);

        /// <summary> Get all users from the repo. </summary>
        /// <returns> list of users (UserModel). </returns>
        Task<IEnumerable<UserModel>> GetAll();

        /// <summary> Find if user exists. </summary>
        /// <param name="username"> The username of the user to verify. </param>
        /// <param name="password"> The password of the user to verify. </param>
        /// <returns> boolean. </returns>
        Task<bool> UserExists(string username, string password);
        }
}