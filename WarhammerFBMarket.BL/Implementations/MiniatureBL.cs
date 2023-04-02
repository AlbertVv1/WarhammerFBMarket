using WarhammerFBMarket.BL.Interfaces;
using WarhammerFBMarket.DAL.Repositories;
using WarhammerFBMarket.Domain.Enum;
using WarhammerFBMarket.Domain.Models;
using WarhammerFBMarket.Domain.Response;

namespace WarhammerFBMarket.BL.Implementations
{
	public class MiniatureBL : IMiniatureBL
	{
		private readonly MiniatureRepository _miniatureRepository;

		public MiniatureBL(MiniatureRepository miniatureRepository)
		{
			_miniatureRepository = miniatureRepository;
		}

		public async Task<BaseResponse<Miniature>> GetMiniature(int id)
		{
			var baseResponse = new BaseResponse<Miniature>();
			try
			{
				var miniature = await _miniatureRepository.Get(id);

				if (miniature == null)
				{
					baseResponse.Description = "Not found";
					baseResponse.StatusCode = StatusCode.Error;
					return baseResponse;
				}

				baseResponse.StatusCode = StatusCode.Success;
				baseResponse.Data = miniature;

				return baseResponse;
			}
			catch (Exception ex)
			{
				return new BaseResponse<Miniature>()
				{
					Description = $"[GetMiniatures:] {ex.Message}"
				};
			}
		}

		public async Task<BaseResponse<bool>> CreateMiniature(int id)
		{
			var baseResponse = new BaseResponse<bool>();

			try
			{
				var miniature = await _miniatureRepository.Get(id);

				if (miniature == null)
				{
					baseResponse.Description = "Not found";
					baseResponse.StatusCode = StatusCode.Error;
					return baseResponse;
				}
				baseResponse.StatusCode = StatusCode.Success;
				await _miniatureRepository.Create(miniature);

				return baseResponse;
			}
			catch (Exception ex)
			{
				return new BaseResponse<bool>()
				{
					Description = $"[GetMiniatures:] {ex.Message}"
				};
			}
		}

		public async Task<BaseResponse<bool>> DeleteMiniature(int id)
		{
			var baseResponse = new BaseResponse<bool>();

			try
			{
				var miniature = await _miniatureRepository.Get(id);

				if (miniature == null)
				{
					baseResponse.Description = "Not found";
					baseResponse.StatusCode = StatusCode.Error;
					return baseResponse;
				}
				baseResponse.StatusCode = StatusCode.Success;
				await _miniatureRepository.Delete(miniature);

				return baseResponse;
			}
			catch (Exception ex)
			{
				return new BaseResponse<bool>()
				{
					Description = $"[GetMiniatures:] {ex.Message}"
				};
			}
		}

		public async Task<BaseResponse<Miniature>> GetMiniatureByName(string name)
		{
			var baseResponse = new BaseResponse<Miniature>();
			try
			{
				var miniature = await _miniatureRepository.GetByName(name);

				if (miniature == null)
				{
					baseResponse.Description = "Not found";
					baseResponse.StatusCode = StatusCode.Error;
					return baseResponse;
				}
				baseResponse.StatusCode = StatusCode.Success;
				baseResponse.Data = miniature;
				return baseResponse;
			}
			catch (Exception ex)
			{
				return new BaseResponse<Miniature>()
				{
					Description = $"[GetMiniatures:] {ex.Message}"
				};
			}
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
