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

        public async Task<bool> Create(Miniature entity)
		{
			await _applicationDbContext.AddAsync(entity);
			await _applicationDbContext.SaveChangesAsync();

			return true; 
		}

		public async Task<bool> Delete(Miniature entity)
		{
			_applicationDbContext.Remove(entity);
			await _applicationDbContext.SaveChangesAsync();

			return true;
		}

		public async Task<Miniature> Get(int id)
		{
			return await _applicationDbContext.Miniature.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<Miniature> GetByName(string name)
		{
			return await _applicationDbContext.Miniature.FirstOrDefaultAsync(x => x.Name == name);
		}

		public Task<List<Miniature>> Select()
		{
			return _applicationDbContext.Miniature.ToListAsync();
		}

	}
}
