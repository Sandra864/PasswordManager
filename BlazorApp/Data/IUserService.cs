using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Data
{
    public interface IUserService
    {
        public Task<List<UserViewModel>> GetUsers();
        public Task DeleteUser(string userId);
        public Task UpdateUser(ApplicationUser user);
        public Task<ApplicationUser> GetById(string Id);
    }
}
