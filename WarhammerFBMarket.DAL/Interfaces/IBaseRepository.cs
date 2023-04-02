using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerFBMarket.Domain.Models;

namespace WarhammerFBMarket.DAL.Interfaces
{
	public interface IBaseRepository<T>
	{
		public Task<bool> Create(T entity);

		public Task<T> Get(int id);

		Task<List<T>> Select();

		Task<bool> Delete(T entity);
	}
}
