using System.ComponentModel.DataAnnotations;

namespace firstDoorFrontend.Models
{
    public class PostNoteRequest
    {
        [MaxLength(500)]
        public string? Body { get; set; } = string.Empty;

        [Required]
        public int Id { get; set; }
    }
}
