﻿using AutoMapper;
using Library.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.Author, Models.AuthorDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src =>
                $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src =>
                src.DateOfBirth.GetCurrentAge()));
            CreateMap<Entities.Book, Models.BookDto>();
            CreateMap<Models.AuthorForCreationDto, Entities.Author>();
            CreateMap<Models.BookForCreationDto, Entities.Book>();
            CreateMap<Models.BookForUpdateDto, Entities.Book>();
            CreateMap<Entities.Book, Models.BookForUpdateDto>();
        }

    }
}
