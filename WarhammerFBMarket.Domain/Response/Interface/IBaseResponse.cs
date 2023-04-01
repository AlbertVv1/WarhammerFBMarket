namespace WarhammerFBMarket.Domain.Response.Interface
{
	internal interface IBaseResponse<T>
	{
		public T Data { get; }
	}
}
