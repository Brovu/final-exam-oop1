using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Practice
{
    public class Xe
    {
        public string dongXe { get; set; }
        public int soChoNgoi { get; set; }
        public DateTime ngaySX { get; set; }

        public double giaSan = 400;


        public Xe() { }

        public Xe(string dongXe, int soChoNgoi, DateTime ngaySX, double giaSan)
        {
            this.dongXe = dongXe;
            this.soChoNgoi = soChoNgoi;
            this.ngaySX = ngaySX;
            this.giaSan = giaSan;
        }

        public void input()
        {
            Console.Write("Dong xe: ");
            dongXe = Console.ReadLine();
            Console.Write("So cho ngoi: ");
            soChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Ngay san xuat: ");
            string input = Console.ReadLine();
            ngaySX = DateTime.ParseExact(input, "dd/MM/yyyy", null);
        }

        public double calSalePrice()
        {
            double giaBan;
            int khoangCach = DateTime.Now.Year - ngaySX.Year;
            if (khoangCach > 2)
            {
                giaBan = giaSan * 1.15;
            }
            if ( khoangCach > 1 && khoangCach <= 2)
            {
                giaBan = giaSan * 1.15;
            }
            else
            {
                giaBan = giaSan * 1.5;
            }
            return giaBan;
        }

        public void output ()
        {
            Console.WriteLine("Dong xe: {0} ", dongXe);
            Console.WriteLine("So Cho ngoi: {0} ", soChoNgoi);
            Console.WriteLine("Ngay san xuat: " + ngaySX.ToString(format: "dd/MM/yyyy"));
            Console.WriteLine("Gia ban: {0}", calSalePrice());
        }
    }
}
