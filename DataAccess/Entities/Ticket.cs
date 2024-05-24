using System;
using DataAccess.Records.Bases;

namespace DataAccess.Entities
{
	public class Ticket:Record
	{
		public int id { get; set; }
		public string seatNo { get; set; }
		public string Guid { get; set; }
		public Ticket()
		{
		}
	}
}

