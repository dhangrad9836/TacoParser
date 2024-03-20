namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        //empty constructor
        public TacoBell() { }

        //added methods from ITrackable with public access modifiers
        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
