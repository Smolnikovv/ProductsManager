using ProductsManager.Model;
using ProductsManager.Config;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace ProductsManager.Services
{
    public interface IProductService
    {
        public List<ProductDto> GetBySKU(string SKU);
    }
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _context;
        public ProductService(IMapper mapper, DatabaseContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<ProductDto> GetBySKU(string SKU)
        {
            var result = _context.Products
                .Include(x=>x.Prices)
                .Include(x=>x.Inventory)
                .ToList();

            if (result is null) return null;

            return _mapper.Map<List<ProductDto>>(result);
        }
    }
}
