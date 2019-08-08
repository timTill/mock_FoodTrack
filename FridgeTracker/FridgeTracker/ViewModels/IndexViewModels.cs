using FridgeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeTracker.ViewModels
{
	public class IndexViewModel
	{
		public IEnumerable<FridgeFood> fridgeFoodList { get; set; }
		public Array Categories { get; set; }
		public int tagNumber { get; set; }
		public List<int> CountByCateg { get; set; }	
	}
}
