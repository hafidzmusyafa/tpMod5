using System;

namespace tpmodul5_103022300162
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

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
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Affa"); // Ganti dengan nama Anda

            DataGeneric<string> data = new DataGeneric<string>("103022300162"); // Ganti dengan NIM Anda
            data.PrintData();
        }
    }
}
