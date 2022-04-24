namespace MessengerService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[]? Avatar { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Message>? Messages { get; set; }
        public ICollection<Chat>? Chats { get; set; }
    }
}
