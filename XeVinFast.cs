using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Practice
{
    public class XeVinFast : Xe, Phi, IComparable<XeVinFast>
    {
        public string noiDangKy { get; set; }

        Xe xe = new Xe();

        public XeVinFast() { }

        public XeVinFast(string noiDangKy, string dongXe, int soChoNgoi, DateTime ngaySX, double giaSan) : base(dongXe, soChoNgoi, ngaySX, giaSan)
        {
            this.noiDangKy = noiDangKy;
            this.dongXe = dongXe;
            this.soChoNgoi = soChoNgoi;
            this.ngaySX = ngaySX;
        }

        public double phiTruocBa { get; set; }


        public void inputVinFast()
        {
            Console.Write("Noi dang ky: ");
            noiDangKy = Console.ReadLine();
            xe.input();
            Console.Write("Nhap phi truoc ba theo so thuc (vd: 30% = 0.3): \n");
            phiTruocBa = double.Parse(Console.ReadLine());

        }

        public double calPhiTruocBa()
        {
            return phiTruocBa * xe.calSalePrice();
        }

        public double calPhiDangKy()
        {
            double phiDangKy;
            if(noiDangKy == "Ha Noi")
            {
                phiDangKy = xe.calSalePrice() * 12 / 100;
            } else
            {
                phiDangKy = xe.calSalePrice() * 10 / 100;
            }
            return phiDangKy;
        }

        public double calGiaLanBanh()
        {
            return xe.calSalePrice() + calPhiTruocBa() + calPhiDangKy();
        }

        public int CompareTo(XeVinFast xe)
        {
            return calGiaLanBanh().CompareTo(xe.calGiaLanBanh()) * -1;
        }


        public void outputVinFast()
        {
                Console.WriteLine("\nNoi dang ky: {0}", noiDangKy);
                xe.output();
                Console.WriteLine("Gia Lan Banh: {0}", calGiaLanBanh());
        }
    }
}
