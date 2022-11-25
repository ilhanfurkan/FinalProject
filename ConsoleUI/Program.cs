using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------UnitPriceMaxMin----------------------");
            ProductManager productManager = new ProductManager(new EfProductDal());
            ProductManager productManager1 = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetByUnitPrice(10,50))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            Console.WriteLine("----------------------GetByCategoryId----------------------");
            foreach (var product in productManager1.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}