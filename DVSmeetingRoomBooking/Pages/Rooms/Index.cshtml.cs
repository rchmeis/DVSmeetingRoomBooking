using DVSmeetingRoomBooking.Models;
using DVSmeetingRoomBooking.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DVSmeetingRoomBooking.Pages.Rooms
{
    public class IndexModel : PageModel
    {
        public List<Room> Rooms { get; set; }

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
