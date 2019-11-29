using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    class Program
    {
        static Dictionary<string, List<string>> EnToTV = new Dictionary<string, List<string>>();
        static Dictionary<string, List<string>> TVToEn = new Dictionary<string, List<string>>();
        
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
                        break;
                }

            } while (Chon != 27);
            

        }



        private static bool Menu(Dictionary<string, List<string>> Trans, string Val)
        {
            Console.Clear();
            Console.WriteLine(Val.ToUpper());
            Console.WriteLine("1: Tra từ");
            Console.WriteLine("2: Thêm Từ");
            Console.WriteLine("3. Sửa từ");
            Console.WriteLine("4: Xóa từ");
            Console.WriteLine("5: Thêm nghĩa vào từ đã có");
            Console.WriteLine("6: Xóa 1 nghĩa của từ");
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
                    case 53:
                        DongNghia(Trans, Val);
                        break;
                    case 54:
                        XoaNghia(Trans, Val);
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

        private static void XoaNghia(Dictionary<string, List<string>> Trans, string Val)
        {
            Console.Clear();
            do
            {

                Console.WriteLine("Nhập từ " + Val + " cần sửa");
                string VString = Console.ReadLine().ToLower();
                if (Trans.ContainsKey(VString))
                {
                    if (Trans[VString].Count == 1)
                    {
                        Console.WriteLine("Nhập nghĩa của từ " + VString + " : ");
                        Trans[VString][0] = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        do
                        {
                            XuatNghiaCuaTu(Trans, VString);
                            Console.Write("Chọn số theo nghĩa cần xóa: ");
                            int i = Convert.ToInt32(Console.ReadKey().KeyChar);
                            if (i >= 49 && i <= (Trans[VString].Count + 49))
                            {
                                Trans[VString].RemoveAt(i - 49);
                            }
                            else
                            {
                                Console.WriteLine("\nKhông có nghĩa tại vị trí đó");
                            }

                            Console.WriteLine("\nBấm phím bất kỳ để tiếp tục sử nghĩa " + VString + ".\n\nESC để quay lại");
                        } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(VString + " không có trong từ diển.");
                }
                Console.WriteLine("Bấm phím bất kỳ để sửa từ.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void DongNghia(Dictionary<string, List<string>> trans, string val)
        {
            Console.Clear();
            do
            {
                Console.WriteLine("Nhập từ cần them nghĩa : ");
                string VString = Console.ReadLine().ToLower();
                if (trans.ContainsKey(VString))
                {
                    TuDongNghia(trans, VString);
                    break;
                }
                else
                {
                    Console.WriteLine("Từ này không có trong từ điển");
                }

                Console.WriteLine("Bấm phím bất kỳ để thêm nghĩa khác.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void TuDongNghia(Dictionary<string, List<string>> trans, string val)
        {
            do
            {
                Console.WriteLine("\nNghĩa khác của " + val + " : ");
                trans[val].Add(Console.ReadLine().ToLower());

                Console.WriteLine("Bấm phím bất kỳ để thêm nghĩa khác.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void XoaTu(Dictionary<string, List<string>> Trans, string Val)
        {
            do
            {
                Console.WriteLine("Nhập từ " + Val + " cần xóa: ");
                string VString = Console.ReadLine().ToLower();
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

        private static void SuaTu(Dictionary<string, List<string>> Trans, string Val)
        {
            do
            {

                Console.WriteLine("Nhập từ " + Val + " cần sửa");
                string VString = Console.ReadLine().ToLower();
                if (Trans.ContainsKey(VString))
                {
                    if (Trans[VString].Count == 1)
                    {
                        Console.WriteLine("Nhập nghĩa của từ " + VString + " : ");
                        Trans[VString][0] = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        do
                        {
                            XuatNghiaCuaTu(Trans, VString);
                            Console.Write("Chọn số theo nghĩa cần sửa: ");
                            int i = Convert.ToInt32(Console.ReadKey().KeyChar);
                            if (i >= 49 && i <= (Trans[VString].Count + 49))
                            {
                                Console.Write("\nNhập nghĩa mới: ");
                                Trans[VString][i - 49] = Console.ReadLine().ToLower();
                            }
                            else
                            {
                                Console.WriteLine("Không có nghĩa tại vị trí đó");
                            }

                            Console.WriteLine("Bấm phím bất kỳ để tiếp tục sử nghĩa " + VString + ".\n\nESC để quay lại");
                        } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(VString + " không có trong từ diển.\n Bạn có muốn thêm từ này không? Phim bất kỳ để thêm. ESC de bỏ qua.");
                    if (Convert.ToInt32(Console.ReadKey().KeyChar) != 27)
                    {
                        Console.WriteLine("Nhập Nghĩa : ");
                        Trans.Add(VString, new List<string> { Console.ReadLine().ToLower() });
                    }
                }


                Console.WriteLine("Bấm phím bất kỳ để sửa từ.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void ThemTu(Dictionary<string, List<string>> Trans, string Val)
        {
            do
            {
                Console.WriteLine("Nhập từ " + Val + " cần thêm");
                string VString = Console.ReadLine().ToLower();
                if (Trans.ContainsKey(VString))
                {
                    Console.WriteLine(VString + " đã có trong từ diển");
                    
                }
                else
                {
                    Console.WriteLine("Nhap nghĩa : ");
                    Trans.Add(VString, new List<string> { Console.ReadLine().ToLower() });


                }

                Console.WriteLine("Bấm phím bất kỳ để thêm từ.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void TraTu(Dictionary<string, List<string>> Trans, string Val)
        {
            do
            {
                Console.WriteLine("Nhập từ " + Val + " cần tra");
                string VString = Console.ReadLine().ToLower();
                if (Trans.ContainsKey(VString))
                {
                    XuatNghiaCuaTu(Trans, VString); 
                }
                else
                {
                    Console.WriteLine(VString + " không có trong từ diển");
                }

                Console.WriteLine("Bấm phím bất kỳ để tìm từ.\n\nESC để quay lại");
            } while (Convert.ToInt32(Console.ReadKey().KeyChar) != 27);
        }

        private static void XuatNghiaCuaTu(Dictionary<string, List<string>> trans, string vString)
        {
            Console.WriteLine("Nghĩa của " + vString + " Là :");
            for (int i = 0; i < trans[vString].Count; i++)
            {
                Console.WriteLine("{0} : {1}", i + 1, trans[vString][i]);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            App();

        }
    }
}
