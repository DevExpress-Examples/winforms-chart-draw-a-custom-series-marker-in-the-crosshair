namespace CustomDrawCrosshairSample.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderID { get; set; }

        [Column("EmployeeId")]
        public int? EmployeeId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }

        public decimal? Freight { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
