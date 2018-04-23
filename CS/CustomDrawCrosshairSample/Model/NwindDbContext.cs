namespace CustomDrawCrosshairSample.Model {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NwindDbContext : DbContext {
        public NwindDbContext()
            : base("name=NwindDbContext") {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

        }
    }
}
