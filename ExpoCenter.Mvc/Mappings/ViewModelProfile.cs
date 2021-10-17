using AutoMapper;
using ExpoCenter.Dominio.Entidades;
using ExpoCenter.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpoCenter.Mvc.Mappings
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<Participante, ParticipanteIndexViewModel>()
                //.ForMember<>()
                .ReverseMap();

            CreateMap<Participante, ParticipanteCreateViewModel>().ReverseMap();
            CreateMap<Participante, ParticipanteGridViewModel>().ReverseMap();



            //CreateMap<List<Participante>, List<ParticipanteViewModel>>().ReverseMap();


            CreateMap<Evento, EventoViewModel>().ReverseMap();
            
            CreateMap<Evento, EventoGridViewModel>().ReverseMap();




            //CreateMap<List<Evento>, List<EventoViewModel>>().ReverseMap();


        }
    }
}
