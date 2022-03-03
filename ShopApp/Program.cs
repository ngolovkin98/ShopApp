using System;
using TransactionLibrary;
using System.Data.SqlClient;
using System.Threading;


namespace ShopApp
{
    class Program
    {

        public static string ReturnConnectionString()
        {
            // Необходимо задать строку подключения к БД для корректной работы!
            shopStorage.connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nikit\source\repos\ShopApp\ShopApp\Database.mdf;Integrated Security=True";
            return shopStorage.connectionString;
        }
        static void Main(string[] args)
        {
            ThreadStart threadTransaction = new ThreadStart(Reserve1);
            ThreadStart threadTransaction2 = new ThreadStart(Reserve2);
            ThreadStart threadTransaction3 = new ThreadStart(Reserve3);
            ThreadStart threadTransaction4 = new ThreadStart(Reserve4);
            ThreadStart threadTransaction5 = new ThreadStart(Reserve5);
            ThreadStart threadTransaction6 = new ThreadStart(Reserve6);
            ThreadStart threadTransaction7 = new ThreadStart(Reserve7);
            ThreadStart threadTransaction8 = new ThreadStart(Reserve8);
            ThreadStart threadTransaction9 = new ThreadStart(Reserve9);
            ThreadStart threadTransaction10 = new ThreadStart(Reserve10);
            Thread thread = new Thread(threadTransaction);
            Thread thread2 = new Thread(threadTransaction2);
            Thread thread3 = new Thread(threadTransaction3);
            Thread thread4 = new Thread(threadTransaction4);
            Thread thread5 = new Thread(threadTransaction5);
            Thread thread6 = new Thread(threadTransaction6);
            Thread thread7 = new Thread(threadTransaction7);
            Thread thread8 = new Thread(threadTransaction8);
            Thread thread9 = new Thread(threadTransaction9);
            Thread thread10 = new Thread(threadTransaction10);
            thread.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();
            thread9.Start();
            thread10.Start();


        }
        public static void Reserve1()
        {
                int userId = 1;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
                for (int j = 1; j < 100; j++) 
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve2()
        {
            int userId = 2;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve3()
        {
            int  userId = 3;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve4()
        {
            int  userId = 4;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve5()
        {
            int  userId = 5;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve6()
        {
            int  userId = 6;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve7()
        {
            int  userId = 7;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve8()
        {
            int  userId = 8;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve9()
        {
            int userId = 9;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        public static void Reserve10()
        {
            int userId = 10;
            Random rnd = new Random();
            int orderSize = rnd.Next(1, 4);
            ReturnConnectionString();
            shopStorage shop = new shopStorage();
            for (int j = 1; j < 100; j++)
                shop.Reserve("IPhone", orderSize, userId);
        }
        
    }
}
