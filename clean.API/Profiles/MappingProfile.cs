using AutoMapper;
using clean.API.Models;
using Clean.Core.DTOs;
using Clean.Core.Models;

namespace Clean.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // מיפוי בין Room ל-RoomDTO
            CreateMap<Room, RoomDTO>().ReverseMap();
            CreateMap<RoomPostModel, Room>(); // מיפוי בין RoomPostModel ל-Room

            //Prisoner
            CreateMap<Prisoner, PrisonerDTO>().ReverseMap();
            CreateMap<PrisonerPostModel, Prisoner>();

            //Prison_Guard
            CreateMap<Prison_Guard, Prison_GuardDTO>().ReverseMap();
            CreateMap<Prison_GuardPostModel, Prison_Guard>();
        }
    }
}
