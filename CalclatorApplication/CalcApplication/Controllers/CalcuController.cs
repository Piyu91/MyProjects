using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalcApplication.Models;

namespace CalcApplication.Controllers
{
    public class CalcuController : Controller
    {
        // GET: Calcu
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public int sum([Bind(Include = "Num1,Num2")]NumbersInp nums)
        {
            nums.Answer = nums.Num1 + nums.Num2;
            return nums.Answer;
        }


        [HttpPost]
        public int subsytraction([Bind(Include = "Num1,Num2")]NumbersInp nums)
        {
            nums.Answer = nums.Num1 - nums.Num2;
            return nums.Answer;
        }

        [HttpPost]
        public int multiplication([Bind(Include = "Num1,Num2")]NumbersInp nums)
        {
            nums.Answer = nums.Num1 * nums.Num2;
            return nums.Answer;
        }

        [HttpPost]
        public int division([Bind(Include = "Num1,Num2")]NumbersInp nums)
        {
            if(nums.Num2 == 0)
            {
                return 0;
            }
            nums.Answer = nums.Num1 / nums.Num2;
            return nums.Answer;
        }


    }
}