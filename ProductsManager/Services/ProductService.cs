using ProductsManager.Model;
using ProductsManager.Config;

namespace ProductsManager.Services
{
    public interface IProductService
    {
        public List<ProductDto> GetBySKU(string SKU);
    }
    public class ProductService : IProductService
    {
        private readonly Mapper _mapper;
        private readonly DatabaseContext _context;
        public ProductService(Mapper mapper, DatabaseContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<ProductDto> GetBySKU(string SKU)
        {
            throw new NotImplementedException();
        }
    }
}
