using Data.library.Data;
using Microsoft.EntityFrameworkCore;
using Model.library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using To_Do_Note_Net_Core_5_API.IRepository;

namespace To_Do_Note_Net_Core_5_API.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDbContext _db;

        public NoteRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<List<NoteModel>> AllNotes()
        {
            return (await _db.noteModels.ToListAsync());
        }

        public async Task<bool> AddNote(NoteModel noteModel)
        {
            if (noteModel != null)
            {
                await _db.noteModels.AddAsync(noteModel);
                await _db.SaveChangesAsync();
            }

            return true;
        }


        public async Task<bool> EditNote(NoteModel noteModel)
        {
            if (noteModel != null)
            {
                _db.noteModels.Update(noteModel);
                await _db.SaveChangesAsync();
            }

            return true;
        }

    }
}
