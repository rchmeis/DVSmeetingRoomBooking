using DVSmeetingRoomBooking.Models;
using DVSmeetingRoomBooking.Repositories;

namespace DVSmeetingRoomBooking.Services
{
    public class RoomService
    {
        public List<Room> Rooms;
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;            
        }

        public void AddRoom(Room room)
        {
            _roomRepository.AddRoom(room);
        }

        public List<Room> GetAllRooms()
        {
            Rooms = _roomRepository.GetAllRooms();
            return Rooms; 
        }

        public Room GetById(string id)
        {
            return _roomRepository.GetById(id);
        }
        public void DeleteRoom(string id)
        {
            _roomRepository.DeleteRoom(id);
        }
        public void UpdateRoom(Room updatedRoom, string id)
        {
            _roomRepository.UpdateRoom(updatedRoom, id);
        }
    }
}
