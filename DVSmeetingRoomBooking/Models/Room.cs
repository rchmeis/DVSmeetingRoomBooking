namespace DVSmeetingRoomBooking.Models
{
    public enum Equipment
    {
        Projector,
        Whiteboard,
        Microphone,
        VideoConferencing
    }
    public class Room
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        
        public List<Equipment> Equipment { get; set; }

        public Room()
        {
            Id= Guid.NewGuid().ToString().Substring(0, 8);
        }

        public Room(string id, string name, int capacity, List<Equipment> equipment)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Equipment = equipment;
        }
    }

}
