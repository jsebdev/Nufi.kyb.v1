using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nufi.kyb.v1.Pages
{
    public class GeneralModel : PageModel
    {
		public string createName(string a, string b)
		{
			return a + b;
		}
        public void OnGet()
        {
        }
    }
}
