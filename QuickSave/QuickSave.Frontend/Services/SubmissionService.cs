using QuickSave.Domain.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuickSave.Frontend.Services
{
    public class SubmissionService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44345/api/Flight";
        public SubmissionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Submission>> GetSubmissions()
        {
            return await _httpClient.GetAsync<List<Submission>>(BaseApiUrl);
        }
    }
}
