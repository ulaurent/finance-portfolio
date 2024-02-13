using finance_service.Models;

namespace finance_service.Repositories
{
    public interface IStockRepository
    {
        Task<Stock> GetById(string id);
    }
}
