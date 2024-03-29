﻿using AutoMapper;
using NotesBlazorApp.Shared.Models;
using NotesBlazorApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace NotesBlazorApp.Server.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Note, NoteViewModel>();

            CreateMap<NoteViewModel, Note>().ForMember(dest => dest.ColorCard, opt => opt.Ignore());
			CreateMap<ColorCard, ColorViewModel>().ReverseMap();
		}
    }
}
