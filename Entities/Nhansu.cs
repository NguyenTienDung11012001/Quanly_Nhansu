using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Nhansu
    {
        string maNS, tenNS, gioitinh, diachi, sDT, email;
        DateTime ngaysinh;

        public string MaNS { get => maNS; set => maNS = value; }
        public string TenNS { get => tenNS; set => tenNS = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
    }
}
