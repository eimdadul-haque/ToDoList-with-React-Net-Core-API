using Model.library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace To_Do_Note_Net_Core_5_API.IRepository
{
    public interface INoteRepository
    {
        Task<List<NoteModel>> GetAll();
        Task<NoteModel> GetOne(int? id);
        Task<bool> Add(NoteModel noteModel);
        Task<bool> Edit(NoteModel noteModel);
        Task<bool> Delete(NoteModel noteModel);
    }
}
