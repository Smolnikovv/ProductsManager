using ProductsManager.Config;

namespace ProductsManager.Services
{
    public interface IDataService
    {
        public bool InsertData();
    }
    public class DataService : IDataService
    {
        private readonly MappingProfile _mapper;
        private readonly DatabaseContext _databaseContext;
        public DataService(MappingProfile mapper, DatabaseContext databaseContext)
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
