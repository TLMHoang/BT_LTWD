using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Program
    {
        static void Mang1Chieu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\tMẢNG 1 CHIỀU \n\n\n");
            Console.WriteLine("Dộ dài mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] M = new int[n];
            //1. Nhập giá trị ngẫu nhiên:
            Random rd = new Random();
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rd.Next(100);
            }

            // Nhap Tay
            //for (int i = 0; i < M.Length; i++)
            //{
            //    Console.WriteLine("Vi trí thứ {0}", i);
            //    M[i] = int.Parse(Console.ReadLine());
            //}
            //2. Xuất các giá trị trong mảng:
            Console.WriteLine("Mảng ngẫu nhiên là:");
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + "   ");
            }
            //3. Đảo mảng
            Array.Reverse(M);
            Console.WriteLine("\nMảng sau khi đảo chiều là:");
            foreach (int i in M)
            {
                Console.Write(i + "   ");
            }
            //4. Sắp xếp mảng:
            Array.Sort(M);
            Console.WriteLine("\nMảng sau khi sắp xếp là:");
            foreach (int i in M)
            {
                Console.Write(i + "   ");
            }
            //5. tổng mảng:
            int sum = 0;
            foreach (int x in M)
            {
                sum += x;
            }
            Console.WriteLine("\nTổng mảng = {0}", sum);
            //6. Tìm kiếm trong mảng
            Console.WriteLine("Nhập số tìm:");
            int k = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(M, k);
            if (kq < 0)
            {
                Console.WriteLine("Không tìm thấy {0} trong mảng", k);
            } 
            else
            {
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}", k, kq);
            }
            //7. tìm theo tuyến tính
            Console.WriteLine("Mời bạn nhập vào số muốn tìm:");
            k = int.Parse(Console.ReadLine());
            kq = -1;
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] == k)
                {
                    kq = i;
                    break;
                }
            }
            if (kq < 0)
            {
                Console.WriteLine("Không tìm thấy {0} trong mảng", k);
            }
            else
            {
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}", k, kq);
            }

            Console.Write("Nhập Phím bất kỳ để tiếp tuc");
            Console.ReadKey();
        }

        static void Mang2Chieu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\tMẢNG 1 CHIỀU \n\t\t\t\t\tVới Kich thước MxN\n\n\n");
            Console.WriteLine("Nhập M :");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào số cột :");
            int N = int.Parse(Console.ReadLine());
            // Nhap mảng random
            int[,] Arr = new int[M, N];
            Random rd = new Random();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] = rd.Next(100);
                }
            }

            //Nhập mảng bằng tay
            //for (int i = 0; i < Arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Tọa dộ ({0},{1})", i, j);
            //        Arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            Console.WriteLine("Mảng 2 chiều là:");
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.Write("Nhập Phím bất kỳ để tiếp tuc");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Mang1Chieu();
            Mang2Chieu();
        }
    }
}
