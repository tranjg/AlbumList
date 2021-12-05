using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlbumList.Models;

namespace AlbumList.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        
=======
        private AlbumContext context { get; set; }

        public HomeController(AlbumContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
         var albums = context.Albums;
            return View(albums);
        }
>>>>>>> ConnectionString
    }
}
