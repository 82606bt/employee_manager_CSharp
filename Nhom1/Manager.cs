using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1
{
    class Manager 
    {
        private List<NhanVien> List = new List<NhanVien>();
        public NhanVien TypeNhanVien()
        {
            Console.WriteLine("Chọn loại nhân viên: ");
            Console.WriteLine("1. Nhân viên Biên chế ");
            Console.WriteLine("2. Nhân viên Hợp đồng ");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    return new BienChe();
                case 2:
                    return new HopDong();
            }
            return null;
        }
        public void inputNhanVien()
        {
            NhanVien nhanvien = TypeNhanVien();
            nhanvien.NhapNhanVien();
            List.Add(nhanvien);
            Console.WriteLine("Đã thêm nhân viên");
        }
        public void inputNhieuNhanVien()
        {
            Console.WriteLine("Nhập số lượng nhân viên cần thêm: ");
            int sl = int.Parse(Console.ReadLine());
            for (int i = 0; i < sl; i++)
            {
                inputNhanVien();
            }
        }
        public void ShowDanhSach()
        {
            Console.WriteLine("Danh sách nhân viên");
            Console.WriteLine("{0, -15}{1, -20}{2, -20}{3, -25}{4, -15}{5, -15}{6, -20}{7, -20}{8, -15}", "ID", "Name", "Address", "Email", "Phone", "ID Phòng ban", "Tên Phòng ban", "Trưởng phòng", "Lương");
            foreach (NhanVien nv in List)
            {
                nv.Show();
            }
        }
        public bool TimKiemNV(string id)
        {
            foreach (NhanVien nv in List)
            {
                if (id == nv.MaSo) return true;
            }
            return false;
        }
        public void SearchNhanVien()
        {
            Console.WriteLine("Nhập ID nhân viên cần tìm: ");
            string idnv = Console.ReadLine();
            int i = 0;
            foreach (NhanVien nv in List)
            {     
                if (idnv == nv.MaSo)
                {
                    Console.WriteLine("Nhân viên cần tìm là: ");
                    Console.WriteLine("{0, -15}{1, -20}{2, -20}{3, -25}{4, -15}{5, -15}{6, -20}{7, -20}{8, -15}", "ID", "Name", "Address", "Email", "Phone", "ID Phòng ban", "Tên Phòng ban", "Trưởng phòng", "Lương");
                    nv.Show();
                    i++;
                }
            }
            if(i == 0)
            {
                Console.WriteLine("ID không phù hợp");
            }
        }
        public void DeleteNhanVien()
        {
            NhanVienCompare comp = new NhanVienCompare(false, "id");
            Console.WriteLine("Nhập ID nhân viên cần xóa: ");
            string id = Console.ReadLine();
            if (TimKiemNV(id))
            {
                int vt = List.BinarySearch(new NhanVien(id, "", "", "", "", "", "", "", 0), comp);
                NhanVien nv = List[vt];
                Console.WriteLine("Đã xóa nhân viên thành công ");
                List.Remove(nv);
            }
            else
                Console.WriteLine("Không tìm thấy nhân viên ");
        }
        public void SearchPhongBan()
        {
            int i = 0;
            Console.WriteLine("Nhập ID Phòng ban cần thao tác: ");
            string idpb = Console.ReadLine();
            foreach (NhanVien nv in List)
            {
                if (idpb == nv.MaSoPB)
                {
                    Console.WriteLine("Phòng ban cần tìm là: ");
                    Console.WriteLine("{0, -15}{1, -20}{2, -20}", "ID Phòng ban", "Tên Phòng ban", "Trưởng phòng");
                    Console.WriteLine("{0, -15}{1, -20}{2, -20}", nv.MaSoPB, nv.TenPB, nv.TruongPhong);
                    i++;
                    break;
                }
            }
            if(i == 0)
                Console.WriteLine("ID phòng ban không phù hợp");
        }
        public int select()
        {
            int select;
            Console.Write("Chọn: ");
            select = int.Parse(Console.ReadLine());
            return select;
        }
        public void Sapxep()
        {
            string field = "id";
            bool largeToSmall;
            Console.WriteLine("Kiểu sắp xếp: ");
            Console.WriteLine(" 1. Từ nhỏ tới lớn");
            Console.WriteLine(" 2. Từ lớn tới nhỏ");
            switch (select())
            {
                case 1:
                    largeToSmall = false;
                    break;
                case 2:
                    largeToSmall = true;
                    break;
                default:
                    largeToSmall = false;
                    break;
            }
            Console.WriteLine("Sắp xếp theo: ");
            Console.WriteLine(" 1. ID Nhân viên");
            Console.WriteLine(" 2. Tên Nhân viên");
            Console.WriteLine(" 3. ID Phòng ban");
            Console.WriteLine(" 4. Tên Phòng ban");
            Console.WriteLine(" 5. Lương");
            switch (select())
            {
                case 1: field = "id"; break;
                case 2: field = "name"; break;
                case 3: field = "idpb"; break;
                case 4: field = "tenpb"; break;
                case 5: field = "luong"; break;
            }
            List.Sort(new NhanVienCompare(largeToSmall, field));
            Console.WriteLine("Danh sach da duoc sap xep");
            Console.WriteLine("Danh sách sau khi được sắp xếp ");
            ShowDanhSach();
        }
        public void Sum()
        {
            int sum = 0;
            foreach (NhanVien nv in List)
                sum += (int) nv.Luong;
            Console.WriteLine("Tổng tiền trả cho nhân viên trong tháng: {0}", sum);
        }
        public void Menu()
        {
            Console.WriteLine("\t\t\t =====================MENU=======================\n");
            Console.WriteLine("\t\t\t |1. Nhập số lượng nhân viên cần thêm           |\n");
            Console.WriteLine("\t\t\t |2. Danh sách nhân viên                        |\n");
            Console.WriteLine("\t\t\t |3. Sắp xếp nhân viên                          |\n");
            Console.WriteLine("\t\t\t |4. Tìm kiếm nhân viên                         |\n");
            Console.WriteLine("\t\t\t |5. Xóa nhân viên                              |\n");
            Console.WriteLine("\t\t\t |6. Tìm kiếm phòng ban                         |\n");
            Console.WriteLine("\t\t\t |7. Tổng tiền nhân viên cần phải trả / 1 month |\n");
            Console.WriteLine("\t\t\t |8. Thoát chương trình                         |\n");
            Console.WriteLine("\t\t\t ================================================\n");

        }
        
    }
}
