using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArtApi.Models;

namespace ArtApi.Controllers
{
    public class Artist : Controller
    {
        private readonly ArtistContext _context;

        public Artist(ArtistContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind("ID,Name,Country,Art")] ArtApi.Models.Artist artist
        )
        {
            _context.Add(artist);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult<IList<Models.Artist>>> Index()
        {
            return await _context.Artist.ToListAsync();
//            return View(await _context.Artist.ToListAsync());
        }
    }
}