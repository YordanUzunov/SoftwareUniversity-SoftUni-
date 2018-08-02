namespace Pub.App.Core
{
    using AutoMapper;
    using Pub.App.Core.DTOs;
    using Pub.Models;

    public class PubProfile : Profile
    {
        public PubProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, ManagerDto>()
                .ForMember(dest => dest.EmployeesDto, from => from.MapFrom(x => x.ManagerEmployees))
                .ReverseMap();
            CreateMap<Employee, EmployeePersonalInfoDto>().ReverseMap();
        }
    }
}
