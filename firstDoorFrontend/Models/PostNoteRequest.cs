using System.ComponentModel.DataAnnotations;

namespace firstDoorFrontend.Models
{
    public record PostNoteRequest
    (
        [MaxLength(500)] string? Body,
        [Required] int SavedJobId
    );
}
