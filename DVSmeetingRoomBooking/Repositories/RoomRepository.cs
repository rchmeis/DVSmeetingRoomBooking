using DVSmeetingRoomBooking.Models;
using System.Text.Json;

namespace DVSmeetingRoomBooking.Repositories
{
    public class RoomRepository: IRoomRepository
    {
        private readonly string _filePath= @"/Data/rooms.json";
        private List<Room> _rooms;

        private void LoadFile()
        {
            string json = File.ReadAllText(_filePath);
            _rooms = JsonSerializer.Deserialize<List<Room>>(_filePath);
        }
        private void SaveFile()
        {
            string json = JsonSerializer.Serialize<List<Room>>(_rooms);
            File.WriteAllText(_filePath, json);
        }

        public List<Room> GetAllRooms()
        {
            LoadFile();
            return _rooms;
        }

        public Room GetByID(string id)
        {
            foreach(Room room in _rooms)
            {
                if (room.Id == id)
                {
                    return room;
                }
            }
            return null;
        }

        public void AddRoom(Room room)
        {
            LoadFile();
            _rooms.Add(room);
            SaveFile();
        }

        public void DeleteRoom(string id)
        {
            LoadFile();
            foreach(Room room in _rooms)
            {
                if (room.Id == id)
                {
                    _rooms.Remove(room);
                }
            }
            SaveFile();
        }
        public void UpdateRoom(Room updatedRoom, string id)
        {
            LoadFile();
            foreach(Room room in _rooms)
            {
                if (room.Id == id)
                {                    
                    room.Name = updatedRoom.Name;
                    room.Capacity = updatedRoom.Capacity;
                    room.Description = updatedRoom.Description;
                    room.Equipment = updatedRoom.Equipment;
                }
            }
            SaveFile();

        }
    }
}
