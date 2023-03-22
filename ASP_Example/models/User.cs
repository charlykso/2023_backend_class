using System;
using Microsoft.AspNetCore.Identity;

namespace ASP_Example.models
{
    public class User : IdentityUser
    {
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        // public User(string phone_no, string password, DateTime created_at, DateTime updated_at)
        // {
        //     this.phone_no = phone_no;
        //     this.created_at = created_at;
        //     this.updated_at = updated_at;
        //     this.password = password;
        // }
    }
}