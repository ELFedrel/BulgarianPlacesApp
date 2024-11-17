﻿using Azure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulgarianPlacesApp.Web.Data.Models
{
    public class LocationPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        
        public string Title { get; set; } = null!;

        [Required]
        
        public string Description { get; set; } = null!;

        [Required]
        public string PhotoURL { get; set; } = null!;


        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<FavoriteViews> Favorites { get; set; } = new List<FavoriteViews>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}