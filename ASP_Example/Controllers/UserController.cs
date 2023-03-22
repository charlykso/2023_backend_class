using ASP_Example.models;
using Microsoft.AspNetCore.Mvc;
using ASP_Example.collective;

namespace ASP_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly BlogDBContext blogDBContext;
        public UserController(BlogDBContext _blogDBContext)
        {
            blogDBContext = _blogDBContext;
        }

        [HttpGet]
        [Route("/createUser")]
        public ActionResult createUser()
        {
            List<User> UsersList = new List<User>();
            var user1 = new User();
            var user2 = new User();

            user1.PasswordHash = HashPassword.hashPassword("ikenna123");
            user1.UserName = "ikenna";
            user1.Email = "ikenna@gmail.com";
            user1.PhoneNumber = "+2347062682820";
            user1.created_at = DateTime.Now;
            user1.updated_at = DateTime.Now;

            user2.PasswordHash = HashPassword.hashPassword("ikenna124");
            user2.UserName = "remigius";
            user2.Email = "remigius@gmail.com";
            user2.PhoneNumber = "+2347062682821";
            user2.created_at = DateTime.Now;
            user2.updated_at = DateTime.Now;

            UsersList.Add(user1);
            UsersList.Add(user2);

            blogDBContext.users.AddRange(UsersList);
            blogDBContext.SaveChanges();
            return Ok(UsersList);
        }

        [HttpGet]
        [Route("/Users")]
        public ActionResult getUsers()
        {
            var users = blogDBContext.users.ToList();
            int count = 0;
            foreach (var item in users)
            {
                count = count + 1;
            }
            var dusers = new
            {
                users = users,
                length = count,
            };

            return Ok(dusers);
        }

        [HttpGet]
        [Route("/getUser/{id}")]
        public ActionResult getsingleUser([FromRoute] string id)
        {
            var user = blogDBContext.users.Find(id);

            return Ok(user);
        }

        [HttpDelete]
        [Route("/user/{id}/delete")]
        public ActionResult deleteUser([FromRoute] string id)
        {
            var user = blogDBContext.users.Find(id);
            if (user is not null)
            {
                blogDBContext.users.Remove(user!);
                blogDBContext.SaveChanges();

                return NoContent();
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("/user/{id}/edit")]
        public ActionResult updateUser([FromRoute] string id)
        {
            try
            {
                var user = blogDBContext.users.Find(id);
                if (user is not null)
                {
                    user.Email = "newEmail@gmail.com";
                    user.UserName = "newUsername";
                    user.PhoneNumber = "newNumber";
                    user.updated_at = DateTime.Now;

                    blogDBContext.users.Append(user);
                    blogDBContext.SaveChanges();

                    return Ok(user);
                }

                return NotFound();
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
