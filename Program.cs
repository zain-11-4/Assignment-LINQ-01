using LINQ.DataSources;
using LINQ.Models;

namespace Assignment_LINQ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var Seafood = Source.ProductList
            //    .Where(P => P.Category == "Seafood")
            //    .Select(S => new { Name = S.ProductName, Price = S.UnitPrice });

            //foreach (var item in Seafood)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //var P_Name = Source.ProductList
            //    .Select(P => P.ProductName);
            //foreach(var item in P_Name)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            //var Products = Source.ProductList
            //    .Where(P => P.UnitPrice > 10 && P.UnitPrice < 30)
            //    .Select(P => new { name = P.ProductName, id = P.ProductID });
            //foreach(var item in Products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q5
            var inStock = Source.ProductList
                .Where(P => P.UnitsInStock > 0 && P.Category == "Condiments")
                .Select(P => new { name = P.ProductName, id = P.ProductID });
            foreach(var item in inStock)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
