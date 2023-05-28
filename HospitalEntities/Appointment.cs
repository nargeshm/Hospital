namespace HospitalEntities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentNumber { get; set; }
        public AppointmentMode AppointmentMode { get; set; }
    }
    public enum AppointmentMode
    {
        pending, //wait for accept by Dr.
        done,   //accepted by Dr.
        canceled //patient or Dr. has cancled it
    }
}