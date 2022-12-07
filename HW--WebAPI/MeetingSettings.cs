namespace HW__WebAPI
{
    public class MeetingSettings
    {
        public DateTime Date { get; set; }
        public int MaxPeople { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsRecording { get; set; }
    }
}
