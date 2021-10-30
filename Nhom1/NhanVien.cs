using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nhom1
{
    public class NhanVien
    {
        private string ID;
        private string Name;
        private string Address;
        private string Gmail;
        private string Phone;
        private string IDPB;
        private string NamePB;
        private string Truongphong;
        private double luong;
        public NhanVien(string ID, String Name, String Address, String Gmail, string Phone, string IDPB, string NamePB, string Truongphong, double luong)
        {
            this.MaSo = ID;
            this.Ten = Name;
            this.DiaChi = Address;
            this.Mail = Gmail;
            this.Dienthoai = Phone;
            this.MaSoPB = IDPB;
            this.TenPB = NamePB;
            this.TruongPhong = Truongphong;
            this.Luong = luong;
        }

        public NhanVien()
        {
        }

        public double Luong
        {
            get
            {
                return luong;
            }
            set
            {
                luong = value;
            }
        }
        public string MaSo
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public string Ten
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string Mail
        {
            get
            {
                return Gmail;
            }
            set
            {
                Gmail = value;
            }
        }
        public string Dienthoai
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public string MaSoPB
        {
            get
            {
                return IDPB;
            }
            set
            {
                IDPB = value;
            }
        }
        public string TenPB
        {
            get
            {
                return NamePB;
            }
            set
            {
                NamePB = value;
            }
        }
        public string TruongPhong
        {
            get
            {
                return Truongphong;
            }
            set
            {
                Truongphong = value;
            }
        }
        public bool IsValidEmail(string email)
        {
            String theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
            return Regex.IsMatch(email, theEmailPattern);
        }
        public bool IsValidPhone(string str)
        {
            int i = 0;
            foreach (char a in str)
            {
                i++;
            }
            if (i == 10) return true;
            return false;
        }
        public virtual void NhapNhanVien()
        {
            int i = 0, j = 0;
            Console.Write("Mã số nhân viên: ");
            this.ID = Console.ReadLine();
            Console.Write("Họ tên: ");
            this.Name = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            this.Address = Console.ReadLine();
            do
            {
                if(i != 0)
                    Console.Write("Gmail bạn Nhập không hợp lệ, mời nhập lại\n");
                Console.Write("Nhập Gmail: ");
                i++;
                this.Gmail = Console.ReadLine();
            } while (IsValidEmail(Gmail) == false);
            do
            {
                if (j != 0)
                    Console.Write("Phone bạn Nhập không hợp lệ, mời nhập lại\n");
                Console.Write("Điện thoại: ");
                this.Phone = Console.ReadLine();
                j++;
            } while (IsValidPhone(Phone) == false);
            Console.Write("Mã số phòng ban: ");
            this.IDPB = Console.ReadLine();
            Console.Write("Tên phòng ban: ");
            this.NamePB = Console.ReadLine();
            Console.Write("Trưởng phòng hiện tại: ");
            this.Truongphong = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("{0, -15}{1, -20}{2, -20}{3, -25}{4, -15}{5, -15}{6, -20}{7, -20}{8, -15}", ID, Name, Address, Gmail, Phone, IDPB, NamePB, Truongphong, (int)luong);
        }
    }
}
