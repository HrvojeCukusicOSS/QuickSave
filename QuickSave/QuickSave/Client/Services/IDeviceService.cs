namespace QuickSave.Client.Services
{
    public interface IDeviceService
    {
        List<Device> Devices { get; set; }
        List<User> Users { get; set; }
        Task GetDevices();
        Task GetUsers();
        Task<Device> GetSingleDevice(int id);
    }
}
