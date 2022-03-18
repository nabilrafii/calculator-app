using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace CalculatorAnggaYota21114517 {  
    class Program {  
        static void Main(string[] args) {  
            Console.WriteLine("Enter the action to be performed");  
            Console.WriteLine("Ketik 1 untuk penjumlahan");  
            Console.WriteLine("Ketik 2 untuk pengurangan");  
            Console.WriteLine("Ketik 3 untuk perkalian");  
            Console.WriteLine("Ketik 4 for pembagian \n");  
            int action = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("masukkan angka ke 1 =");  
            int masukan_1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("masukkan angka ke 2 =");  
            int masukan_2 = Convert.ToInt32(Console.ReadLine());  
            int hasil = 0;  
            switch (action) {  
                case 1: {  
                    hasil = Penambahan(masukan_1, masukan_2);  
                    break;  
                }  
                case 2: {  
                    hasil = Pengurangan(masukan_1, masukan_2);  
                    break;  
                }  
                case 3: {  
                    hasil = Perkalian(masukan_1, masukan_2);  
                    break;  
                }  
                case 4: {  
                    hasil = Pembagian(masukan_1, masukan_2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Perintah salah!! coba sekali lagi");  
                    break;  
            }  
            Console.WriteLine("Hasilnya adalah =  {0}", hasil);  
            Console.ReadKey();  
        }  
        //Penjumlahan  
        public static int Penambahan(int masukan_1, int masukan_2) {  
            int hasil = masukan_1 + masukan_2;  
            return hasil;  
        }  
        //Pengurangan  
        public static int Pengurangan(int masukan_1, int masukan_2) {  
            int hasil = masukan_1 + masukan_2;  
            return hasil;  
        }  
        //Perkalian
        public static int Perkalian(int masukan_1, int masukan_2) {  
            int hasil = masukan_1 + masukan_2;  
            return hasil;  
        }  
        //Pembagian
        public static int Pembagian(int masukan_1, int masukan_2) {  
            int hasil = masukan_1 + masukan_2;  
            return hasil;  
        }  
    }  
}