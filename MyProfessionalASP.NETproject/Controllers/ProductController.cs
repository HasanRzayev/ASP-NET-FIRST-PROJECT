using Microsoft.AspNetCore.Mvc;
using MyProfessionalASP.NETproject.Models;

namespace MyProfessionalASP.NETproject.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new()
        {
            new Product{Name= "Uludag limonata ",  Description="Meyve suyu",Price= 10 },
            new Product{Name= "Kola "  ,  Description=  "Icki", Price= 15 },
            new Product{Name= "Fanta " ,   Description= "Icki",Price=  5 },
            new Product{Name= "Uludag limonata ",   Description= "Meyve suyu",Price=  10 },
            new Product{Name= "Kola " ,   Description= "Icki",Price=  15 },
            new Product{Name= "Fanta ",  Description=  "Icki",Price=  5 },
            new Product{Name= "Uludag limonata ",    Description="Meyve suyu",Price=  10 },
            new Product{Name= "Kola ",   Description= "Icki",Price=  15 },
            new Product{Name= "Fanta ",   Description= "Icki",Price=  5 },
    };

        public int number { get; set; }
        public ProductController()
        {
          
        }
        public IActionResult All()
        {
            ViewBag.number = number;
            return View(products);
        }

     
        public IActionResult Delete() { 
            return View(); 
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int number)
        {
            if(number>=0 && number<products.Count())
            {

               
                products.RemoveAt(number);
            }
            return RedirectToAction("All");
        }
        [HttpPost, ActionName("Add")]
        public IActionResult Add(Product product)
        {
            if(product.Name!=null && product.Description!=null && product.Price != null)
            {
                products.Add(product);
                
            }
            return RedirectToAction("Add");
        }
    }
}
