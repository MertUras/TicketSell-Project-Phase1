
using System.ComponentModel.DataAnnotations;
using DataAccess.Records.Bases;
#nullable disable
namespace DataAccess.Entities
{
    public class Game : Record
    {
		[Required]
		public string Name { get; set; }

        public decimal Price { get; set; }


        public DateTime Date { get; set; }

        public List<GameUser> GameUsers { get; set; }


    }
}

