using finance_service.Models;
using finance_service.Repositories;

namespace finance_service.Services
{
    public class StocksService : IStocksService
    {
        private readonly IStockRepository _stockRepository;
        public StocksService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;        
        }

        public async Task<Stock> GetById(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return await _stockRepository.GetById(id);
            }

            return null;
        }
    }
}
