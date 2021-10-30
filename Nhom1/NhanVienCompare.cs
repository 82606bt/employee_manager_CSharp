using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1
{
    class NhanVienCompare : IComparer<NhanVien>
    {
        bool largeToSmall;
        string field;
        public NhanVienCompare(bool largeToSmall, string field)
        {
            this.largeToSmall = largeToSmall;
            this.field = field;
        }
        public int Compare(NhanVien x, NhanVien y)
        {
            switch (field)
            {
                case "id":
                    if (largeToSmall)
                        return y.MaSo.CompareTo(x.MaSo);
                    else
                        return x.MaSo.CompareTo(y.MaSo);
                case "name":
                    if (largeToSmall)
                        return y.Ten.CompareTo(x.Ten);
                    else
                        return x.Ten.CompareTo(y.Ten);
                case "idpb":
                    if (largeToSmall)
                        return y.MaSoPB.CompareTo(x.MaSoPB);
                    else
                        return x.MaSoPB.CompareTo(y.MaSoPB);
                case "tenpb":
                    if (largeToSmall)
                        return y.TenPB.CompareTo(x.TenPB);
                    else
                        return x.TenPB.CompareTo(y.TenPB);
                case "luong":
                    if (largeToSmall)
                        return y.Luong.CompareTo(x.Luong);
                    else
                        return x.Luong.CompareTo(y.Luong);
            }
            return 0;
        }

    }
}
