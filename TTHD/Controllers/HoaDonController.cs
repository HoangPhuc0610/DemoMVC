using Microsoft.AspNetCore.Mvc;
using TTHD.Models;

namespace TTHD.Controllers
{
    public class HoaDonController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int soLuong, double donGia)
        {
            double thanhTien = soLuong * donGia;
            ViewBag.SoLuong = soLuong;
            ViewBag.DonGia = donGia;
            ViewBag.ThanhTien = thanhTien;

            return View();
        }
    }
}
