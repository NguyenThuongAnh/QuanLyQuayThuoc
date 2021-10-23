namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sick")]
    public partial class Sick
    {
        [Key]
        public int sick_id { get; set; }

        [Required]
        [StringLength(50)]
        public string sick_name { get; set; }

        [Column(TypeName = "ntext")]
        public string sick_type { get; set; }

        [Column(TypeName = "ntext")]
        public string sick_reason { get; set; }

        [Column(TypeName = "ntext")]
        public string sick_symptom { get; set; }

        [Column(TypeName = "ntext")]
        public string sick_risk { get; set; }

        [Column(TypeName = "ntext")]
        public string sick_treatment { get; set; }
    }
}
