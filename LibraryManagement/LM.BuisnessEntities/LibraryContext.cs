using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LM.BuisnessEntities.Mapping;


namespace LM.BuisnessEntities
{
    public class LibraryContext : DbContext
    {
        static LibraryContext()
        {
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
            Database.SetInitializer<LibraryContext>(null);
        }

        public LibraryContext()
            : base("Name=LibraryContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new AuthorMap());
           
        }
    }
}
