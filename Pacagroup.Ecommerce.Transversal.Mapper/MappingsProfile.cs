using System;
using AutoMapper;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Application.DTO;

namespace Pacagroup.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customers, CustomersDto>().ReverseMap();

            //CreateMap<Customers, CustomersDto>().ReverseMap()
            //    .ForMember(destination=>destination.CustomerId, source=>source.MapFrom(src=>src.CustomerId));
        }
    }
}
