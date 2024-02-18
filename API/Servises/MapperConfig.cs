using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Servises;

public class MapperConfig: Profile
{
    public MapperConfig()
    {
        CreateMap<Items, ItemDTO>();
       
    }
}
