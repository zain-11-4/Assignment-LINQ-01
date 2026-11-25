using LINQ.DataSources;
using LINQ.Models;

namespace Assignment_LINQ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            var Seafood = Source.ProductList
                .Where(P => P.Category == "Seafood")
                .Select(S => new { Name = S.ProductName, Price = S.UnitPrice });

            foreach (var item in Seafood)
            {
                Console.WriteLine(item);
            } 
            #endregion

        }
    }
}
