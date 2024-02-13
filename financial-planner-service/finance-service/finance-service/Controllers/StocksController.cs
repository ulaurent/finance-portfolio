using finance_service.Models;
using finance_service.Services;
using Microsoft.AspNetCore.Mvc;

namespace finance_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StocksController : ControllerBase
    {
        //private readonly ILogger _logger;
        private readonly IStocksService _stocksService;

        public StocksController(IStocksService stocksService)
        {
            //_logger = logger;
            _stocksService = stocksService;
        }

        [HttpGet("{id}", Name = "getStockById")]
        public async Task<IActionResult> GetStockById(string id)
        {
            /*
            Dictionary<string, Stock> data = new Dictionary<string, Stock>()
            {
                {"AAPL", new Stock {Ticker = "AAPL",
                    Data = new StockData{
                        Close = 45, High = 58, Low = 43, NumberOfTransactions = 22, Open = 47, Volume = 456, VolumeWeighted = 8789.56 } } },
                {"AMZN", new Stock {Ticker = "AMZN",
                    Data = new StockData{
                        Close = 67, High = 98, Low = 55, NumberOfTransactions = 101, Open = 87, Volume = 467.298, VolumeWeighted = 8679.56 } } },
                {"GOOG", new Stock { Ticker = "GOOG",
                    Data = new StockData{
                        Close = 45, High = 58, Low = 43, NumberOfTransactions = 22, Open = 47, Volume = 456, VolumeWeighted = 8789.56 } } }
            }; */

            Stock response = await _stocksService.GetById(id);

            //Stock response = data[id];

            return Ok(response);
        }
    }
}
