using System;
using DataAccess.Records.Bases;
#nullable disable
namespace DataAccess.Entities
{
	public class GameUser:Record
	{
		public int GameId { get; set; }
		public int UserId { get; set; }

		public Game Game { get; set; }
		public User User { get; set; }
	}
}

