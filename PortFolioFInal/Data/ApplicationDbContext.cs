using Microsoft.EntityFrameworkCore;

namespace PortFolioFInal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PortFolioFInal.Models.Project> Projects { get; set; }
        public DbSet<PortFolioFInal.Models.Login> Logins { get; set; }
        public DbSet<PortFolioFInal.Models.Skill> Skills { get; set; }

        public DbSet<PortFolioFInal.Models.ContactModel> ContactModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PortFolioFInal.Models.Project>().HasData(
                new PortFolioFInal.Models.Project
                {
                    id = 1,
                    projectName = "Project1",
                    projectDescription = "This is my project1",
                    projectLink = "https://github.com/abc"
                } , 
                new PortFolioFInal.Models.Project
                {
                    id = 2,
                    projectName = "Project2",
                    projectDescription = "This is Project2",
                    projectLink = "https://github.com/abcd"
                } ,
                new PortFolioFInal.Models.Project
                {
                    id = 3,
                    projectName = "Project3",
                    projectDescription = "This is my Project3",
                    projectLink = "https://github.com/abcde"
                }
                );
            modelBuilder.Entity<PortFolioFInal.Models.Login>().HasData(
                new PortFolioFInal.Models.Login
                {
                    id = 1,
                    Email = "",
                    title = "Title1",
                    details = "This is my details1"
                }
                );
            modelBuilder.Entity<PortFolioFInal.Models.Skill>().HasData(
                    new Models.Skill
                    {
                        id = 1,
                        skillName = "C#",
                        level = 5
                    },
                    new Models.Skill
                    {
                        id = 2,
                        skillName = "Python",
                        level = 4
                    },
                    new Models.Skill
                    {
                        id = 3,
                        skillName = "Java",
                        level = 3
                    }

                );
           
        }


    }
}
