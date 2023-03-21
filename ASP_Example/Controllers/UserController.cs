using System;
using ASP_Example.models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using ASP_Example.collective;

namespace ASP_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        [Route("/getUsers")]
        public ActionResult getallUser()
        {
            List<User> UsersList = new List<User>();

            // User user1 = new User();
            // User user2 = new User();
            // User user3 = new User();
            // User user4 = new User();
            // User user5 = new User();

            // user1.id = Guid.NewGuid();
            // user2.id = Guid.NewGuid();
            // user3.id = Guid.NewGuid();
            // user4.id = Guid.NewGuid();
            // user5.id = Guid.NewGuid();

            // user1.email = "ikenna@gmail.com";
            // user2.email = "remigius@gmail.com";
            // user3.email = "chukwuka@gmail.com";
            // user4.email = "charles@gmail.com";
            // user5.email = "charlykso@gmail.com";

            // UsersList.Add(user1);
            // UsersList.Add(user2);
            // UsersList.Add(user3);
            // UsersList.Add(user4);
            // UsersList.Add(user5);

            UsersList.Add(new User(Guid.NewGuid(), "ikenna@gmail.com", "+2347062682820", HashPassword.hashPassword("ikenna123"), DateTime.Now, DateTime.Now));
            UsersList.Add(new User(Guid.NewGuid(), "remigius@gmail.com", "+2347062682821", HashPassword.hashPassword("ikenna124"), DateTime.Now, DateTime.Now));
            UsersList.Add(new User(Guid.NewGuid(), "chukwuka@gmail.com", "+2347062682822", HashPassword.hashPassword("ikenna125"), DateTime.Now, DateTime.Now));
            UsersList.Add(new User(Guid.NewGuid(), "charles@gmail.com", "+2347062682823", HashPassword.hashPassword("ikenna126"), DateTime.Now, DateTime.Now));
            UsersList.Add(new User(Guid.NewGuid(), "charlykso@gmail.com", "+2347062682824", HashPassword.hashPassword("ikenna127"), DateTime.Now, DateTime.Now));
            return Ok(UsersList);
        }
    }
}
