using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerFBMarket.Domain.Enum;

namespace WarhammerFBMarket.Domain.Models
{
	public class Miniature
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Fractions Fraction { get; set; }
		public decimal Price { get; set; }

	}
}
