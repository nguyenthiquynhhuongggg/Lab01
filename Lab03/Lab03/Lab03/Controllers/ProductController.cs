using Microsoft.AspNetCore.Mvc;
public class ProductController : Controller{
    static List<Product> products = new List<Product>()
    {
        new Product { Id = 1, Name = "Product 1", Price = 10.00m },
        new Product { Id = 2, Name = "Product 2", Price = 20.00m },
        new Product { Id = 3, Name = "Product 3", Price = 30.00m }
    };
    public IActionResult Details()
    {
            return View(products);
    }
}