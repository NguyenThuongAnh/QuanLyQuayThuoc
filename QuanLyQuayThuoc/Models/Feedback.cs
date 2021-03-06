namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        public int fb_id { get; set; }

        [StringLength(30)]
        public string fb_name { get; set; }

        [StringLength(50)]
        public string fb_email { get; set; }

        [StringLength(11)]
        public string fb_phone { get; set; }

        [StringLength(10)]
        public string fb_message { get; set; }

        public DateTime? fb_createDate { get; set; }
    }
}
