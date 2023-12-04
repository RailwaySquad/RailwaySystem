using Microsoft.AspNetCore.Mvc.Rendering;

namespace Railway_Group01.Models.ViewModels
{
    public class HomeViewModel
    {
        public string SelectedStation { get; set; }
        public List<SelectListItem> StationsSelectList { get; set; }
    }
}
