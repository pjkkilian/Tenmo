﻿using System.ComponentModel.DataAnnotations;

namespace TenmoServer.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
    }

    /// <summary>
    /// Model to return upon successful login
    /// </summary>
    public class ReturnUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; } = "user";
        public string Token { get; set; }
    }

    /// <summary>
    /// Model to accept login parameters
    /// </summary>
    public class LoginUser
    {
        //[Required(ErrorMessage = "The 'Username' field must not be blank.")]
        public string Username { get; set; } = "";

        //[Required(ErrorMessage = "The 'Password' field must not be blank.")]
        public string Password { get; set; } = "";
    }
       
}
