﻿using AutoMapper;
using Notatnik.Shared;
using System;

namespace Notatnik.Server
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Note, NoteDisplayDto>();
            CreateMap<NoteDisplayDto, Note>();


        }
    }
}
