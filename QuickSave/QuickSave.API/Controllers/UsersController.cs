using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sindikat.Identity.Domain.Models.User;
using Sindikat.Identity.Persistence.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sindikat.Identity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public UserRepository _UserRepository { get; set; }

        public UsersController(UserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _UserRepository.Query().Select(x => BriefModel.MapFrom(x)).ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }
    }
}