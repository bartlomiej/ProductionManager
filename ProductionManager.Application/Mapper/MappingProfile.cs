using AutoMapper;
using ProductionManager.Application.Functions.Products;
using ProductionManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManager.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ReverseMap();

            


        }
    }
}
