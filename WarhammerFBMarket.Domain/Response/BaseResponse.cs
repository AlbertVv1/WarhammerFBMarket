using WarhammerFBMarket.Domain.Enum;
using WarhammerFBMarket.Domain.Response.Interface;

namespace WarhammerFBMarket.Domain.Response
{
	public class BaseResponse<T>: IBaseResponse<T>
	{
		public string Description { get; set; }
		public StatusCode StatusCode { get; set; }
		public T Data { get; set; }
	}
}
