using DVSmeetingRoomBooking.Models;
using System.Text.Json;

namespace DVSmeetingRoomBooking.Repositories
{
    public class RoomRepository: IRoomRepository
    {
        private readonly string _filePath;
        private List<Room> _rooms;

        public RoomRepository(IWebHostEnvironment webHost)
        {
            _filePath = Path.Combine(webHost.ContentRootPath, "Data", "rooms.json");
        }
        private void LoadFile()
        {
            if (!File.Exists(_filePath)) //this makes sure the program doesnt crash if the file doesnt exist.
            {
                _rooms = new List<Room>();
                return;
            }

            try
            {
                string json = File.ReadAllText(_filePath);

                //The ?? operator ensures that whats on the right happens, if the left is null
                _rooms = JsonSerializer.Deserialize<List<Room>>(json) ?? new List<Room>();
            }
            catch (JsonException)
            {
                // If the JSON is garbled/broken, don't crash; just start with an empty list
                _rooms = new List<Room>();
            }
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

        public Room GetById(string id)
        {
            foreach (Room room in _rooms)
            {
                if (room.Id == id)
                {
                    return room;
                }
            }
            return null;
        }
    }
}
