using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BulgarianPlacesApp.Web.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? ProfilePictureURL { get; set; }

        
        public string? Bio { get; set; }

        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
        public ICollection<FavoriteViews> Favorites { get; set; } = new List<FavoriteViews>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
