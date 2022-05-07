using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task DeleteUser(ApplicationUser user)
        {
           await _userManager.DeleteAsync(user);
        }

        public async Task<List<ApplicationUser>> GetUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<ApplicationUser> GetById(string Id)
        {
            var result= await _userManager.FindByIdAsync(Id);
            return result;
        }

        public async Task UpdateUser(ApplicationUser user)
        {
            await _userManager.UpdateAsync(user);
        }

    }
}