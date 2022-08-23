using QuickSave.Domain.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuickSave.Frontend.Services
{
    public class SubmissionService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44345/api/submission";
        public SubmissionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Submission>> GetSubmissions()
        {
            return await _httpClient.GetFromJsonAsync<List<Submission>>(BaseApiUrl);
        }
        public async Task AddSubmissionAsync(Submission Submission)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(Submission), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Submission> GetSubmissionAsync(int submissionId)
        {
            return await _httpClient.GetFromJsonAsync<Submission>($"{BaseApiUrl}/{submissionId}");
        }
    }
}
