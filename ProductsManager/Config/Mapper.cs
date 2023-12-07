using AutoMapper;
using ProductsManager.Entities;
using ProductsManager.Model;

namespace ProductsManager.Config
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            MapProduct();
        }
        private void MapProduct()
        {
            CreateMap<Products, ProductDto>()
                .ForMember(x => x.NettPrice, c => c.MapFrom(s => s.Prices.NettPrice))
                .ForMember(x => x.ShippingCost, c => c.MapFrom(s => s.Inventory.ShippingCost))
                .ForMember(x => x.Quantity, c => c.MapFrom(s => s.Inventory.Quantity))
                .ForMember(x => x.Unit, c => c.MapFrom(s => s.Inventory.Unit));
        }
    }
}
