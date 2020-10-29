/*
* Author: Nathan Connor
* Class name: Index.cshtml.cs
* Purpose: Model class for the Index page of the Bleakwind Buffet
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {

        /// <summary>
        /// Gets all the entrees on the menu
        /// </summary>
        public IEnumerable<IOrderItem> Entrees
        {
            get
            {
                return Menu.Entrees();
            }
        }

        /// <summary>
        /// Gets all the Sides in the Menu
        /// </summary>
        public IEnumerable<IOrderItem> Sides
        {
            get
            {
                return Menu.Sides();
            }
        }

        /// <summary>
        /// Gets all the drinks in the menu
        /// </summary>
        public IEnumerable<IOrderItem> Drinks
        {
            get
            {
                return Menu.Drinks();
            }
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

    }
}
