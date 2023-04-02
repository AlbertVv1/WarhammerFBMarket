using WarhammerFBMarket.Domain.Models;
using WarhammerFBMarket.Domain.Response;

namespace WarhammerFBMarket.BL.Interfaces
{
	public interface IMiniatureBL
	{
		public Task<BaseResponse<IEnumerable<Miniature>>> GetMiniatures();
	}
}
