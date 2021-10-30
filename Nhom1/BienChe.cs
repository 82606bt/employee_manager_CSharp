using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1
{
    class BienChe : NhanVien
    {
        private float Luongcb;
        private float Hesoluong;
        private string Chucvu;
        private double Phucap;

        public float LuongCB
        {
            get
            {
                return Luongcb;
            }
            set
            {
                Luongcb = value;
            }
        }
        public float HeSoLuong
        {
            get
            {
                return Hesoluong;
            }
            set
            {
                Hesoluong = value;
            }
        }
        public string ChucVu
        {
            get
            {
                return Chucvu;
            }
            set
            {
                Chucvu = value;
            }
        }
        public double PhuCap
        {
            get
            {
                return Phucap;
            }
            set
            {
                Phucap = value;
            }
        }
        public BienChe() : base()
        {
            this.LuongCB = 0;
            this.HeSoLuong = 0;
            this.ChucVu = "";
            this.PhuCap = 0;
        }
        public override void NhapNhanVien()
        {
            base.NhapNhanVien();
            int select;
            this.LuongCB = 10000000;
            Console.Write("Hệ số lương: ");
            this.HeSoLuong = float.Parse(Console.ReadLine());
            Console.Write("Chức vụ:\n1.Giám đốc\n2.Trưởng phòng\n3.Phó phòng\n4.Nhân viên\n");
            select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                this.ChucVu = "Giám đốc";
                this.PhuCap = 0.25;
            }
            else if(select == 2)
            {
                this.ChucVu = "Trưởng phòng";
                this.PhuCap = 0.15;
            }
            else if(select == 3)
            {
                this.ChucVu = "Phó phòng";
                this.PhuCap = 0.05;
            }
            else
            {
                this.ChucVu = "Nhân viên";
                this.PhuCap = 0;
            }
            this.Luong = (Luongcb * Hesoluong) + (Luongcb * Phucap);
        }
      
    }
}
