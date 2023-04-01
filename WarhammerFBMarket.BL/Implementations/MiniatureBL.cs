using WarhammerFBMarket.BL.Interfaces;
using WarhammerFBMarket.DAL.Interfaces;
using WarhammerFBMarket.Domain.Enum;
using WarhammerFBMarket.Domain.Models;
using WarhammerFBMarket.Domain.Response;

namespace WarhammerFBMarket.BL.Implementations
{
	public class MiniatureBL : IMiniatureBL
	{
		private readonly IMiniatureRepository _miniatureRepository;

		public MiniatureBL(IMiniatureRepository miniatureRepository)
		{
			_miniatureRepository = miniatureRepository;
		}

		public async Task<BaseResponse<IEnumerable<Miniature>>> GetMiniatures()
		{
			var baseResponse = new BaseResponse<IEnumerable<Miniature>>();

			try
			{
				var miniatures = _miniatureRepository.Select();

				baseResponse.Data = await miniatures;
				baseResponse.StatusCode = StatusCode.Success;

				return baseResponse;
			}
			catch (Exception ex)
			{
				return new BaseResponse<IEnumerable<Miniature>>()
				{
					Description = $"[GetMiniatures:] {ex.Message}"
				};
			}
		}
	}
}
