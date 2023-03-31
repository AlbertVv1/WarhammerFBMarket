using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerFBMarket.DAL.Interfaces;
using WarhammerFBMarket.Domain.Models;

namespace WarhammerFBMarket.DAL.Repositories
{
	public class MiniatureRepository : IMiniatureRepository
	{
		private readonly ApplicationDbContext _applicationDbContext;

        public MiniatureRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public bool Create(Miniature entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(Miniature entity)
		{
			throw new NotImplementedException();
		}

		public Miniature Get(int id)
		{
			throw new NotImplementedException();
		}

		public Miniature GetByName(string name)
		{
			throw new NotImplementedException();
		}

		public Task<List<Miniature>> Select()
		{
			return _applicationDbContext.Miniature.ToListAsync();
		}

		IEnumerable<Miniature> IBaseRepository<Miniature>.Select()
		{
			throw new NotImplementedException();
		}
	}
}
