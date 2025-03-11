using modul4_103022300158;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nama produk: ");
        string produk = Console.ReadLine();

        string kp = KodeProduk.GetKodeProduk(produk);
        Console.WriteLine($"Kode Produk {produk}: {kp}");
    }
}