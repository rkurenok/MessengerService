namespace MessengerService.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public List<Message>? Messages { get; set; }
    }
}
