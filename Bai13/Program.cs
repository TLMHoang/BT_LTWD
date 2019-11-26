using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        //Nhập vào 1 chuỗi, sau đó:
        //1. Đếm xem chuỗi có bao nhiêu in HOA, in thường, số
        //2. Đếm số khoảng trắng trong chuỗi.
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BaiTap1();
            FindString();
            SoSanh2Chuoi();
            GoodString();
           
        }

        static void BaiTap1()
        {
            Console.Clear();
            Console.WriteLine("Câu 1: Đếm xem chuỗi có bao nhiêu in HOA, in thường, số\n\n");
            Console.Write("Nhập Chuỗi:");
            string s = Console.ReadLine();
            int DemInHoa = 0, DemInThuong = 0, DemSo = 0, DemKT = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                {
                    DemInThuong++;
                    continue;
                }
                    
                if (char.IsUpper(s[i]))
                {
                    DemInHoa++;
                    continue;
                }
                if (char.IsDigit(s[i]))
                {
                    DemSo++;
                    continue;
                }
                if (char.IsWhiteSpace(s[i]))
                {
                    DemKT++;
                    continue;
                }
            }
            Console.WriteLine("Có {0} ký tự in thường", DemInThuong);
            Console.WriteLine("Có {0} ký tự in HOA", DemInHoa);
            Console.WriteLine("Có {0} ký tự số", DemSo);
            Console.WriteLine("Có {0} ký tự khoảng trắng", DemKT);
            Console.WriteLine("Bấm phím bất kỳ để tiếp tục");
            Console.ReadKey();
        }

        static void FindString()
        {
            Console.Clear();
            Console.WriteLine("Câu 2: Đếm số khoảng trắng (Ký tự) trong chuỗi\n\n");
            Console.Write("Nhập Chuỗi:");
            string VString = Console.ReadLine();

            Console.Write("Nhập Chuỗi/Ký tự cần tìm :");
            string Find = Console.ReadLine();

            string Chinh = VString.ToUpper();
            string Phu = Find.ToUpper();
            if (Chinh.IndexOf(Phu) == -1)
            {
                Console.WriteLine("\"" + Find + "\" Không xuất hiện trong \"" + VString + "\"");
            }
            else
            {
                int StartS = Chinh.IndexOf(Phu);
                Console.WriteLine(VString.Substring(StartS, Find.Length) + " tại vị trí {0} đến {1} \n", StartS, StartS + Find.Length - 1);
            }

            Console.WriteLine("Bấm phím bất kỳ để tiếp tục");
            Console.ReadKey();
        }

        static void SoSanh2Chuoi()
        {
            Console.Write("Nhập Chuỗi 1:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Nhập Chuỗi 2:");
            string s2 = Console.ReadLine();

            int kq = s1.ToLower().CompareTo(s2.ToLower());
            if (kq == 0)
            {
                Console.WriteLine("s1 và s2 giống nhau");
            }
            else if (kq < 0)
            {
                Console.WriteLine("s1 < s2");
            }
            else
            {
                Console.WriteLine("s1 > s2");
            }

            Console.WriteLine("Bấm phím bất kỳ để tiếp tục");
            Console.ReadKey();
        }

        static void GoodString()
        {

            Console.WriteLine("Sửa chuỗi về dạng chuẩn hóa");
            Console.WriteLine("Nhập chuỗi:");
            string ten = Console.ReadLine();
          
            ten = ten.Trim();

            Console.WriteLine(ten[0]);
            string[] AVString = ten.Split(
                        new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);
            ten = "";
            for (int i = 0; i < AVString.Length; i++)
            {

                AVString[i] = AVString[i].ToLower();
                char[] TG = AVString[i].ToCharArray();
                TG[0] = char.ToUpper(TG[0]);
                ten += new string(TG) + " ";
            }
            ten = ten.Trim();
            Console.WriteLine("Chuỗi sau khi tối ưu:");
            Console.WriteLine(ten);

            Console.WriteLine("Bấm phím bất kỳ để tiếp tục");
            Console.ReadKey();
        }

    }
}
