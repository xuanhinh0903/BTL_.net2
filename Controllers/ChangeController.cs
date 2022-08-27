using Microsoft.AspNetCore.Mvc;

namespace bogshop.Controllers
{
  public class ChangeController : Controller
  {
    public IActionResult PTBN(float a, float b)
    {
      if (Convert.ToBoolean(a))
      {
        if (a != 0)
        {
          ViewBag.Result = $"Phương trình có nghiệm: x = {-b / a}";
        }
        else
        {
          ViewBag.Result = "Phương trình vô nghiệm!";
        }
      }
      return View("PTBN");
    }

    public IActionResult PTBH(float a, float b, float c)
    {
      if (Convert.ToBoolean(a))
      {
        if (a == 0)
        {
          if (b == 0)
          {
            ViewBag.Result = "Phương trình vô nghiệm!";
          }
          else
          {
            ViewBag.Result = $"Phương trình có một nghiệm: x = {-c / b}";
          }
        }
        else
        {
          float delta = b * b - 4 * a * c;
          float x1;
          float x2;
          if (delta > 0)
          {
            x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
            x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
            ViewBag.Result = $"Phương trình có 2 nghiệm là: x1 = {x1}, x2 = {x2}";
          }
          else if (delta == 0)
          {
            x1 = (-b / (2 * a));
            ViewBag.Result = $"Phương trình có nghiệm kép: x1 = x2 = {x1}";
          }
          else
          {
            ViewBag.Result = "Phương trình vô nghiệm!";
          }
        }
      }
      return View("PTBH");
    }

  }
}