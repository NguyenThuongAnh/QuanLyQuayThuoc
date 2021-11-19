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

        public int categorySick_id { get; set; }

        [StringLength(50)]
        public string sick_name { get; set; }

        [StringLength(500)]
        public string sick_learngeneral { get; set; }

        [StringLength(500)]
        public string sick_symptom { get; set; }

        [StringLength(500)]
        public string sick_reason { get; set; }

        [StringLength(500)]
        public string sick_risk { get; set; }

        [StringLength(500)]
        public string sick_treatment { get; set; }

        [StringLength(500)]
        public string sick_livingmode { get; set; }

        public virtual CategorySick CategorySick { get; set; }
    }
}
