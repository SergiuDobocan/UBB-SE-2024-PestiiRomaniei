// <copyright file="UsersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using SpookifyApi.Models;
using SpookifyApi.Service;
using Microsoft.AspNetCore.Mvc;
namespace SpookifyApi.Controllers
{


    [ApiController]
    [Route("[controller]")]

#pragma warning disable SA1600 // Elements should be documented
    public class UsersController : ControllerBase
#pragma warning restore SA1600 // Elements should be documented
    {
        private readonly UserService userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="service"> Initialize user service fro controller. </param>
        public UsersController(UserService service)
        {
            this.userService = service;
        }

        /// <summary>
        /// Add user to service.
        /// </summary>
        /// <param name="userModel"> User to add to service. </param>
        /// <returns> Post action. </returns>
        [HttpPost]
        public async Task<IActionResult> Add(UserModel userModel)
        {
            try
            {
                var result = await this.userService.Add(userModel);
                return result > 0 ? this.Ok() : this.BadRequest("Failed to add user.");
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Update user from service.
        /// </summary>
        /// <param name="userModel"> User to update in service.</param>
        /// <returns> Put action. </returns>
        [HttpPut]
        public async Task<IActionResult> Update(UserModel userModel)
        {
            try
            {
                var result = await this.userService.Update(userModel);
                return result ? this.Ok() : this.BadRequest("Failed to update user.");
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Delete user from service.
        /// </summary>
        /// <param name="userId"> Id of the user to delete. </param>
        /// <returns> Delete action. </returns>
        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(int userId)
        {
            try
            {
                var result = await this.userService.Delete(userId);
                return result ? this.Ok() : this.BadRequest("Failed to delete user.");
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Get user by id from service.
        /// </summary>
        /// <param name="userId"> Id of the user to find. </param>
        /// <returns> Get action. </returns>
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(int userId)
        {
            try
            {
                var user = await this.userService.Get(userId);
                return user != null ? this.Ok(user) : this.NotFound("User not found.");
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Get all users from service.
        /// </summary>
        /// <returns> Get action. </returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var userList = await this.userService.GetAll();
                return this.Ok(userList);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Find if user exists.
        /// </summary>
        /// <param name="username"> Username of the user to find.</param>
        /// <param name="password"> Matching password of the user to find.</param>
        /// <returns> Post action. </returns>
        [HttpPost("exists")]
        public async Task<IActionResult> UserExists(string username, string password)
        {
            try
            {
                var result = await this.userService.UserExists(username, password);
                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
