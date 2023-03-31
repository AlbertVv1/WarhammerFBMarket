using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerFBMarket.Domain.Enum
{
	public enum Fractions		
	{
		[Display(Name = "Империя")]
		Empire,
		[Display(Name = "Бретония")]
		Bretonnia,
		[Display(Name = "Гномы")]
		Dwarfs,
		[Display(Name = "Высшие эльфы")]
		HighElves,
		[Display(Name = "Лесные эльфы")]
		WoodElves,
		[Display(Name = "Ящеролюды")]
		Lizardmen
	}
}
