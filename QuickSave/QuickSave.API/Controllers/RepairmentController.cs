using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickSave.Persistence.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sindikat.Identity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepairmentsController : ControllerBase
    {
        public RepairmentRepository _repairmentRepository { get; set; }

        public RepairmentsController(RepairmentRepository repairmentRepository)
        {
            _repairmentRepository = repairmentRepository;
        }
        [HttpGet]
        public IActionResult GetRepairments()
        {
            try
            {
                var Repairments = _repairmentRepository.GetRepairments();
                return Ok(Repairments);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(id);
        }
    }
}