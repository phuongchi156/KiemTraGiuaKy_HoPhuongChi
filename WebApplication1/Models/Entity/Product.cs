namespace WebApplication1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
