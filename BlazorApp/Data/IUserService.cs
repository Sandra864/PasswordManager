using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Data
{
    public interface IUserService
    {
        public Task<List<IdentityUser>> GetUsers();
        public Task DeleteUser(IdentityUser user);
        public Task UpdateUser(IdentityUser user);
        public Task<IdentityUser> GetById(string Id);
    }
}
