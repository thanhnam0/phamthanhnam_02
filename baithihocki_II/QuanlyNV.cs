using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithihocki_II
{
    class QuanlyNV
    {
        private List<NhanVien> dsnv;
        public QuanlyNV()
        {
            dsnv = new List<NhanVien>();

        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.WriteLine("chon loại nhan vien [1:bien che,2: hop dong]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.nhap();
                        dsnv.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.nhap();
                        dsnv.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Vui long chon 1 hoac 2.");
                        break;
                }
                Console.Write("ban co muon tiep tuc hay khong: y/n");
                tieptuc = Console.ReadLine();
            } while (chon != 0);


           
        }
    }
}
    

