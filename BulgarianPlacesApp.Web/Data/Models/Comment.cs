using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulgarianPlacesApp.Web.Data.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

       
        public string Content { get; set; } = null!;



        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;


        [Required]
        public Guid LocationPostId { get; set; }

        [ForeignKey(nameof(LocationPostId))]
        public LocationPost LocationPost { get; set; } = null!;


        [Required]
        public DateTime DateCreated { get; set; }

    }
}