﻿using System.ComponentModel.DataAnnotations;

namespace BulgarianPlacesApp.Web.Data.Models
{
    public class LocationPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
    }
}