namespace MessengerService.Models
{
    public class Message
    {
        public int Id { get; set; }
        public byte[] Сontent { get; set; }
        public DateTime SendTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
