using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerFBMarket.Domain.Models;

namespace WarhammerFBMarket.DAL.Interfaces
{
	internal interface IMiniatureRepository: IBaseRepository<Miniature>
	{
		Miniature GetByName(string name);
	}
}
