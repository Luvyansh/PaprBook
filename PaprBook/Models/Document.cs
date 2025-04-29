using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaprBook.Models
{
    public class Document
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public Microsoft.AspNetCore.Identity.IdentityUser? User { get; set; }
    }
}