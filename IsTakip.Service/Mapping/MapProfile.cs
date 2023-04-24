using AutoMapper;
using IsTakip.Core.Classes.KullaniciClasses;
using IsTakip.Core.DTOs.KullaniciDTOs;

namespace IsTakip.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<KullaniciCreateDto, Kullanici>().ReverseMap();
        }
    }
}
