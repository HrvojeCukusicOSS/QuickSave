using QuickSave.Domain.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace QuickSave.Frontend.Services
{
    public class RepairmentService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44345/api/repairment";
        public RepairmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Repairment>> GetRepairments()
        {
            return await _httpClient.GetFromJsonAsync<List<Repairment>>(BaseApiUrl);
        }
    }
}
