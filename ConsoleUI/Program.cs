// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");

ProductManager productManager = new ProductManager(new EfProductDal());

//var result = productManager.GetById(108);

//productManager.Delete(result);

foreach (var products in productManager.GetAll().Data   )
{
    Console.WriteLine(products.ProductId + "  " + products.ProductName);
}
