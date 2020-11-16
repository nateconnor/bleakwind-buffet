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
using System.Transactions;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.CodeAnalysis;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {

        /// <summary>
        /// Gets all the entrees on the menu
        /// </summary>
        public IEnumerable<IOrderItem> Entrees { get; set; } = Menu.Entrees();

        /// <summary>
        /// Gets all the Sides in the Menu
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get; set; } = Menu.Sides();


        /// <summary>
        /// Gets all the drinks in the menu
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get; set; } = Menu.Drinks();
        

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string SearchTerms { get; set; }

        public string[] OrderTypes { get; set; } = new string[0];

        /// <summary>
        /// filters the items when the page is sent a request
        /// </summary>
        /// <param name="SearchTerms"></param>
        /// <param name="OrderTypes"></param>
        /// <param name="calMin"></param>
        /// <param name="calMax"></param>
        /// <param name="priceMin"></param>
        /// <param name="priceMax"></param>
        public void OnGet(string SearchTerms, string[] OrderTypes, int? calMin, int? calMax, double? priceMin, double? priceMax)
       
        {
            if (SearchTerms != null)
            {
                string[] words = SearchTerms.Split(' ');
                for(int i =0; i<words.Length; i++)
                {
                    words[i] = words[i].ToLower();
                }


                //Entrees = Menu.Entrees().Where(item =>  item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
                Entrees = Menu.Entrees().Where(item => words.Any(item.ToString().ToLower().Contains) || words.Any(item.Description.ToLower().Contains));
                Drinks = Menu.Drinks().Where(item => words.Any(item.ToString().ToLower().Contains) || words.Any(item.Description.ToLower().Contains));
                Sides = Menu.Sides().Where(item => words.Any(item.ToString().ToLower().Contains) || words.Any(item.Description.ToLower().Contains));

               // Drinks = Menu.Drinks().Where(item => item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));

               // Sides = Menu.Sides().Where(item => item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
                //DO MULTIPLE WORDS AND DESCRIPTION
            }

            if (OrderTypes != null && OrderTypes.Length != 0)
            {
                Entrees = Entrees.Where(item =>
                    item.Type != null &&
                    OrderTypes.Contains(item.Type)
                    );

                Drinks = Drinks.Where(item =>
                    item.Type != null &&
                    OrderTypes.Contains(item.Type)
                    );

                Sides = Sides.Where(item =>
                    item.Type != null &&
                    OrderTypes.Contains(item.Type)
                    );
            }

            if (calMin != null && calMax != null)
            {
                Entrees = Entrees.Where(item =>
                    item.Calories >= calMin &&
                                        item.Calories <= calMax

                    );
                Drinks = Drinks.Where(item =>
                    item.Calories >= calMin &&
                                        item.Calories <= calMax

                    );
                Sides = Sides.Where(item =>
                    item.Calories >= calMin &&
                                        item.Calories <= calMax

                    );
            }

            if (priceMin != null && priceMax != null)
            {
                Entrees = Entrees.Where(item =>
                    item.Price >= priceMin &&
                                        item.Price <= priceMax

                    );
                Drinks = Drinks.Where(item =>
                    item.Price >= priceMin &&
                                        item.Price <= priceMax

                    );
                Sides = Sides.Where(item =>
                    item.Price >= priceMin &&
                                        item.Price <= priceMax

                    );
            }


            //Entrees = Menu.Search(Menu.Entrees(),SearchTerms);
            //Drinks = Menu.Search(Menu.Drinks(), SearchTerms);
            //Sides = Menu.Search(Menu.Sides(), SearchTerms);

            //Entrees = Menu.FilterByCategory(Entrees, OrderTypes);
            //Drinks = Menu.FilterByCategory(Drinks, OrderTypes);
            //Sides = Menu.FilterByCategory(Sides, OrderTypes);

            //Entrees = Menu.FilterByCalories(Entrees, calMin, calMax);
            //Drinks = Menu.FilterByCalories(Drinks, calMin, calMax);
            //Sides = Menu.FilterByCalories(Sides, calMin, calMax);

            //Entrees = Menu.FilterByPrice(Entrees, priceMin, priceMax);
            //Drinks = Menu.FilterByPrice(Drinks, priceMin, priceMax);

            //Sides = Menu.FilterByPrice(Sides, priceMin, priceMax);


        }


    }
}
