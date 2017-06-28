using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;

namespace WebSiteBanSach.Controllers
{
    public class NguoiDungController : Controller
    {
        //
        // GET: /NguoiDung/
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult Index()
        {
            return View();
        }
         [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
         [HttpPost]
        // [ValidateAntiForgeryToken]
         public ActionResult DangKy(KhachHang kh)
         {
             if (ModelState.IsValid)
             {
                 //Chèn dữ liệu vào bảng khách hàng
                 db.KhachHangs.Add(kh);
                 //Lưu vào csdl 
                 db.SaveChanges();
                 Session["TaiKhoan"] = kh;
                 Session["HoTen"] = kh.HoTen;
             }
             return View();
         }
         [HttpGet]
         public ActionResult DangNhap()
         {

             return View();
         }
         [HttpPost]
         public ActionResult DangNhap(FormCollection f)
         {
             string sTaiKhoan = f["txtTaiKhoan"].ToString();
             string sMatKhau = f.Get("txtMatKhau").ToString();
             KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == sTaiKhoan && n.MatKhau == sMatKhau);
             if (kh != null)
             {
                 ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công !";
                 Session["TaiKhoan"] = kh;
                 Session["HoTen"] = kh.HoTen;
                 return Redirect("/");
             }
             ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng!";
             return View();
         }
         public ActionResult DangXuat()
         {
             Session["TaiKhoan"] = null;
             Session["HoTen"] = null;
             return Redirect("/");

         }
         public ActionResult HuyGioHang()
         {
             
             Session["GioHang"] = null;
             return Redirect("/");

         }
	}
}