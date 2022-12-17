using AutoMapper;
using CatStore.Application.Mapper;
using CatStore.Application.MediaR.Baskets.Commands.RemoveItem;

namespace CatStore.Application.Dtos.Baskets;

public class RemoveItemDto : IMapWith<RemoveItemCommand>
{
    public Guid UserId { get; set; }
    
    public Guid CatId { get; set; }
    public void Mapping(Profile profile) =>
        profile.CreateMap<RemoveItemDto, RemoveItemCommand>();
}