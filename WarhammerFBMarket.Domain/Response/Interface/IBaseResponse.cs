namespace WarhammerFBMarket.Domain.Response.Interface
{
	public interface IBaseResponse<T>
	{
		public T Data { get; }
	}
}
