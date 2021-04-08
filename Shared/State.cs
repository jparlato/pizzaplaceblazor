using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
	public class State

	{
		public Menu Menu { get; set; }
		public Basket Basket { get; set; } = new Basket();
		public OptionsUi UI { get; set; } = new OptionsUi();
		public decimal TotalPrice => Basket.Orders.Sum(id => Menu.GetPizza(id).Price);
	}
}
