using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task DeleteUser(IdentityUser user)
        {
           await _userManager.DeleteAsync(user);
        }

        public async Task<List<IdentityUser>> GetUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<IdentityUser> GetById(string Id)
        {
            var result= await _userManager.FindByIdAsync(Id);
            return result;
        }

        public async Task UpdateUser(IdentityUser user)
        {
            await _userManager.UpdateAsync(user);
        }

    }
}