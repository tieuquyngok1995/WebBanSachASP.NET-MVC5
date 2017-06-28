using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using 2 thu vien thiet ke metadata
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSiteBanSach.Models
{
    [MetadataTypeAttribute(typeof(SachMetadata))]
    public partial class Sach
    {
        internal sealed class SachMetadata
        {
            [Display(Name = "Mã Sách")]//Thuoc tinh display
            [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
            public int MaSach { get; set; }
            [Display(Name = "Tên Sách")]//Thuoc tinh display
            [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
            public string TenSach { get; set; }
            [Display(Name = "Giá Bán")]//Thuoc tinh display
            [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
            public Nullable<decimal> GiaBan { get; set; }
            [Display(Name = "Mô Tả")]//Thuoc tinh display
            [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
            public string MoTa { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            [Display(Name = "Ngày Cập Nhập")]//Thuoc tinh display
            [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
            public Nullable<System.DateTime> NgayCapNhat { get; set; }
            [Display(Name = "Ảnh Bìa")]//Thuoc tinh display

            public string AnhBia { get; set; }
            [Display(Name = "Số Lượng Tồn")]//Thuoc tinh display
            [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
            public Nullable<int> SoLuongTon { get; set; }
            [Display(Name = "Mã Chủ Đề")]//Thuoc tinh display
            public Nullable<int> MaChuDe { get; set; }
            [Display(Name = "Mã Nhà Xuất Bản")]//Thuoc tinh display  
            public Nullable<int> MaNXB { get; set; }
            [Display(Name = "Mới")]//Thuoc tinh display
            [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
            public Nullable<int> Moi { get; set; }


        }
    }
}