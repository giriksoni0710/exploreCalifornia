using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace exploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {

        private readonly BlogDataClass _db;

        public BlogController(BlogDataClass db) {

            _db = db;
        }
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray();
            return View(posts);
        }
        [Route(@"{year:min(2000)}/{month:Range(1,12)}/{Key}")]
        public IActionResult Post(int year, int month, string Key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Girik Soni",
                Body = "This is my programming blog"

            };
            return View(post);
        }
        [HttpGet, Route("create")]
        public IActionResult CreateForm() {

            return View();

        }

        [HttpPost, Route("create")]
        public IActionResult CreateForm(Post post)
        {
            if (!ModelState.IsValid)
                return View();

                post.Author = User.Identity.Name;
                post.Posted = DateTime.Now;
               
                _db.Posts.Add(post);
                _db.SaveChanges();

            return RedirectToAction("Post", "Blog", new
            {

                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.key

            }); 

        }

        //public class CreatePostRequest{
        
        //    public string Title {get; set;}
        //    public string Body {get; set;}
            
        //}
    }
}
