using System.ComponentModel.DataAnnotations;

namespace Model.library.Models
{
    public class NoteModel
    {
        public int Id { get; set; }

        [Required]
        public string Note { get; set; }
    }
}
