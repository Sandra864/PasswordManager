using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task DeleteUser(string userId)
        {
            var user = _userManager.Users.First(x => x.Id == userId);
            await _userManager.DeleteAsync(user);
        }

        public async Task<List<UserViewModel>> GetUsers()
        {
            var applicationUsers = await _userManager.Users.ToListAsync();
            return  _mapper.Map<List<ApplicationUser>, List<UserViewModel>>(applicationUsers);
        }

        public async Task<ApplicationUser> GetById(string Id)
        {
            var result = await _userManager.FindByIdAsync(Id);
            return result;
        }

        public async Task UpdateUser(ApplicationUser user)
        {
            await _userManager.UpdateAsync(user);
        }

    }
}