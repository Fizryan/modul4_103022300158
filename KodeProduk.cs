using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300158
{
    class KodeProduk
    {
        private static Dictionary<String, String> produkList = new Dictionary<string, string>()
        {
            {"Laptop", "E100"},
            {"Smartphone", "E101"},
            {"Tablet", "E102"},
            {"Headset", "E103"},
            {"Keyboard", "E104"},
            {"Mouse", "E105"},
            {"Printer", "E106"},
            {"Monitor", "E107"},
            {"Smartwatch", "E108"},
            {"Kamera", "E109"},
        };

        public static string GetKodeProduk(String produk)
        {
            return produkList.TryGetValue(produk, out string kodeProduk) ? kodeProduk : "Kode Produk tidak ditemukan";
        }
    }
}
