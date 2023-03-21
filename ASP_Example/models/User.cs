using System;

namespace ASP_Example.models
{
    public class User
    {
        public Guid id { get; set; }
        public string? email { get; set; }
        public string? phone_no { get; set; }
        public string? password { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public User(Guid id, string email, string phone_no, string password, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.email = email;
            this.phone_no = phone_no;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.password = password;
        }
    }
}