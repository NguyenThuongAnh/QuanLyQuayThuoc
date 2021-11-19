namespace QuanLyQuayThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string user_name { get; set; }

        [Required]
        [StringLength(50)]
        public string user_password { get; set; }

        [Required]
        [StringLength(50)]
        public string user_email { get; set; }
    }
}
