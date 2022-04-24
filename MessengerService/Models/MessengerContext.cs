using Microsoft.EntityFrameworkCore;

namespace MessengerService.Models
{
    public class MessengerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }

        public MessengerContext(DbContextOptions<MessengerContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            // добавляем роли и пользователей
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = 1, Email = "admin@mail.com", Name = "admin", Password = "123456", RoleId = adminRole.Id };
            User simpleUser = new User { Id = 2, Email = "roma@mail.com", Name = "Roma", Password = "123456", RoleId = userRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser, simpleUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
