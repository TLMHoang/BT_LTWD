using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Random random = new Random();
            int n = random.Next(50);
            NhapDic(dic, n);
            XuatDic(dic);

            Console.Write("Nhập Key xóa: ");
            n = int.Parse(Console.ReadLine());
            dic.Remove(n);
            XuatDic(dic);


            Console.Clear();
            Console.WriteLine("Chuyển Dictionary thành list");
            List<int> listInt = dic.Keys.ToList();
            List<string> listString = dic.Values.ToList();

            Console.WriteLine("Xuất Kết quả");
            for (int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine("Mã: {0} ; Value: {1}", listInt[i], listString[i]);
            }

            Console.ReadLine();
        }

        private static void XuatDic(Dictionary<int, string> dic)
        {
            foreach(KeyValuePair<int, string> iteam in dic)
            {
                Console.WriteLine("Mã: {0} ; Value: {1}", iteam.Key, iteam.Value);
            }

            Console.Write("\n\nNhập phím bất kỳ đểb tiết tục.......");
            Console.ReadKey();
            Console.Write("\n\n");
        }

        private static void NhapDic(Dictionary<int, string> dic, int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                if (dic.ContainsKey(i) == false)
                {
                    dic.Add(i, "Name" + random.Next(100).ToString());
                }
                
            }
        }
    }
}
