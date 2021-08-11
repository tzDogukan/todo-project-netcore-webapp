using General.Entities;
using Microsoft.EntityFrameworkCore;

namespace General.DataAccess.Concrete.EFCore
{
    public class GeneralSettingsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=todoapp;integrated security=true;MultipleActiveResultSets=true;");
         
            //dotnet tool install --global dotnet-ef   dotnet konsol bozulursa!
        }


        // GENERAL
        public virtual DbSet<userTask> userTask { get; internal set; }


        public virtual DbSet<CreateUserCart> CreateUserCarts { get; internal set; }

        // USER FUNCTIONS
        public virtual DbSet<MyDropBox> MyDropBoxes { get; internal set; }
        public virtual DbSet<MyTask> MyTasks { get; internal set; }
        public virtual DbSet<MyComment> MyComments { get; internal set; }
        public virtual DbSet<UserNotification> UserNotifications { get; internal set; }
        public virtual DbSet<UserAdresList> UserAdresLists { get; internal set; }
        public virtual DbSet<UserContent> UserContents { get; internal set; }
        public virtual DbSet<UserRegisterFile> UserRegisterFiles { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {




        }




    }
}
