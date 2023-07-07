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
    // public DbSet<Subtask> Subtasks { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=.;User=sa; Password=D3veloper;TrustServerCertificate=True;");
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        byte[] randomSalt1 = RandomNumberGenerator.GetBytes(64);
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
                Status = StatusEnum.Doing,
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
                Status = StatusEnum.Todo,
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
                Status = StatusEnum.Done,
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
                SubtaskID  = 1,
                Status = StatusEnum.Done,
                TaskId = 1,
                Title = "Board Model",
                Issue = "Build out the model for boards",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }, 
            new Subtask
            {
                SubtaskID = 2,
                Status = StatusEnum.Doing,
                TaskId = 1,
                Title = "User Model",
                Issue = "Build out the model for user",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Subtask
            {
                SubtaskID = 3,
                Status = StatusEnum.Todo,
                TaskId = 1,
                Title = "Activity Model",
                Issue = "Build out the activity for boards",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }, 
            new Subtask
            {
                SubtaskID = 4,
                Status = StatusEnum.Done,
                TaskId = 1,
                Title = "Subtask Model",
                Issue = "Build out the Subtask for user",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }
        );
        
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}