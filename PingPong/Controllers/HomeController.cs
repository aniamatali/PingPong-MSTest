using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PingPong.Models;

namespace PingPong.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/pingpong/results")]
      public ActionResult Results()
      {
        PingPonger.ClearAll();
        PingPonger pingpong = new PingPonger (int.Parse(Request.Form["inputNumber"]));
        return View (pingpong.GetList());
      }
      [HttpPost("/")]
      public ActionResult Clear()
      {
        PingPonger.ClearAll();
        return View();
      }
    }
}
