namespace HobbyTracker.Entities
{
    public class Session : IEntity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public float Duration { get; set; }
        public Guid HobbyId { get; set; }

        public Session(Guid hobbyId)
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
        }
    }
}
