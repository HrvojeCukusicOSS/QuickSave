using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuickSave.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        
        public static List<Device> devices = new List<Device> { 
            new Device { Id = 1, Type = "Laptop", Brand = "HP", Version = "Pavillion G7", Color = "Black", ProblemSummary = "Screen is black and won't turn on", DateOfArrival = new DateTime(2022, 2, 22), User=users },
            new Device { Id = 2, Type = "Mobile", Brand = "Samsung", Version = "Galaxy S7", Color = "Blue", ProblemSummary = "Home button is not working", DateOfArrival = new DateTime(2022, 2, 24), User=users }
        };
        public static User users = new User
        {
            Id = 1, FirstName="Mate", LastName="Matic", Devices = devices
        };
        /*public static Voucher voucher = new Voucher
        {
            Id = 1,
            Parts = new List<Part> { new Part { Id = 1, Name = "screen", Price = 150, Voucher = voucher, Code = "AI12" } },
            Amount = 400,
            ProblemDescription = "Screen way broken, the display leaked",
            DateOfCompletion = new DateTime(2022, 3, 10),
            DateOfStart = new DateTime(2022, 2, 25),
            Device = devices[0],
            DeviceId = 1,
            Worker = new Worker { Id = 1, FirstName = "Ante", LastName = "Antic" },
            WorkerId=1,
            Payment=new Payment { Id = 1, DateOfPrinting=new DateTime(2022,3,10), DateOfTransaction=new DateTime(2022,3,12), Discount=0, FullAmount=voucher.Amount, IsPaid=true, User=user, UserId=1, Voucher=voucher, VoucherId=1}
        };*/

        [HttpGet]
        public async Task<ActionResult<List<Device>>> GetDevices()
        {
            return Ok(devices);
        }

        [HttpGet]
        [Route("/users")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return Ok(users);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Device>>> GetDevices(int id)
        {
            try
            {
                var device = devices.FirstOrDefault(d => d.Id == id);
                return Ok(device);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
