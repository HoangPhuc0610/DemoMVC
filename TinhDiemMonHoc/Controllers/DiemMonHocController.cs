using Microsoft.AspNetCore.Mvc;


namespace TinhDiemMonHoc.Controllers
{
    public class DiemMonHocController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double DiemA, double DiemB, double DiemC, string MonHoc)
        {
            double DiemTongKet = (DiemA * 0.6) + (DiemB * 0.3) + (DiemC * 0.1);
            string ketLuan;

            if (DiemTongKet >= 8.5)
                ketLuan = "Giỏi";
            else if (DiemTongKet >= 7)
                ketLuan = "Khá";
            else if (DiemTongKet >= 5)
                ketLuan = "Trung bình";
            else
                ketLuan = "Yếu";

            ViewBag.MonHoc = MonHoc;
            ViewBag.DiemTongKet = DiemTongKet;
            ViewBag.KetLuan = ketLuan;

            return View();
        }
    }
}
