using System;
using System.ComponentModel.DataAnnotations;
using DataAccess.Enums;
using DataAccess.Records.Bases;
#nullable disable
namespace DataAccess.Entities
{
	public class User:Record	 
	{
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role role { get; set; }

        public Sex Sex { get; set; }

        public bool IsVip { get; set; }

        public List<GameUser> GameUsers { get; set; }

        






    }
}

