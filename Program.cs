using modul4_103022300158;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nama produk: ");                                    // Print Permintaan Input Produk
        string produk = Console.ReadLine();                                         // Input Produk

        string kp = KodeProduk.GetKodeProduk(produk);                               // Mencari Produk di List KodeProduk
        Console.WriteLine($"Kode Produk {produk}: {kp}");                           // Print Hasil Pencarian Produk
    }
}