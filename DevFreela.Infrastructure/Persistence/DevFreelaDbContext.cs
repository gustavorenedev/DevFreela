using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevFreela.Infrastructure.Persistence;

public class DevFreelaDbContext : DbContext
{
    public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
    {
        
    }

    public List<Project> Projects { get; set; }
    public List<User> Users { get; set; }
    public List<Skill> Skills { get; set; }
    public List<UserSkill> UserSkills { get; set; }
    public List<ProjectComment> ProjectComments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
    }
}
