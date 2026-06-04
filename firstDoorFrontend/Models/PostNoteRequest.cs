using System.ComponentModel.DataAnnotations;

namespace firstDoorFrontend.Models
{
    public class PostNoteRequest
    {
        [MaxLength(500, ErrorMessage = "The note must be 500 characters or less")]
        public string? Body { get; set; } = string.Empty;

        [Required]
        public int SavedJobId { get; set; }
    }
}
