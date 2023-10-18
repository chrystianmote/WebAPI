using AutoMapper;
using WebAPI.AutoMapper.Models;

namespace WebAPI.AutoMapper.Mappers
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            //Meapeando direto da entrada (inputModel) para o modelo BD.
            CreateMap<PersonInputModel, Person>();

            //Meapeando configurando um atributo membro do modelo BD que é Enum
            //para a saída que é string (viewModel).
            CreateMap<Person, PersonViewModel>()
                .ForMember(
                dest => dest.MaritalStatus,
                opt => opt.MapFrom(
                    orig => orig.MaritalStatus.ToString()
                    )
                );
        }
    }
}
