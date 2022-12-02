using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //Console.WriteLine("----------------------UnitPriceMaxMin----------------------");
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //ProductManager productManager1 = new ProductManager(new EfProductDal());
            ////foreach (var product in productManager.GetByUnitPrice(10,50))
            ////{
            ////    Console.WriteLine(product.ProductName);
            ////}
            //Console.WriteLine("----------------------GetByCategoryId----------------------");
            //foreach (var product in productManager1.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.ReadLine();

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
    }
}