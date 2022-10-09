using Microsoft.AspNetCore.Mvc;
using ProjectTXServer.Data;
using ProjectTXServer.Entity;
using ProjectTXServer.Models;
using System.Security.Cryptography;

namespace ProjectTXServer.Controllers.Identity
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserManageController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserManageController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<AppUser> GetAll()
        {
            return search();
        }
        [HttpGet("{searchKey}")]
        public List<AppUser> Search(string searchKey)
        {
            return search(searchKey);
        }
        [HttpPost]
        [Route("ResgisterUser")]
        public async Task ResgisterUser(UserModel user)
        {
            await resgisterUser(user);
        }
        private async Task resgisterUser(UserModel user)
        {
            try
            {
                var hmac = new HMACSHA512();
                var userId = Guid.NewGuid().ToString();
                _context.AppUser.Add(new AppUser()
                {
                    Id = userId,
                    UserName = user.UserName,
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true,
                    PasswordHashs = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("123456Aa@")),
                    PasswordSalt = hmac.Key,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserFirstName = "admin first name",
                    UserLastName = "admin last name",
                    UserPhoneNumber = "08658568790",
                    UserDoB = new DateTime(2020, 01, 02)
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<AppUser> search(string searchKey = "")
        {
            try
            {
                var UserQuery = from a in _context.AppUser
                                select new { a };
                if (searchKey != "")
                {
                    UserQuery = UserQuery
                        .Where(text => text.a.UserFirstName.Contains(searchKey) ||
                        text.a.UserName.Contains(searchKey) ||
                        text.a.UserLastName.Contains(searchKey));
                }
                var query = UserQuery.Select(x => new AppUser()
                {
                    UserName = x.a.UserName,
                    UserFirstName = x.a.UserFirstName,
                    UserPhoneNumber = x.a.PhoneNumber,
                    Email = x.a.Email

                }).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
