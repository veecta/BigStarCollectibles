using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStarCollectiblesWebApp.Pages
{
	public class BuyRobotsModel : PageModel
	{
		public BuyRobotsModel()
		{
			this.MonsterCards = new Models.CardSource().CardsOrderedByName;
		}
	
		public void OnGet()
		{

		}
		public List<Models.CollectableCard> MonsterCards { get; set; }
	}
}
