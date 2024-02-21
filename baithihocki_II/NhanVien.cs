using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithihocki_II
{
    class NhanVien
    {
        private string Maso;
        private string Hoten;
        private int Luongcung;

        public NhanVien()
        {

        }
        public NhanVien(string Maso, string Hoten, int Luongcung)
        {
            this.Maso = Maso;
            this.Hoten = Hoten;
            this.Luongcung = Luongcung;
        }
        public string maso
        {
            set { this.maso = value; }
            get { return maso; }
        }
        public string HoTen
        {
            set { this.Hoten = value; }
            get { return Hoten; }
        }
        public int luongcung
        {
            set { this.luongcung = value; }
            get { return luongcung; }
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ma so: ");
            this.maso = Console.ReadLine();
            Console.WriteLine("nhap ho va ten: ");
            this.Hoten = Console.ReadLine();
            Console.WriteLine("nhap luong cung: ");
            this.luongcung = int.Parse(Console.ReadLine());
        }
        public virtual int Tinhluong()
        {
            return Luongcung;
        }
       
    }
}
