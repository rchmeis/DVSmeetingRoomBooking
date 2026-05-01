using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DVSmeetingRoomBooking.Pages
{
    public class IndexModel : PageModel
    {
        
        public IActionResult OnGet()
        {
            
            return RedirectToPage("/Rooms/Index");
        }
    }
}
