using QuanLyQuayThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyQuayThuoc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        QuayThuocModelContext db = new QuayThuocModelContext();
        public ActionResult ViewCategory(int id)
        {
            var listProduct = db.Products.Where(n => n.SmallCategory.category_id == id).ToList();
            return View(listProduct);
        }
        public ActionResult ViewSmallCategory(int id)
        {
            var listProduct1 = db.Products.Where(n => n.smallcategory_id == id).ToList();
            return View(listProduct1);
        }
    }
}