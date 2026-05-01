using DVSmeetingRoomBooking.Models;
using DVSmeetingRoomBooking.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DVSmeetingRoomBooking.Pages.Rooms
{
    public class CreateRoomModel : PageModel
    {       

        [BindProperty]
        public Room Room { get; set; }

        private readonly RoomService _roomService;      

        public CreateRoomModel(RoomService roomservice)
        {
            _roomService = roomservice;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _roomService.AddRoom(Room); ViewData["confirmation"] = $"you have successfully created {Room}";
            return Redirect("/Index");
        }

        //Later: make the onpost method return the room, so it displays on the site and the person can see what they added. Give them an option to edit or delete the room
    }
}
