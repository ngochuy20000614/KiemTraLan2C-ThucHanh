namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietThanhVien")]
    public partial class ChiTietThanhVien
    {
        [Key]
        [StringLength(15)]
        public string MaSinhVien { get; set; }

        public int MaLSH { get; set; }

        [Required]
        [StringLength(15)]
        public string SoDienThoai { get; set; }

        public bool? goiTinh { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        public virtual LopSinhVien LopSinhVien { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
