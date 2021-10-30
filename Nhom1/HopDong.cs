using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1
{
    class HopDong : NhanVien
    {
        private float Luongcb;
        private float Tiencong;
        private float Ngaycong;
        private float Heso;

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
        public float TienCong
        {
            get
            {
                return Tiencong;
            }
            set
            {
                Tiencong = value;
            }
        }
        public float NgayCong
        {
            get
            {
                return Ngaycong;
            }
            set
            {
                Ngaycong = value;
            }
        }
        public float HeSo
        {
            get
            {
                return Heso;
            }
            set
            {
                Heso = value;
            }
        }
        public HopDong(): base()
        {
            this.Luong = 0;
            this.LuongCB = 0;
            this.TienCong = 0;
            this.NgayCong = 0;
            this.HeSo = 0;
        }
        public override void NhapNhanVien()
        {
            base.NhapNhanVien();
            this.LuongCB = 10000000;
            Console.Write("Tiền công lao động: ");
            this.TienCong = float.Parse(Console.ReadLine());
            Console.Write("Số ngày làm trong tháng: ");
            this.NgayCong = float.Parse(Console.ReadLine());
            Console.Write("Hệ số vượt giờ: ");
            this.HeSo = float.Parse(Console.ReadLine());
            this.Luong = Luongcb + Tiencong * NgayCong * HeSo;
        }
    }
}
