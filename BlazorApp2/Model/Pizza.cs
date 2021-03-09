using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Model
{
	public class Pizza
	{
		public Pizza()
		{

		}

		public int PizzaId { get; set; }
		public string Nome { get; set; }

		public decimal PrecoBase { get; set; }

		public string Descricao { get; set; }

		public string ImageUrl { get; set; }

		public string GetPrecoBaseFormato => PrecoBase.ToString("0.00");
	}
}
