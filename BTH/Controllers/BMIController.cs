using Microsoft.AspNetCore.Mvc;

using BMIApp.Models;

namespace BMIApp.Controllers
{
    // [Route("bmi")]
    public class BMIController : Controller
    {

        // [Route("")]
        // [Route("index")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                float bmi = model.CalculateBMI();
                string result = "";

                if (bmi < 18.5)
                    result = "Dưới cân";
                else if (bmi >= 18.5 && bmi < 24.9)
                    result = "Bình thường";
                else if (bmi >= 25 && bmi < 29.9)
                    result = "Thừa cân";
                else
                    result = "Béo phì";

                ViewBag.BMIResult = $"Chỉ số BMI của bạn: {bmi:F2} - {result}";
            }

            return View(model);
        }
    }
}
