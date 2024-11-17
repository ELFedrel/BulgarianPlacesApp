using System.ComponentModel.DataAnnotations;

namespace BulgarianPlacesApp.Web.Data.Models
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;


        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
    }
}