using finance_service.Models;

namespace finance_service.Services
{
    public interface IStocksService
    {
        Task<Stock> GetById(string id);
    }
}
