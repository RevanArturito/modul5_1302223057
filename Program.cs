namespace modul5_1302223057
{
    internal class Program
    {
        class Penjumlahan
        {
            
            public void JumlahTigaAngka<T> (T a, T b, T c) 
            {
                dynamic aa = a;
                dynamic bb = b;
                dynamic cc = c;
                Console.WriteLine($"Hasil penjumlahan = {aa + bb + cc}");
            }
        }
        static void Main(string[] args)
        {
            Penjumlahan jumlah = new Penjumlahan();
            // NIM = 1302223057
            int angka1 = 13;
            int angka2 = 02;
            int angka3 = 22;
            jumlah.JumlahTigaAngka(angka1, angka2, angka3);
        }

    }
}
