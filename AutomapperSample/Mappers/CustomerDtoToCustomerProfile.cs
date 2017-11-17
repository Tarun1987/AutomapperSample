using AutoMapper;
using AutomapperSample.Domain;
using AutomapperSample.Models;

namespace AutomapperSample.Mappers
{
    public class CustomerDtoToCustomerProfile : Profile
    {
        public CustomerDtoToCustomerProfile()
        {
            CreateMap<CustomerDto, Customer>()
            
            // Ignoring these fields as they are not present in CustomerDto
            .ForMember(to => to.Updated, opts => opts.Ignore())
            .ForMember(to => to.UpdatedBy, opts => opts.Ignore())
            .ForMember(to => to.Created, opts => opts.Ignore())
            .ForMember(to => to.CreatedBy, opts => opts.Ignore());

        }

        public override string ProfileName => GetType().Name;
    }
}
