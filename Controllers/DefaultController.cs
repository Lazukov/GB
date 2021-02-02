using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebGB.Models;

namespace WebGB.Controllers
{
    public class DefaultController : Controller
    {

       

        public IActionResult Index()
        {
            return View("Default");
        }

    



        //Default/Shop
        public IActionResult Shop()
        {
            return View("Shop");
        }

        //Default/Blog
        public IActionResult Blog()
        {
            return View("Blog");
        }


        //Default/Blog_Single
        public IActionResult Blog_Single()
        {
            return View("Blog_Single");
        }


        //Default/Cart
        public IActionResult Cart()
        {
            return View("Cart");
        }

        //Default/CheckOut
        public IActionResult CheckOut()
        {
            return View("CheckOut");
        }

        //Default/Contact_Us
        public IActionResult Contact_Us()
        {
            return View("Contact_Us");
        }

        //Default/Login
        public IActionResult Login()
        {
            return View("Login");
        }

        //Default/Product_Details
        public IActionResult Product_Details()
        {
            return View("Product_Details");
        }

        //Default/Error
        public IActionResult Error()
        {
            return View("Error");
        }



    }
}