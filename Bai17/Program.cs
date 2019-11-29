using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    class Program
    {
        static Dictionary<string, string> EnToTV = new Dictionary<string, string>();
        static Dictionary<string, string> TVToEn = new Dictionary<string, string>();

        private static void App()
        {
            string VN = "Tiếng Việt";
            string EN = "Tiếng Anh";

            int Chon = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Từ điển / Translate\n");
                Console.WriteLine("1: " + EN + " ---> " + VN);
                Console.WriteLine("2: " + VN + " ---> " + EN);
                Console.WriteLine("ESC: Thoát");
                Console.Write("Chon: ");

                Chon = Convert.ToInt32(Console.ReadKey().KeyChar);
                Console.Write("\n");
                switch (Chon)
                {
                    case 49:
                        while (Menu(EnToTV, EN))
                        {
                        }
                        break;
                    case 50:
                        while (Menu(TVToEn, VN))
                        {
                        }
                        break;
                    case 27:
                        break;
                    default:
                        Console.WriteLine("Nhập đúng số chức năng để thực hiện");
                        Console.WriteLine("Bấm phím bất kỳ để chọn lại");
                        Console.ReadKey();
                        break;
                }

            } while (Chon != 27);
            

        }



        private static bool Menu(Dictionary<string, string> Trans, string Val)
        {
            Console.Clear();
            Console.WriteLine(Val.ToUpper());
            Console.WriteLine("1: Tra từ");
            Console.WriteLine("2: Thêm Từ");
            Console.WriteLine("3. Sửa từ");
            Console.WriteLine("4: Xóa từ");
            Console.WriteLine("ESC: Trở về");
            Console.Write("Chon: ");

            try
            {
                switch (Convert.ToInt32(Console.ReadKey().KeyChar))
                {
                    case 49:
                        Console.Clear();
                        TraTu(Trans, Val);
                        break;
                    case 50:
                        Console.Clear();
                        ThemTu(Trans, Val);
                        break;
                    case 51:
                        Console.Clear();
                        SuaTu(Trans, Val);
                        break;
                    case 52:
                        Console.Clear();
                        XoaTu(Trans, Val);
                        break;
                    case 27:
                        return false;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception E)
            {
                Console.WriteLine("Lỗi : " + E.Message);
                return true;
            }
            
        }

        private static void XoaTu(Dictionary<string, string> Trans, string Val)
        {
            do
            {
                Console.WriteLine("Nhập từ " + Val + " cần xóa: ");
                string VString = Console.ReadLine();
                if (Trans.Remove(VString))
                {
                    Console.WriteLine("Xóa thành công");
                }
                else
                {
                    Console.WriteLine(VString + " không có trong từ diển không thể xóa");
                }

                Console.WriteLine("Bấm phím bất kỳ để xóa tiếp.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void SuaTu(Dictionary<string, string> Trans, string Val)
        {
            do
            {

                Console.WriteLine("Nhập từ " + Val + " cần sửa");
                string VString = Console.ReadLine();
                if (Trans.ContainsKey(VString))
                {
                    Console.WriteLine("Nhap nghĩa Tiếng ANH");
                    TVToEn[VString] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(VString + " không có trong từ diển");
                }


                Console.WriteLine("Bấm phím bất kỳ để sửa từ.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void ThemTu(Dictionary<string, string> Trans, string Val)
        {
            do
            {
                Console.WriteLine("Nhập từ " + Val + " cần thêm");
                string VString = Console.ReadLine();
                if (Trans.ContainsKey(VString))
                {
                    Console.WriteLine(VString + " đã có trong từ diển");
                    
                }
                else
                {
                    Console.WriteLine("Nhập nghĩa của từ " + VString + " : ");
                    TVToEn[VString] = Console.ReadLine();
                }

                Console.WriteLine("Bấm phím bất kỳ để thêm từ.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void TraTu(Dictionary<string, string> Trans, string Val)
        {
            do
            {
                Console.WriteLine("Nhập từ " + Val + " cần tra");
                string VString = Console.ReadLine();
                if (Trans.ContainsKey(VString))
                {
                    
                    Console.WriteLine("Nghĩa của " + VString + " Là : " + Trans[VString]);
                }
                else
                {
                    Console.WriteLine(VString + " không có trong từ diển");
                }

                Console.WriteLine("Bấm phím bất kỳ để tìm từ.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            App();

        }
    }
}
