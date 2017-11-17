using AutoMapper;
using AutomapperSample.Domain;
using AutomapperSample.Models;

namespace AutomapperSample.Mappers
{
    public class CustomerToCustomerDtoProfile : Profile
    {
        public CustomerToCustomerDtoProfile()
        {
            CreateMap<Customer, CustomerDto>();
        }

        public override string ProfileName => GetType().Name;
    }
}
