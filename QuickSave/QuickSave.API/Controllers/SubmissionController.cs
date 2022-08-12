using Microsoft.AspNetCore.Mvc;
using QuickSave.Domain.Entities;
using QuickSave.Persistence.Repository;
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
        [HttpPost]
        [Route("/add")]
        public async Task<ActionResult<Submission>> PostTodoItem(Submission submission)
        {
            _submissionReposioty.Persist(submission);
            await Task.Run(() => _submissionReposioty.FlushAsync());
            return CreatedAtAction(nameof(GetSubmission), new { id = submission.Id }, submission);
        }

        [HttpGet("{id}")]
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
