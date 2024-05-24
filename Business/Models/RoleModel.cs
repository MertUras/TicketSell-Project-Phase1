using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
	public class RoleModel
	{
        public int Id { get; set; }

      
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishedAt { get; set; }

        public int UserId { get; set; } // Foreign key
    }
}

