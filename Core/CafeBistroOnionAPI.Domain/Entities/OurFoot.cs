using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBistroOnionAPI.Domain.Entities
{
	public class OurFoot
	{
		public int OurDishId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Breakfast { get; set; }
		public string Lunch { get; set; }
		public string Dinner { get; set; }
		public decimal BreakfastPrice { get; set; }
		public decimal LunchPrice { get; set; }
		public decimal DinnerPrice { get; set; }
		public string ImageUrl1 { get; set; }
		public string ImageUrl2 { get; set; }
	}
}
