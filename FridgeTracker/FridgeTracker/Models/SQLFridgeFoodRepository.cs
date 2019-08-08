using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeTracker.Models
{
	public class SQLFridgeFoodRepository : IFridgeFoodRepository
	{
		private readonly AppDbContext context;

		public SQLFridgeFoodRepository(AppDbContext context)
		{
			this.context = context;
		}
		public FridgeFood Add(FridgeFood fridgeFood)
		{
			context.FridgeFoods.Add(fridgeFood);
			context.SaveChanges();
			return fridgeFood;
		}

		public FridgeFood Delete(int id)
		{
			FridgeFood ff = context.FridgeFoods.Find(id);
			if (ff != null)
			{
				context.FridgeFoods.Remove(ff);
				context.SaveChanges();
			}
			return ff;
		}

		public IEnumerable<FridgeFood> GetAllFridgeFood()
		{
			return context.FridgeFoods;
		}

		public List<int> GetCountByCategory()
		{
			List<int> CountbyCateg = new List<int>();
			var enumCount = Enum.GetNames(typeof(Category)).Length;
			var foodGroups = context.FridgeFoods.GroupBy(ff => ff.Category).ToList();
			int FoodGroupPtr = 0;
			for (int i = 0; i < enumCount; i++)
			{
				if (i == (int)foodGroups[FoodGroupPtr].Key)
				{
					CountbyCateg.Add(foodGroups[FoodGroupPtr].Count());
					if (FoodGroupPtr < foodGroups.Count() - 1)
					{
						FoodGroupPtr++;
					}
				}
				else
				{
					CountbyCateg.Add(0);
				}
			}

			/*
			var result = context.FridgeFoods.GroupBy(ff => (int)ff.Category)
									.Select(group => new
									{	Category = group.Key,
										Count = group.Count()}).
									OrderBy(ff => ff.Category).ToList();						

			for (int i = 0; i < enumCount; i++)
			{
				bool added = false;
				for (int j = 0; j < result.Count; j++)
				{
					if (result[j].Category > i)
					{
						break;
					}
					else if (result[j].Category == i)
					{
						CountbyCateg.Add(result[j].Count);
						added = true;
						break;
					}
				}
				if (!added)
				{
					CountbyCateg.Add(0);
				}
			}
			*/
			return CountbyCateg;
		}

		public FridgeFood GetFridgeFood(int Id)
		{
			return context.FridgeFoods.Find(Id);
		}

		public IEnumerable<FridgeFood> GetFridgeFoodByCateg(int id)
		{
			return context.FridgeFoods.Where(ff => (int)ff.Category == id);
		}

		public FridgeFood Update(FridgeFood FridgeFoodChanges)
		{
			var ff = context.FridgeFoods.Attach(FridgeFoodChanges);
			ff.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
			return FridgeFoodChanges;
		}
	}
}
