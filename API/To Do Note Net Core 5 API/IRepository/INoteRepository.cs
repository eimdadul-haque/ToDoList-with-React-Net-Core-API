using Model.library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace To_Do_Note_Net_Core_5_API.IRepository
{
    public interface INoteRepository
    {
        Task<List<NoteModel>> AllNotes();
        Task<bool> AddNote(NoteModel noteModel);
        Task<bool> EditNote(NoteModel noteModel);
    }
}
