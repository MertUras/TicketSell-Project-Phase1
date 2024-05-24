
using DataAccess.Records.Bases;

namespace DataAccess.Entities
{
    public class Game : Record
    {
		public int id { get; set; }
		public string Guid { get; set; }
		public string date { get; set; }
		public double price { get; set; }

		public Game()
		{
		}
	}
}

