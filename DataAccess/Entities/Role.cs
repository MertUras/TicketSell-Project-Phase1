using System;
using System.ComponentModel.DataAnnotations;
using DataAccess.Records.Bases;
#nullable disable
namespace DataAccess.Entities
{
	public class Role:Record
	{
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
       // public int? GameId { get; set; }

        public List<User> Users { get; set; }
        public Game Game { get; set; }
    }
}

