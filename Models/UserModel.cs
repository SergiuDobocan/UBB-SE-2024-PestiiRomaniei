// <copyright file="UserModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using System.ComponentModel.DataAnnotations;

namespace SpookifyApi.Models
{

    /// <summary>
    /// User Model for user account types.
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Gets or sets get and set User id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets User name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string? Username { get; set; }

        /// <summary>
        /// Gets or sets User password.
        /// </summary>
        [Required]
        [StringLength(100)] // Hashing needed???
        required public string Password { get; set; }

        /// <summary>
        /// Gets or sets User role.
        /// </summary>
        [Required]
        public UserRole Role { get; set; }
    }

#pragma warning disable SA1201 // Elements should appear in the correct order
#pragma warning disable SA1600 // Elements should be documented
    public enum UserRole
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1201 // Elements should appear in the correct order
    {
        /// <summary>
        /// Normal user - listen to music.
        /// </summary>
        Normal,

        /// <summary>
        /// Admin - for user accounts.
        /// </summary>
        Admin,

        /// <summary>
        /// Artist - add music.
        /// </summary>
        Artist,
    }
}
