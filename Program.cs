namespace modul5_1302223057
{
    internal class Program
    {
        class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;

            public SimpleDataBase()
            {
                this.storedData = new List<T>();    
                this.inputDates = new List<DateTime>();
            }

            public void AddNewData(T data)
            {
                storedData.Add(data);
                inputDates.Add(DateTime.Now);
            }

            public void PrintAllData()
            {
                for (int i = 0; i < storedData.Count;i++)
                {
                    Console.WriteLine($"Data {i+1} berisi: {storedData[i]}, yang disimpan pada waktu UTC {inputDates[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            SimpleDataBase<int> simple = new SimpleDataBase<int>();
            simple.AddNewData(13);
            simple.AddNewData(02);
            simple.AddNewData(22);
            simple.PrintAllData();
            
        }
    }
}
