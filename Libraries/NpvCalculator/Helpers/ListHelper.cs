using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NpvCalculator.Helpers
{
    public class ListHelper
    {
        public static SelectList TenureLists { get; } = GenerateTenureListItems();

        public static SelectList GenerateTenureListItems()
        {
            List<SelectListItem> tenureListItems = new List<SelectListItem>();

            for (var i = 1; i <= 10; i++)
            {
                tenureListItems.Add(new SelectListItem()
                {
                    Text = i.ToString(),
                    Value = i.ToString()
                });
            }
        
            return new SelectList(tenureListItems, "Value", "Text");
        }


}
}
