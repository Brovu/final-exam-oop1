using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Practice
{
    internal class Program
    {
        static void XeVinFast()
        {
            List<XeVinFast> dsXeVinFast = new List<XeVinFast>();

            Console.Write("Nhap so luong xe: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Moi ban nhap thong tin xe Vinfast thu {0}", i + 1);
                XeVinFast xeVinFast = new XeVinFast();
                xeVinFast.inputVinFast();
                dsXeVinFast.Add(xeVinFast);
            }

            dsXeVinFast.Sort();

            foreach (XeVinFast xe in dsXeVinFast)
            {
                xe.outputVinFast();
            }

            //Console.Write("\nNhap vi tri p can them: ");
            //int p = int.Parse(Console.ReadLine());
            //XeVinFast xeVinFast2 = new XeVinFast();
            //xeVinFast2.inputVinFast();
            //dsXeVinFast.Insert(p, xeVinFast2);
            //Console.WriteLine("Danh sach sau khi them: ");
            //foreach (XeVinFast xe2 in dsXeVinFast)
            //{
            //    xe2.outputVinFast();
            //}

            //Console.WriteLine("\nNhap dong xe x: ");
            //string x = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                XeVinFast xe = dsXeVinFast[i];
                if (xe.dongXe == "xe o to")
                {
                    dsXeVinFast.RemoveAt(i);
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                Console.WriteLine("ko tim thay!");
            }
            else
            {
                Console.WriteLine("Da xoa");
                Console.WriteLine("\nDanh sach sau khi xoa:\n");
                foreach (XeVinFast xe3 in dsXeVinFast)
                {
                    xe3.outputVinFast();
                }
            }
        }

        static void Main(string[] args)
        {
            XeVinFast();
            Console.ReadKey();
        }
    }
}
