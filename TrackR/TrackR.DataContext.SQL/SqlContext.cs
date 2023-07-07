using System.Security.Cryptography;
using Controller;
using Microsoft.EntityFrameworkCore;
using TrackR.Models.SQL;

namespace TrackR.DataContext.SQL;

public partial class SqlContext : DbContext
{
    public SqlContext()
    {
    }

    public SqlContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Board> Boards { get; set; } = null!;
    public DbSet<Activity> Tasks { get; set; } = null!;
    public DbSet<Subtask> Subtasks { get; set; } = null!;
    public DbSet<Section> Sections { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=.;User=sa; Password=D3veloper;TrustServerCertificate=True;");
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        byte[] randomSalt1 = RandomNumberGenerator.GetBytes(64);
        
        modelBuilder.Entity<Subtask>()
            .HasOne(s => s.Parent)
            .WithMany(a => a.Subtasks)
            .HasForeignKey(s => s.TaskId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>().HasData(
            
            new User
            {
                UserId = 1,
                FirstName = "Joseph",
                LastName = "Huntley",
                Email = "Joseph.Huntley@outlook.com",
                Salt = randomSalt1,
                Password = Password.HashPassword("D3veloper", randomSalt1),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }
        );

        modelBuilder.Entity<Board>().HasData(
            new Board
            {
                BoardId = 1,
                Name = "TrackR",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }
        );

        modelBuilder.Entity<Activity>().HasData(
            new Activity
            {
                ActivityId = 1,
                SectionId = 2,
                BoardId = 1,
                UserId = 1,
                Title = "Build SQL Data Models",
                Issue = "Build the data models for SQL database",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Activity
            {
                ActivityId = 12,
                SectionId = 1,
                BoardId = 1,
                UserId = 1,
                Title = "Build View",
                Issue = "Build the frontend in blazor",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Activity
            {
                ActivityId = 3,
                SectionId = 3,
                BoardId = 1,
                UserId = 1,
                Title = "Build SQL Data Context",
                Issue = "Build the db context for SQL database",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }
        );

        modelBuilder.Entity<Subtask>().HasData(
            new Subtask
            {
                SubtaskId  = 1,
                SectionId = 3,
                TaskId = 1,
                Title = "Board Model",
                Issue = "Build out the model for boards",
                Completed = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }, 
            new Subtask
            {
                SubtaskId = 2,
                SectionId = 2,
                TaskId = 1,
                Title = "User Model",
                Issue = "Build out the model for user",
                Completed = false,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Subtask
            {
                SubtaskId = 3,
                SectionId = 1,
                TaskId = 1,
                Title = "Activity Model",
                Issue = "Build out the activity for boards",
                Completed = false,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }, 
            new Subtask
            {
                SubtaskId = 4,
                SectionId = 3,
                TaskId = 1,
                Title = "Subtask Model",
                Issue = "Build out the Subtask for user",
                Completed = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }
        );

        modelBuilder.Entity<Section>().HasData(
                new Section
                {
                    SectionId = 1,
                    Name = "TODO",
                    Position = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Section
                {
                    SectionId = 2,
                    Name = "Doing",
                    Position = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },new Section
                {
                    SectionId = 3,
                    Name = "Done",
                    Position = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
        );

    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}