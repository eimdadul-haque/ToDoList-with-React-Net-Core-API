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
            return Ok(await _repo.GetAll());
        }

        [HttpPut]
        public async Task<IActionResult> EditNote([FromBody]NoteModel noteModel)
        {
            if (ModelState.IsValid)
            {
                var res = await _repo.Edit(noteModel);
                return Ok(noteModel);
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> AddNote(NoteModel noteModel)
        {
            if (ModelState.IsValid)
            {
                var res = await _repo.Add(noteModel);
                return Ok(noteModel);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote([FromRoute]int? id)
        {
            if (id != null)
            {
                var res =  await _repo.Delete(await _repo.GetOne(id));
                return Ok(await _repo.GetAll());
            }
            return Ok();
        }

    }
}
