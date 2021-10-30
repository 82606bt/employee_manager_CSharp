using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1
{
    class Program 
    {
        static Manager manager = new Manager();
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            manager.Menu();
            int chon=0;
                     
            do
            {
                Console.Write("Mời bạn chọn số cần thao tác: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        manager.inputNhieuNhanVien();                     
                        Console.WriteLine("Nhấn enter để tiếp tục lựa chọn ");
                        Console.ReadLine();
                        Console.Clear();
                        manager.Menu();
                        break;
                    case 2:
                        manager.ShowDanhSach();
                        Console.WriteLine("Nhấn enter để tiếp tục lựa chọn ");
                        Console.ReadLine();
                        Console.Clear();
                        manager.Menu();
                        break;
                    case 3:
                        manager.Sapxep();
                        Console.WriteLine("Nhấn enter để tiếp tục lựa chọn ");
                        Console.ReadLine();
                        Console.Clear();
                        manager.Menu();
                        break;
                    case 4:
                        manager.SearchNhanVien();
                        Console.WriteLine("Nhấn enter để tiếp tục lựa chọn ");
                        Console.ReadLine();
                        Console.Clear();
                        manager.Menu();
                        break;
                    case 5:
                        manager.DeleteNhanVien();
                        Console.WriteLine("Nhấn enter để tiếp tục lựa chọn ");
                        Console.ReadLine();
                        Console.Clear();
                        manager.Menu();
                        break;
                    case 6:
                        manager.SearchPhongBan();
                        Console.WriteLine("Nhấn enter để tiếp tục lựa chọn ");
                        Console.ReadLine();
                        Console.Clear();
                        manager.Menu();
                        break;
                    case 7:
                        manager.Sum();
                        Console.WriteLine("Nhấn enter để tiếp tục lựa chọn ");
                        Console.ReadLine();
                        Console.Clear();
                        manager.Menu();
                        break;
                    default:
                        Console.WriteLine("Nhấn double enter để out chương trình ");
                        Console.ReadLine();                      
                        break;
                }
            } while (chon > 0 && chon <8);
            Console.ReadLine();
        }
    }
}
