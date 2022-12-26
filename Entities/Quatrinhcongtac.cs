using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Quatrinhcongtac
    {
        string maCT, maNS, maKhoa, maCV;
        DateTime nambatdau, namketthuc;

        public string MaCT { get => maCT; set => maCT = value; }
        public string MaNS { get => maNS; set => maNS = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public DateTime Nambatdau { get => nambatdau; set => nambatdau = value; }
        public DateTime Namketthuc { get => namketthuc; set => namketthuc = value; }
    }
}
