using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Models;
using ShopAPI.Data;


namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly ApiContext _context;

        public ShopController(ApiContext context)
        {
            _context = context;

        }

        //dodawanie do bazy
        [HttpPost("Add")]
        public JsonResult Add(Product product)
        {
            if (product.id == 0)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return new JsonResult(new { success = true, message = "Produkt został dodany do bazy danych." });
            }
            else
            {
                var existingProduct = _context.Products.FirstOrDefault(p => p.id == product.id);
                if (existingProduct != null)
                {
                    return new JsonResult(new { success = false, message = "Produkt o ID: "+product.id+" już istnieje w bazie danych." });
                }
                else
                {
                    return new JsonResult(new { success = false, message = "Baza danych posiada autoinkrementacje ID. Nie mozna dodac produktu o podanym przez siebie ID! Aby dodac nowy produkt, w polu ID wpisz wartosc 0" });
                }
            }
        }

        //edycja
        [HttpPost("Edit")]
        public JsonResult Edit(Product product)
        {
            if (product.id == 0)
            {
                return new JsonResult(new { success = false, message = "Nie można edytowac produktu o id=0, poniewaz taki produkt nie istanieje! ID=0 służy do dodawania produktów" });
            }
            else
            {
                var productInDataBase = _context.Products.Find(product.id);

                if (productInDataBase == null)
                {
                    return new JsonResult(new { success = false, message = "Produkt o ID: " + product.id + " nie istnieje!" });
                }
                else
                {
                    productInDataBase.NazwaProduktu = product.NazwaProduktu;
                    productInDataBase.DataUtworzenia = product.DataUtworzenia;
                    productInDataBase.DataEdycji = product.DataEdycji;
                    productInDataBase.OpisArtykulu = product.OpisArtykulu;
                    productInDataBase.Cena = product.Cena;
                    _context.SaveChanges();
                    return new JsonResult(new { success = true, message = "Poprawnie zmodyfikowano produkt o id: "+ product.id});
                }
            }
        }

        //pobranie pojedynczego elementu
        [HttpGet("GetOne")]
        public JsonResult GetOne(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return new JsonResult(new { success = false, message = "Produkt o ID: "+ id + " nie istnieje!"});
            }
            else
            {
                return new JsonResult(Ok(product));
            }
        }

        //pobranie calej listy
        [HttpGet("GetAll")]
        public JsonResult GetAll()
        {
            var products = _context.Products.ToList();
            return new JsonResult(products);
        }

        //usuwanie z bazy jednego elementu
        [HttpPost("Delete")]
        public JsonResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return new JsonResult(new { success = false, message = "Produkt o ID: " + id + " nie istnieje!" });
            }
            else
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return new JsonResult(new { success = true, message = "Poprawnie usunięto produkt o id: " + id });
            }
        }
    }
}