using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithihocki_II
{
    class NhanVienBC: NhanVien
    {
        private string Mucxeploai;
        public NhanVienBC() : base()
        {

        }
        public NhanVienBC(string Maso,string Hoten,int Luongcung,string Mucxeploai)
        {
            this.Mucxeploai = Mucxeploai;
        }
        public string mucxeploai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }
        public override void nhap()
        {
           
            base.nhap();
            Console.WriteLine("nhap muc xep loai:");
            this.mucxeploai = Console.ReadLine();       
        }
        public override int Tinhluong()
        {
            double thuong;
            if (this.mucxeploai == "A")
            {
                thuong = 1.5 * luongcung;
            }
            else if (this.mucxeploai == "B")
            {
                thuong = 1.0 * luongcung;
            }    
            if (this.mucxeploai == "C")
            {   thuong = 0.5 * luongcung;
            }
            return (int)Tinhluong();
            
        }

    }
}
