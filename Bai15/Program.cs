using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    class Program
    {

        static void ListString()
        {
            Console.Clear();
            List<string> listName = new List<string>();
            //Nhap nhiều với bien51 String Name + NumSTT
            Random random = new Random();
            int n = random.Next(50);
            for (int i = 0; i < n; i++)
            {
                listName.Add("Name" + i.ToString());
            }
            Console.WriteLine("List sau random:");
            XuatListString(listName);

            Console.Clear();
            Console.WriteLine("Thêm vào List :");
            Console.Write("Thêm tại vị trí :");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Gia trị thêm :");
            string AN = Console.ReadLine();
            listName.Insert(x, AN);
            XuatListString(listName);

            Console.Clear();
            Console.WriteLine("Xóa trong List :");
            Console.Write("Xoa tại vị trí :");
            x = int.Parse(Console.ReadLine());
            listName.RemoveAt(x);
            XuatListString(listName);

            Console.Clear();
            Console.Write("Xóa trong List :");
            Console.Write("Xoa với tên :");
            AN = Console.ReadLine();
            listName.Remove(AN);
            XuatListString(listName);

        }

        
        static void ListInt()
        {
            Console.Clear();
            List<int> listInt = new List<int>();
            Random random = new Random();
            int n = random.Next(50);
            for (int i = 0; i < n; i++)
            {
                listInt.Add(random.Next(100));
            }
            XuatListInt(listInt);
            listInt.Sort();
            Console.WriteLine("\nList sau săp xếp là:");
            XuatListInt(listInt);
            
            Console.Write("\nNhập số tìm: ");

            int k = int.Parse(Console.ReadLine());
            int kq = listInt.IndexOf(k);
            if (kq < 0)
                Console.WriteLine("Không tìm thấy {0} trong danh sách", k);
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí {1}", k, kq);
            
            
            Console.WriteLine("\n\n Nhấn phím bất kỳ để tiếp tục.............");
            Console.ReadKey();
        }

        private static void XuatListInt(List<int> listInt)
        {
            Console.WriteLine("Các phần tử trong danh sách gốc là:");
            foreach (int x in listInt)
            {
                Console.Write(x + "\t");
            }

            Console.WriteLine("\n\n Nhấn phím bất kỳ để tiếp tục.............");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ListString();

            ListInt();
        }

        private static void XuatListString(List<string> listName)
        {
            
            Console.WriteLine("Danh sách các phần tử trong List là:");
            foreach (string v in listName)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\n\n\n\n\n Nhấn phím bất kỳ để tiếp tục.............");
            Console.ReadKey();
        }
    }
}
