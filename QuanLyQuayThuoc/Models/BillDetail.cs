namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        [Key]
        public int billdetail_id { get; set; }

        public int bill_id { get; set; }

        [Required]
        [StringLength(15)]
        public string product_id { get; set; }

        public int? quantity { get; set; }

        public double? price { get; set; }

        public virtual Bill Bill { get; set; }
    }
}
