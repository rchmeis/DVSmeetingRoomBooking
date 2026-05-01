using DVSmeetingRoomBooking.Models;
using DVSmeetingRoomBooking.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DVSmeetingRoomBooking.Pages.Rooms
{
    public class IndexModel : PageModel
    {
        public List<Room> Rooms { get; set; } = new List<Room>(); //initialize list! the constructer runs before OnGet and that will cause the program to crash.

        private readonly RoomService _roomservice;
        public IndexModel(RoomService roomservice)
        {
            _roomservice = roomservice;            
        }
        public void OnGet()
        {
            Rooms = _roomservice.GetAllRooms();
        }
    }
}
