namespace DVSmeetingRoomBooking.Models
{
    public class Booking
    {
        string BookingID { get; set; }
        string EmployeeId { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        string RoomId { get; set; }
        string Description { get; set; }

        public Booking()
        {
            BookingID = Guid.NewGuid().ToString().Substring(0, 8);
        }

        public Booking(string employeeId, DateTime startTime, DateTime endTime, string roomId, string purpose)
        {
            BookingID = Guid.NewGuid().ToString().Substring(0, 8);
            EmployeeId = employeeId;
            StartTime = startTime;
            EndTime = endTime;
            RoomId = roomId;
            Description = purpose;
        }
    }
}
