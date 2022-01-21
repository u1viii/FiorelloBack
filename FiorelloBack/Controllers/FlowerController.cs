using FiorelloBack.DAL;
using FiorelloBack.Models;
using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloBack.Controllers
{
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public FlowerController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index(int page=1)
        {

            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Flowers.Count() / 1);
            
            List<Flower> model = _context.Flowers.Include(f=>f.FlowerCategories).ThenInclude(fc=>fc.Category).Include(f=>f.Campaign).Include(f=>f.FlowerImages).Skip((page - 1)*1).Take(1).ToList();
            return View(model);
        }

        public IActionResult Details(int id,int categoryId)
        {

            Flower flower = _context.Flowers.Include(f => f.Campaign).Include(f => f.FlowerCategories).ThenInclude(fc => fc.Category).Include(f => f.FlowerTags).ThenInclude(ft => ft.Tag).Include(f => f.FlowerImages).Include(f=>f.Comments).ThenInclude(c=>c.AppUser).FirstOrDefault(f => f.Id == id);
            if (flower == null) return NotFound();
            ViewBag.RelatedFlowers = _context.Flowers.Include(f=>f.FlowerImages).Include(f=>f.Campaign).Include(f=>f.FlowerCategories).Where(f => f.FlowerCategories.FirstOrDefault().CategoryId == categoryId && f.Id != id).OrderByDescending(f=>f.Id).Take(4).ToList();



            return View(flower);
        }
        [Authorize]
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment) 
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Details","Flower",new { id = comment.FlowerId });
            if (!_context.Flowers.Any(f => f.Id == comment.FlowerId)) return NotFound();
            Comment cmnt = new Comment
            {
                Text = comment.Text,
                FlowerId = comment.FlowerId,
                CreatedTime = DateTime.Now,
                AppUserId = user.Id
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("Details","Flower",new { id = comment.FlowerId });
        }
        [Authorize]
        public async Task<IActionResult> DeleteComment(int id) 
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Index", "Flower");
            if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c=>c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Details","Flower",new { id = comment.FlowerId });
        }

        #region Session

        //public IActionResult setSession(int id)
        //{
        //    Flower flower = _context.Flowers.FirstOrDefault(f => f.Id == id);

        //    HttpContext.Session.SetString("Session", flower.Name);

        //    return RedirectToAction("Index", "Home");
        //}
        //public IActionResult ShowSession()
        //{
        //    var basket = HttpContext.Session.GetString("Session");
        //    return Content(basket);
        //}

        #endregion


        #region Cookie

        //public IActionResult SetCookie(int id)
        //{
        //    Flower flower = _context.Flowers.FirstOrDefault(f => f.Id == id);

        //    HttpContext.Response.Cookies.Append("Cookie", flower.Name);
        //    return RedirectToAction("Index", "Home");
        //}

        //public IActionResult ShowCookie()
        //{
        //    return Content(HttpContext.Request.Cookies["Cookie"]);
        //}
        //public IActionResult DeleteCookie(string key)
        //{
        //    HttpContext.Response.Cookies.Delete(key);
        //    return RedirectToAction("Index", "Home");
        //}

        #endregion

        public IActionResult AddBasket(int id)
        {
            Flower flower = _context.Flowers.Include(f=>f.Campaign).FirstOrDefault(f => f.Id == id);

            string basket = HttpContext.Request.Cookies["Basket"];

            if(basket == null)
            {
                List<BasketCookieItemVM> basketCookieItems = new List<BasketCookieItemVM>();

                basketCookieItems.Add(new BasketCookieItemVM
                {
                    Id = flower.Id,
                    Count = 1
                });



                //BasketVM basketVM = new BasketVM
                //{
                //    BasketItems = new List<BasketItemVM>(),
                //    TotalPrice = 0,
                //    Count = 1
                //};

                //BasketItemVM basketItem = new BasketItemVM
                //{
                //    Flower = flower,
                //    Count = 1
                //};
                //basketVM.BasketItems.Add(basketItem);
                //if(flower.CampaignId == null)
                //{
                //    basketVM.TotalPrice = flower.Price;
                //}
                //else
                //{
                //    basketVM.TotalPrice = flower.Price * (100 - flower.Campaign.DiscountPercent) / 100;
                //}
                //Math.Round(basketVM.TotalPrice, 3);
                
                string basketStr = JsonConvert.SerializeObject(basketCookieItems);
                

                HttpContext.Response.Cookies.Append("Basket", basketStr);
            }
            else
            {
                List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                BasketCookieItemVM cookieItem = basketCookieItems.FirstOrDefault(c => c.Id == flower.Id);

                if(cookieItem == null)
                {
                    cookieItem = new BasketCookieItemVM
                    {
                        Id = flower.Id,
                        Count = 1
                    };
                    basketCookieItems.Add(cookieItem);
                }
                else
                {
                    cookieItem.Count++;
                }


                //BasketVM basketVM = JsonConvert.DeserializeObject<BasketVM>(basket);
                //BasketItemVM basketItem = basketVM.BasketItems.FirstOrDefault(i => i.Flower.Id == flower.Id);
                //if(basketItem == null)
                //{
                //    basketItem = new BasketItemVM
                //    {
                //        Flower = flower,
                //        Count = 1
                //    };
                //    basketVM.Count++;
                //    basketVM.BasketItems.Add(basketItem);
                //}
                //else
                //{
                //    basketItem.Count++;
                //}
                //if (flower.CampaignId == null)
                //{
                //    basketVM.TotalPrice += basketItem.Flower.Price;
                //}
                //else
                //{
                //    basketVM.TotalPrice += basketItem.Flower.Price * (100 - basketItem.Flower.Campaign.DiscountPercent) / 100;
                //}
                string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                HttpContext.Response.Cookies.Append("Basket", basketStr);

            }
            
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowBasket()
        {
            string basketStr = HttpContext.Request.Cookies["Basket"];
            if (!string.IsNullOrEmpty(basketStr))
            {
                List<BasketCookieItemVM> basket = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basketStr);
                return Json(basket);
            }
            return Content("Basket is empty");
        }

        public IActionResult SearchResult(string Name,int? CategoryId)
        {
            List<Flower> flowers = new List<Flower>();
            if (CategoryId != null)
            {
                flowers = _context.Flowers.Where(f => f.Name.ToLower().Contains(Name.ToLower()) && f.FlowerCategories.FirstOrDefault().CategoryId == CategoryId).Include(f => f.FlowerCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.FlowerImages).ToList();
            }
            else
            {
                flowers = _context.Flowers.Where(f => f.Name.ToLower().Contains(Name.ToLower())).Include(f => f.FlowerCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.FlowerImages).ToList();
            }
            ViewBag.SearchName = Name;
            ViewBag.Categories = _context.Categories.ToList();
            return View(flowers);
        }
    }
}
