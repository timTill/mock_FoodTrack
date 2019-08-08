using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeTracker.Models
{
	public interface IFridgeFoodRepository
	{
		FridgeFood GetFridgeFood(int Id);
		IEnumerable<FridgeFood> GetAllFridgeFood();
		IEnumerable<FridgeFood> GetFridgeFoodByCateg(int id);
		List<int> GetCountByCategory();
		FridgeFood Add(FridgeFood fridgeFood);
		FridgeFood Update(FridgeFood FridgeFoodChanges);
		FridgeFood Delete(int id);
	}
}
