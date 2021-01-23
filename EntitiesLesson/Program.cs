using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext northwind = new NorthwindContext();
            #region Listele
            //1. Yöntem
            //using (var northwindContext=new NorthwindContext())
            //{
            //    var ans = northwindContext.Categories.ToList();
            //    foreach (var item in ans)
            //    {
            //        Console.WriteLine(item.CategoryName);
            //    }
            //}
            ////2.Yöntem
            //var categories = northwind.Categories.ToList();
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item.CategoryID);
            //}
            #endregion

            #region Ekleme
            //1.Yöntem
            //using (var northwindContext=new NorthwindContext())
            //{
            //    var categoriess = new Category
            //    {
            //        CategoryName = "test",
            //        Description = "test"
            //    };
            //    northwindContext.Categories.Add(categoriess);
            //    northwindContext.SaveChanges();
            //}
            ////2.Yöntem
            //var category = new Category();
            //category.CategoryName = "test";
            //northwind.Categories.Add(category);
            //northwind.SaveChanges();
            #endregion

            #region Güncelleme
            //using (var northwindContext=new NorthwindContext())
            //{
            //    //1.Yöntem
            //    var res = northwindContext.Categories.Find(12);
            //    res.CategoryName = "test";
            //    northwindContext.SaveChanges();

            //}
            ////2.Yöntem
            //var cst = northwind.Categories.Find(100);
            //cst.CategoryName = "deneme";
            //northwind.SaveChanges();
            #endregion

            #region Silme
            //using (var northwindContext=new NorthwindContext())
            //{
            //    //1.Yöntem
            //    var rst = northwindContext.Categories.Find(100);
            //    northwindContext.Categories.Remove(rst);
            //    northwind.SaveChanges();

            //}
            ////2.Yöntem
            //var cst = northwind.Categories.Find(100);
            //northwind.Categories.Remove(cst);
            //northwind.SaveChanges();
            #endregion

            #region LinQ Sorguları
            #region Hepsini Listeler
            //var result = northwind.Categories.ToList();
            //var rst = from c in northwind.Categories select c;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName+""+item.CategoryID+""+item.Description);
            //}
            //foreach (var item in rst)
            //{
            //    Console.WriteLine(item.CategoryName + "" + item.CategoryID + "" + item.Description);
            //}
            #endregion
            #region Sadece Belirli Alanları çeker
            //var result = northwind.Categories.Select(x => new
            //{
            //    KategoriID = x.CategoryID,
            //    KategoriAdi = x.CategoryName
            //});
            //var rst = from c in northwind.Categories
            //          select new
            //          {
            //              KategoriID = c.CategoryID,
            //              KategoriAdi = c.CategoryName
            //          };
            #endregion
            #region Sadece İlk 2 datayı alma
            //var result = northwind.Categories.Take(2);
            #endregion
            #region OrderBy-OrderByDesc İşlemleri
            //var result = northwind.Categories.OrderBy(x => x.CategoryName);
            //var result = northwind.Categories.OrderByDescending(x => x.CategoryID);
            #endregion
            #region Where Sorgusu
            //var result = northwind.Categories.Where(x => x.CategoryID > 0);
            //var result = northwind.Categories.Where(x => x.CategoryID > 0 || x.CategoryID<10);
            //var result = northwind.Categories.Where(x => x.CategoryID != 0 || x.CategoryID != 10);
            #endregion
            #region Sum-Avg-Min-Max
            //var result = northwind.Categories.Sum(x => x.CategoryID);
            //var result = northwind.Categories.Average(x => x.CategoryID);
            //var result = northwind.Categories.Min(x => x.CategoryID);
            //var result = northwind.Categories.Max(x => x.CategoryID);
            #endregion
            #region String Metod
            //var result = northwind.Categories.Where(x => x.CategoryName.Contains("T"));
            //var result = northwind.Categories.Where(x => x.CategoryName.StartsWith("T"));
            //var result = northwind.Categories.Where(x => x.CategoryName.EndsWith("T"));
            #endregion
            #endregion

            #region LinQ Metodları
            #region OrderBylara devam etmek için thenby ile devam edilir
            //var result = northwind.Products.OrderBy(x => x.CategoryID).ThenBy(x => x.ProductID).Select(x => new
            //{
            //    x.ProductName,
            //    x.ReorderLevel
            //});
            #endregion
            #region Skip,Take Belirli datayı geç ondan sonrası take kadar al.Öncesinde OrderBy Kullanmak zorundayız.
            //var result = northwind.Products.OrderBy(x => x.SupplierID).Skip(4).Take(5).ToList();
            #endregion
            #region All->Hepsine göre şartın uygun olup olmaması durumudur. Uyarsa true Uymazsa False
            //var result = northwind.Products.All(x => x.SupplierID > 0);
            #endregion
            #region Any->Herhangi bir dataya göre şartın uygun olup olmaması durumudur. Uyarsa true Uymazsa False
            //var result = northwind.Products.Any(x => x.SupplierID > 0);
            #endregion
            #region Single->Bir Sonuç Bekleyip birden çok sonuç gelirse hata atar.Sonuç Gelmezse de hata atar.
            //var result = northwind.Products.Single(x => x.SupplierID == 1);
            #endregion
            #region SingleOrDefault->Birden çok sonuç gelirse hata atar.Sonuç gelmezse null döner
            //var result = northwind.Products.SingleOrDefault(x => x.SupplierID == 7);
            #endregion
            #region First->Dönen sonuçun ilk değerini getirir.Sonuç yoksa hata atar
            //var result = northwind.Products.First(x => x.SupplierID == 7);
            #endregion
            #region FirstOrDefault->Dönen Sonucun ilk değerini getirir.Sonuç yoksa null döner
            //var result = northwind.Products.FirstOrDefault(x => x.SupplierID == 7);
            #endregion
            #endregion
            Console.ReadLine();
        }
    }
}
