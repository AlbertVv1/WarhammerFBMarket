using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerFBMarket.DAL.Interfaces
{
	internal interface IBaseRepository<T>
	{
		public bool Create(T entity);

		public T Get(int id);

		IEnumerable<T> Select();

		bool Delete(T entity);
	}
}
