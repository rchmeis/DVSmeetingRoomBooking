using DVSmeetingRoomBooking.Models;

namespace DVSmeetingRoomBooking.Repositories
{
    public interface IRoomRepository    
    {
        public void AddRoom(Room room);
        public List<Room> GetAllRooms();
        public Room GetById(string id);
        public void UpdateRoom(Room updatedRoom, string id);
        public void DeleteRoom(string id);
    }
}
