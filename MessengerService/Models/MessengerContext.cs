using Microsoft.EntityFrameworkCore;

namespace MessengerService.Models
{
    public class MessengerContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Chat> Chats { get; set; }

        public MessengerContext(DbContextOptions<MessengerContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
