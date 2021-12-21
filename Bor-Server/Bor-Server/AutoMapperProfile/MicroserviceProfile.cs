using Albina.BusinesLogic.Core.Models;
using AutoMapper;
using Bor.Core.Models;



namespace Bor_Server.AutoMapperProfile
{
    public class MicroserviceProfile : Profile
    {
        public MicroserviceProfile()
        {
            CreateMap<UserInformationBlo, UserInfoprmationDto>();
            CreateMap<UserIdentityBlo, UserIdentityDto>();
            CreateMap<UserIdentityDto, UserIdentityBlo>();
            CreateMap<UserUpdateDto, UserUpdateBlo>();
            CreateMap<UserUpdateBlo, UserUpdateDto>();
        }
    }
}
