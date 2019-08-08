using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeTracker.Models
{
	public class MockFridgeFoodRepository : IFridgeFoodRepository
	{
		private List<FridgeFood> _fridgeFoodList;
		public MockFridgeFoodRepository()
		{
			_fridgeFoodList = new List<FridgeFood>()
			{
				new FridgeFood()
					{ ID=1,
					Name ="Soproni Ászok",
					BestBefore =new DateTime(2019,08,11),
					Category = Category.Alkoholos_italok,
					Unit = 5,
					Measurement = MeasType.dl
				},
				new FridgeFood()
					{ ID=2,
					Name ="Banán",
					BestBefore =new DateTime(2019,08,05),
					Category = Category.Zoldseg_gyomolcs,
					Unit = 5,
					Measurement = MeasType.db
				},
				new FridgeFood()
					{ ID=3,
					Name ="Téli",
					BestBefore =new DateTime(2019,08,07),
					Category = Category.Hus_felvagott,
					Unit = 25,
					Measurement = MeasType.dkg
				},
				new FridgeFood()
					{ ID=4,
					Name ="Dreher",
					BestBefore =new DateTime(2019,08,02),
					Category = Category.Alkoholos_italok,
					Unit = 10,
					Measurement = MeasType.dl
				},
				new FridgeFood()
					{ ID=5,
					Name ="Csabai",
					BestBefore =new DateTime(2019,08,02),
					Category = Category.Hus_felvagott,
					Unit = 12,
					Measurement = MeasType.l
				}
			};
		}
		public FridgeFood Add(FridgeFood fridgeFood)
		{
			fridgeFood.ID = _fridgeFoodList.Max(ff => ff.ID) + 1;			
			_fridgeFoodList.Add(fridgeFood);			
			return fridgeFood;
		}

		public FridgeFood Delete(int id)
		{
			FridgeFood ff = _fridgeFoodList.FirstOrDefault(f => f.ID == id);
			if (ff != null)
			{
				_fridgeFoodList.Remove(ff);
			}
			return ff;
		}

		public IEnumerable<FridgeFood> GetAllFridgeFood()
		{
			return _fridgeFoodList;
		}

		public List<int> GetCountByCategory()
		{
			List<int> CountbyCateg = new List<int>();
			var categories = Enum.GetValues(typeof(Category));
			var enumCount = Enum.GetNames(typeof(Category)).Length;
			for (int i = 0; i < enumCount; i++)
			{
				CountbyCateg.Add(
				_fridgeFoodList.Where(ff => (int)ff.Category == i).Count());
			}
			return CountbyCateg;

		}

		public FridgeFood GetFridgeFood(int Id)
		{
			return _fridgeFoodList.FirstOrDefault(ff => ff.ID == Id);
		}

		public IEnumerable<FridgeFood> GetFridgeFoodByCateg(int id)
		{
			return _fridgeFoodList.Where(ff => (int)ff.Category == id);
		}

		public FridgeFood Update(FridgeFood fridgeFoodChanges)
		{
			FridgeFood OldFF = GetFridgeFood(fridgeFoodChanges.ID);
			OldFF.Name = fridgeFoodChanges.Name;
			OldFF.BestBefore = fridgeFoodChanges.BestBefore;
			OldFF.Category = fridgeFoodChanges.Category;
			OldFF.Unit = fridgeFoodChanges.Unit;
			OldFF.Measurement = fridgeFoodChanges.Measurement;
			return fridgeFoodChanges;
		}
	}
}