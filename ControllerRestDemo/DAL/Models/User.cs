﻿namespace ControllerRestDemo.DAL.Models
{
    public record User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
