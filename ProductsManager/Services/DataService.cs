using AutoMapper;
using ProductsManager.Config;
using ProductsManager.Entities;
using ProductsManager.Model;

namespace ProductsManager.Services
{
    public interface IDataService
    {
        public bool InsertData();
    }
    public class DataService : IDataService
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _databaseContext;
        public DataService(IMapper mapper, DatabaseContext databaseContext)
        {
            _mapper = mapper;
            _databaseContext = databaseContext;
        }

        public bool InsertData()
        {
            #region Products
            try
            {

            }
            catch
            {
                return false;
            }
            #endregion
            #region Inventory
            try
            {

            }
            catch
            {
                return false;
            }
            #endregion
            #region Prices
            try
            {
                var pricesMemory = GetFile("#");
                var dto = PriceDto();

                foreach(var item in dto)
                {
                    var price = _mapper.Map<Prices>(dto);
                    _databaseContext.Prices.Add(price);
                    _databaseContext.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            #endregion
            return true;
        }
        private MemoryStream GetFile(string path)
        {
            var memory = new MemoryStream();
            var net = new System.Net.WebClient();
            var data = net.DownloadData(path);
            var content = new System.IO.MemoryStream(data);
            memory = content;
            memory.Position = 0;
            return memory;
        }
        private List<CreatePriceDto> PriceDto()
        {
            List<CreatePriceDto> dto = new List<CreatePriceDto>();


            return dto;
        }
    }
}
