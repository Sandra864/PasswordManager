using BlazorApp.Data;
using AutoMapper;

namespace BlazorApp.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>()
                 .ForMember(
                     dest => dest.Id,
                     opt => opt.MapFrom(src => $"{src.Id}")
                 )
                 .ForMember(
                     dest => dest.FirstName,
                     opt => opt.MapFrom(src => $"{src.firstName}")
                 )
                 .ForMember(
                     dest => dest.LastName,
                     opt => opt.MapFrom(src => $"{src.lastName}")
                 )
                 .ForMember(
                     dest => dest.Email,
                     opt => opt.MapFrom(src => $"{src.Email}")
                 )
                 .ForMember(
                     dest => dest.Phone,
                     opt => opt.MapFrom(src => $"{src.PhoneNumber}")
                 )
                 .ForMember(
                     dest => dest.Password,
                     opt => opt.MapFrom(src => $"{src.PasswordHash}")
                 );
        }
    }
}
