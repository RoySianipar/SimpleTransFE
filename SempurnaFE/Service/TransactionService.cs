using SempurnaFE.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace SempurnaFE.Service
{
    public class TransactionService
    {
        private readonly HttpClient _httpClient;

        public TransactionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Transaction>> GetTransactionsAsync(string accountNumber)
        {
            try
            {
                var fullUrl = $"https://localhost:44353/api/Transactions/{accountNumber}";
                var result = await _httpClient.GetFromJsonAsync<List<Transaction>>(fullUrl);
                return result ?? new List<Transaction>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Transaction>();
            }
        }
    }
}
