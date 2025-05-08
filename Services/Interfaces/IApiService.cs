using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp1.Models;

namespace BlazorApp1.Services.Interfaces;

public interface IApiService
{
    Task<string> RegisterAsync(RegisterDto model);
    Task<string> LoginAsync(LoginDto model);
    Task<List<CardDto>> GetCardsAsync();
    Task<string> AddCardAsync(CardDto card);
    Task<string> DeleteCardAsync(int cardId);
    Task<string> AddOrderAsync(OrderDto order);
    Task<string> EasyTradeAsync(TradeDto trade);
}
