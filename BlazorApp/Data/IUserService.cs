using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Data
{
    public interface IUserService
    {
        public Task<List<ApplicationUser>> GetUsers();
        public Task DeleteUser(ApplicationUser user);
        public Task UpdateUser(ApplicationUser user);
        public Task<ApplicationUser> GetById(string Id);
    }
}
