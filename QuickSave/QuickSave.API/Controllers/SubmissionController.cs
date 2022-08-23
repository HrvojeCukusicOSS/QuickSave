using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickSave.Domain.Entities;
using QuickSave.Persistence.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSave.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionController : ControllerBase
    {
        SubmissionRepository _submissionReposioty;
        public SubmissionController(SubmissionRepository submissionRepository)
        {
            _submissionReposioty = submissionRepository;
        }
        [HttpGet]
        public IActionResult GetSubmissions()
        {
            try
            {
                var Submissions = _submissionReposioty.GetSubmissions();
                Submissions = Submissions.OrderByDescending(s => s.DeviceTakeoverDate);
                return Ok(Submissions);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        [Route("/add")]
        public async Task<ActionResult<Submission>> PostSubmission(Submission submission)
        {
            _submissionReposioty.Persist(submission);
            await Task.Run(() => _submissionReposioty.FlushAsync());
            return CreatedAtAction(nameof(GetSubmission), new { id = submission.Id }, submission);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Submission>> GetSubmission(int id)
        {
            var submission = await Task.Run(() => _submissionReposioty.Single(id));

            if (submission == null)
            {
                return NotFound();
            }

            return submission;
        }
    }
}
