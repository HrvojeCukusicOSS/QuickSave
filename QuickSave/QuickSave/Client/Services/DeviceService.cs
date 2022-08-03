using System.Net.Http.Json;

namespace QuickSave.Client.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly HttpClient _httpClient;
        public DeviceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Device> Devices { get; set; } = new List<Device>();
        public List<User> Users { get; set; } = new List<User>();

        public async Task GetDevices()
        {
            var devices = await _httpClient.GetFromJsonAsync<List<Device>>("api/device");
            if (devices != null)
            {
                Devices = devices;
            }
        }

        public async Task<Device> GetSingleDevice(int id)
        {
            var device = await _httpClient.GetFromJsonAsync<Device>($"api/device/{id}");
            if (device != null)
                return device;
            throw new Exception("Device not found!");
        }

        public async Task GetUsers()
        {
            var users = await _httpClient.GetFromJsonAsync<List<User>>("api/device/users");
            if (users != null)
            {
                Users = users;
            }
        }
    }
}
