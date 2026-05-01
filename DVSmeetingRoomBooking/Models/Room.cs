namespace DVSmeetingRoomBooking.Models
{
    public enum Equipment
    {
        Projector,
        Whiteboard,
        Microphone,
        VideoConferencing
    }

    public enum RoomCapacity
    {
        small=25,
        medium=50,
        large=75,
        xlarge=200

    }
    public class Room
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RoomCapacity Capacity{ get; set; }

        public List<Equipment> Equipment { get; set; } = new List<Equipment>();

        public Room()
        {
            Id= Guid.NewGuid().ToString().Substring(0, 8);
        }

        public Room(string id, string name, RoomCapacity capacity, List<Equipment> equipment)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Equipment = equipment;
        }
    }

}
