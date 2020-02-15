using System;
using System.Collections.Generic;
using System.Text;
using Katmanli_AutoMapper.Entity;
using AutoMapper;

namespace Katmanli_AutoMapper.DAL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FilterDto, FilterRepositoryDto>();
        }
    }
}
