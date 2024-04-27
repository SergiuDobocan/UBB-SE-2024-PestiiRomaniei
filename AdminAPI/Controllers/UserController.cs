using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdminAPI.Models;
using AdminAPI.Service;

namespace AdminAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserModel userModel)   
        {
            try
            {
                var result = await _userService.Add(userModel);
                return result > 0 ? Ok() : BadRequest("Failed to add user.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserModel userModel)
        {
            try
            {
                var result = await _userService.Update(userModel);
                return result ? Ok() : BadRequest("Failed to update user.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(int userId)
        {
            try
            {
                var result = await _userService.Delete(userId);
                return result ? Ok() : BadRequest("Failed to delete user.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(int userId)
        {
            try
            {
                var user = await _userService.Get(userId);
                return user != null ? Ok(user) : NotFound("User not found.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var userList = await _userService.GetAll();
                return Ok(userList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("exists")]
        public async Task<IActionResult> UserExists(string username, string password)
        {
            try
            {
                var result = await _userService.UserExists(username, password);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
