using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using 2 thu vien thiet ke metadata
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSiteBanSach.Models
{
     [MetadataTypeAttribute(typeof(KhachHangMetadata))]
    public partial class KhachHang
    {
         internal sealed class KhachHangMetadata
         {
             [Display(Name = "Mã Khách Hàng")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public int MaKH { get; set; }
             [Display(Name = "Họ và Tên")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public string HoTen { get; set; }
             [DataType(DataType.Date)]
             [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
             [Display(Name = "Ngày Sinh")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public Nullable<System.DateTime> NgaySinh { get; set; }
             [Display(Name = "Giới Tính")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public string GioiTinh { get; set; }
             [Display(Name = "Số Điện Thoại")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public string DienThoai { get; set; }
             [Display(Name = "Tài Khoản")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public string TaiKhoan { get; set; }
             [Display(Name = "Mật Khẩu")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public string MatKhau { get; set; }
             [Display(Name = "Địa Chỉ Email")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public string Email { get; set; }
             [Display(Name = "Địa Chỉ")]//Thuoc tinh display
             [Required(ErrorMessage = "{0} Không được để trống")] // kiểm tra để chống 
             public string DiaChi { get; set; }
         }
    }
}