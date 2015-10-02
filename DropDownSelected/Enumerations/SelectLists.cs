using System.Collections.Generic;
using System.Web.Mvc;

namespace DropDownSelected.Enumerations
{
    public class SelectLists
    {
        public static IEnumerable<SelectListItem> Title = new[]
        {
            new SelectListItem {Text = "Title", Value = ""},
            new SelectListItem {Text = "Mr", Value = "Mr"},
            new SelectListItem {Text = "Mrs", Value = "Mrs"},
            new SelectListItem {Text = "Miss", Value = "Miss"},
            new SelectListItem {Text = "Ms", Value = "Ms"},
            new SelectListItem {Text = "Dr", Value = "Dr",  Selected = true}
        };
    }
}