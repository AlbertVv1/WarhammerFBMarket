using WarhammerFBMarket.Domain.Models;

namespace WarhammerFBMarket.DAL.Interfaces
{
	public interface IMiniatureRepository: IBaseRepository<Miniature>
	{
		Task<Miniature> GetByName(string name);
	}
}
