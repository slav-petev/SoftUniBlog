using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SoftUniBlog.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
    }
}