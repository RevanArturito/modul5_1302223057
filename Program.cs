namespace modul5_1302223057
{
    internal class Program
    {
        // membuat class penjumlahan
        class Penjumlahan
        {

            // membuat method JumlahTigaAngka dengan 3 paramter yang sama bertipe generic T
            // menampilkan hasil dari penjumlahan ketiga parameter
            public void JumlahTigaAngka<T>(T a, T b, T c)
            {
                dynamic aa = a;
                dynamic bb = b;
                dynamic cc = c;
                Console.WriteLine($"Hasil penjumlahan = {aa + bb + cc}");
            }
        }

        // membuat class SimpleDataBase
        class SimpleDataBase<T>
        {
            // deklarasi variable stored data dan inputDates
            private List<T> storedData;
            private List<DateTime> inputDates;


            // membuat konstruktor untuk class sesuai dengan kedua atribut sebelumnya
            public SimpleDataBase()
            {
                this.storedData = new List<T>();
                this.inputDates = new List<DateTime>();
            }

            // membuat method get untuk memasukkan data ke dalam storeddata dan inputdates
            public void AddNewData(T data)
            {
                storedData.Add(data);
                inputDates.Add(DateTime.Now);
            }

            // method untuk menampilkan seluruh data dari storedData hingga inputDates
            public void PrintAllData()
            {
                for (int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC {inputDates[i]}");
                }
            }

        }


        static void Main(string[] args)
        {
            // memanggil kembali class penjumlahan untuk menjumlahkan angka1-angka3 dan menampilkan hasilnya
            Penjumlahan jumlah = new Penjumlahan();
            // NIM = 1302223057
            int angka1 = 13;
            int angka2 = 02;
            int angka3 = 22;
            jumlah.JumlahTigaAngka(angka1, angka2, angka3);


            // memanggil kembali class SimpleDataBase untuk menampilkan ketiga data yang telahy diinput (13,02,22)
            SimpleDataBase<int> simple = new SimpleDataBase<int>();
            simple.AddNewData(13);
            simple.AddNewData(02);
            simple.AddNewData(22);
            simple.PrintAllData();
        }
    }
}
