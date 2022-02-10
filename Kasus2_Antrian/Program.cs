using System;
using System.Collections;
namespace Kasus2_Antrian
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Hashtable ht = new Hashtable();

                        ht.Add("001", " Net ");
                        ht.Add("002", "C#");
                        ht.Add("003", "ASP.net");


                        Console.WriteLine(ht.ContainsKey("001"));
                        Console.WriteLine(ht.ContainsValue("C#"));

                        ICollection keys = ht.Keys;

                        foreach (String k in keys)
                        {
                        Console.WriteLine(ht[k]);
                        }

                        Console.ReadKey();*/
            Console.WriteLine("--------DAFTAR MINUMAN ESKUY-------");
            Console.WriteLine("Daftar Minuman :");
            Console.WriteLine("1.Teh Anget Oreo");
            Console.WriteLine("2.Teh Redvelvet");
            Console.WriteLine("3.Jus Teh");
            Console.WriteLine("4.Es Jahe");
            Console.WriteLine("");
            Queue Pembeli_Es = new Queue();
            Console.WriteLine("Jumlah pembeli yang antri membeli Minuman di Cafe ESKUY ada :");
            Pembeli_Es.Enqueue("Jari");
            Pembeli_Es.Enqueue("Juru");
            Pembeli_Es.Enqueue("Jeri");
            Pembeli_Es.Enqueue("Joro");
            foreach(var element in Pembeli_Es)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine($"Jumlah pembeli yang antri ada = {Pembeli_Es.Count}");
            Console.WriteLine("");
            Console.WriteLine($"Minuman Teh Anget Oreo dengan nama {Pembeli_Es.Dequeue()}");
            Console.WriteLine($"Jari silahkan untuk segera mengambil pesanannya");
            Console.WriteLine($"Antrian Selanjutnya {Pembeli_Es.Peek()} ");
            Console.WriteLine("");
            
            Console.WriteLine($"Minuman Jus Teh dengan nama {Pembeli_Es.Dequeue()}");
            Console.WriteLine($"Juru silahkan untuk segera mengambil pesanannya");
            Console.WriteLine($"Antrian Selanjutnya {Pembeli_Es.Peek()} ");
            Console.WriteLine("");

            Console.WriteLine($"Minuman Teh Redvelvet dengan nama {Pembeli_Es.Dequeue()}");
            Console.WriteLine($"Jeri silahkan untuk segera mengambil pesanannya");
            Console.WriteLine($"Antrian Selanjutnya {Pembeli_Es.Peek()} ");
            Console.WriteLine("");

            Console.WriteLine($"Minuman Es Jahe dengan nama {Pembeli_Es.Dequeue()}");
            Console.WriteLine($"Joro silahkan untuk segera mengambil pesanannya");
            Console.WriteLine($"Pesanan sudah selesai");
            Console.WriteLine("Thank You Very mUch");




        }
    }
}

//inisialisasi Queue
//Queue Antrian_Pasien = new Queue();
//Console.WriteLine("Daftar Pasien :");
//Antrian_Pasien.Enqueue("Pasien 1");
//Antrian_Pasien.Enqueue("Pasien 2");
//Antrian_Pasien.Enqueue("Pasien 3");
//Antrian_Pasien.Enqueue("Pasien 4");
//Antrian_Pasien.Enqueue("Pasien 5");
//foreach (var element in Antrian_Pasien)
//{Console.WriteLine(element);}
//Console.WriteLine($"Jumlah pasien saat ini = {Antrian_Pasien.Count}");
//Console.WriteLine($"Pasien dipanggil ! {Antrian_Pasien.Dequeue()}");
//Console.WriteLine($"Jumlah pasien saat ini = {Antrian_Pasien.Count}");
//Console.WriteLine($"Antrian Selanjutnya {Antrian_Pasien.Peek()} ");
