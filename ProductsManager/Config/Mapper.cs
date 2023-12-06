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
            CreateMap<Products, ProductDto>();
        }
    }
}
