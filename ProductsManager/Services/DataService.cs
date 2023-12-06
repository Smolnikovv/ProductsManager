using ProductsManager.Config;

namespace ProductsManager.Services
{
    public interface IDataService
    {
        public bool InsertData();
    }
    public class DataService : IDataService
    {
        private readonly Mapper _mapper;
        private readonly DatabaseContext _databaseContext;
        public DataService(Mapper mapper, DatabaseContext databaseContext)
        {
            _mapper = mapper;
            _databaseContext = databaseContext;
        }

        public bool InsertData()
        {
            throw new NotImplementedException();
        }
    }
}
