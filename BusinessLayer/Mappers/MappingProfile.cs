using AutoMapper;
using BusinessLayer.DTOs;
using DataAccessLayer.Models; 

namespace BusinessLayer.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
        }
    }
}
