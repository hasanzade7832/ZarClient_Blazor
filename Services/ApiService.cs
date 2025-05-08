using System.Net.Http;
using System.Net.Http.Json;
using BlazorApp1.Models;
using BlazorApp1.Services.Interfaces;
using BlazorApp1.Helpers;

namespace BlazorApp1.Services;

public class ApiService : IApiService
{
    private readonly HttpClient _http;

    public ApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<string> RegisterAsync(RegisterDto model)
    {
        var response = await _http.PostAsJsonAsync(ApiEndpoints.Register, model);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> LoginAsync(LoginDto model)
    {
        var response = await _http.PostAsJsonAsync(ApiEndpoints.Login, model);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<List<CardDto>> GetCardsAsync()
    {
        var data = await _http.GetFromJsonAsync<List<CardDto>>(ApiEndpoints.GetCards);
        return data ?? new List<CardDto>();
    }

    public async Task<string> AddCardAsync(CardDto card)
    {
        var response = await _http.PostAsJsonAsync(ApiEndpoints.AddCard, card);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> DeleteCardAsync(int cardId)
    {
        var response = await _http.DeleteAsync(ApiEndpoints.DeleteCard(cardId));
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> AddOrderAsync(OrderDto order)
    {
        var response = await _http.PostAsJsonAsync(ApiEndpoints.AddOrder, order);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> EasyTradeAsync(TradeDto trade)
    {
        var response = await _http.PostAsJsonAsync(ApiEndpoints.EasyTrade, trade);
        return await response.Content.ReadAsStringAsync();
    }
}
