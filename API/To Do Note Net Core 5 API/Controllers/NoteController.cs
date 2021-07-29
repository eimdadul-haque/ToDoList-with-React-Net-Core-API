using Microsoft.AspNetCore.Mvc;
using Model.library.Models;
using System.Threading.Tasks;
using To_Do_Note_Net_Core_5_API.IRepository;

namespace To_Do_Note_Net_Core_5_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly INoteRepository _repo;
        public NoteController(INoteRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNotes()
        {
            return Ok(await _repo.AllNotes());
        }

        [HttpPost]
        public async Task<IActionResult> AddNote(NoteModel noteModel)
        {
            if (ModelState.IsValid)
            {
                var res = await _repo.AddNote(noteModel);
            }
            return Ok(noteModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditNote(NoteModel noteModel)
        {
            if (ModelState.IsValid)
            {
                var res = await _repo.EditNote(noteModel);
            }
            return Ok(noteModel);
        }

    }
}
