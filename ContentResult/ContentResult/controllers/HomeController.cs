﻿using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ContentResultExamples.controllers
{
    public class HomeController :Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("home")]
        [Route("/")]

        public ContentResult Index()
        {
            // return new ContentResult() { Content="Hello From Index",ContentType="text/Plain"};
            /*            return Content("Hello From Index","text/Plain");*/
            return Content("<div style='text-align:center'><h2 style='color:red;'>Welcome</h2> <h3>Hello from Index</h3></div>","text/html");
        }

        [Route("about")]

        public string About()
        {
            return "Hello From About";
        }

        [Route("contact-us/{mobile:regex(^\\d{{11}}$)}")]

        public string Contact()
        {
            return "Hello From Contact";
        }
    }
}