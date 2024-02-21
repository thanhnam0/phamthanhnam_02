using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithihocki_II
{
    class NhanVienHD: NhanVien
    {
        private int Doanhthu;
        public NhanVienHD() : base()
        {

        }
        public NhanVienHD(string Maso, string Hoten, int Luongcung, int doanhthu)
        {
            this.Doanhthu = doanhthu;
        }
        public int doanhthu
        {   set { Doanhthu = value; }
            get { return doanhthu; }
        }
        public override void nhap()
        {

            base.nhap();
            Console.WriteLine("nhap muc xep loai:");
            this.doanhthu = int.Parse(Console.ReadLine());
        }
        public override int Tinhluong()
        {
            double thuong;
            thuong = 0.1 * doanhthu;
            return Tinhluong ;
        }
      
    }
}
