using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoNET.Models;

namespace CursoNET.Controllers
{
    public class VideoGenresController : Controller
    {

        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: VideoGenres
        public ActionResult Index(string filter)
        {
            IEnumerable<VideoGenre> videoGenres;
            if (filter == null)
            {
                videoGenres = _db.VideoGenres;
            }
            else
            {
                videoGenres = _db.VideoGenres.Where(v => v.Name.Contains(filter));
            }


            return View(videoGenres);
        }
    }
}