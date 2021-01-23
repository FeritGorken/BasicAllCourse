using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dictionary Collections
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("Ferit", "Görken");
            keyValuePairs.Add("Spidya", "Software");
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key + " ***** " + item.Value);
            }
            Console.WriteLine(keyValuePairs.ContainsKey("Ferit"));//keyi içeriyor mu
            Console.WriteLine(keyValuePairs.ContainsValue("Görken"));//value içeriyor mu
            Console.WriteLine(keyValuePairs["Ferit"]);//Sadece keyler yazılır
            var res = keyValuePairs.Where(x => x.Key == "Ferit").ToList();
            #endregion
            Console.ReadLine();
        }
    }
}
