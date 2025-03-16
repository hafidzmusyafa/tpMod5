using System;

namespace tpmodul5_NIM
{
    class DataGeneric<T>
    {
        public T Data { get; private set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<string> data = new DataGeneric<string>("103022300162"); // Ganti dengan NIM Anda
            data.PrintData();
        }
    }
}
