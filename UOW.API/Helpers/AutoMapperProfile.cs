using AutoMapper;
using UOW.Entities.Domain;
using UOW.Entities.DTO;

namespace UOW.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
