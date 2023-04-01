using System.ComponentModel.DataAnnotations;
namespace WarhammerFBMarket.Domain.Enum
{
	public enum Fraction		
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
