using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Quatrinhhoctap
    {
        string maHT, maNS, maHV, noihoctap;
        DateTime nambatdau, namketthuc;

        public string MaHT { get => maHT; set => maHT = value; }
        public string MaNS { get => maNS; set => maNS = value; }
        public string MaHV { get => maHV; set => maHV = value; }
        public string Noihoctap { get => noihoctap; set => noihoctap = value; }
        public DateTime Nambatdau { get => nambatdau; set => nambatdau = value; }
        public DateTime Namketthuc { get => namketthuc; set => namketthuc = value; }
    }
}
