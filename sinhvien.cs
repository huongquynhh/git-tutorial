using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinh_Vien
{
    internal class sinhvien
    {
        private string hoten, masv, quequan;
        private int namsinh;
        private double diemcsdl, diemcslt;
        public sinhvien()
        {
             hoten = "";
            masv = "";
            diemcsdl = 0;
            diemcslt = 0;
           
        }
       /* public  string Hoten
        { get { return hoten; } 
            set { hoten = value; }
        }
        
        public int Namsinh
        {
            get{ return namsinh; }
            set { namsinh = value; }
            
}
         public double Diemcsdl
        {
            get { return diemcsdl; }
            set { diemcsdl = value; }
        }*/
        public sinhvien(string hoten, int namsinh, string quequan, double diemcslt, double diemcsdl)
        {
            this.hoten = hoten;
            this.quequan = quequan;
           this.namsinh=namsinh;
           this.diemcsdl = diemcslt;
           this.diemcslt = diemcslt;
                                        
        }    
        public void nhap()
        {
            Console.WriteLine("Nhập họ và tên sinh viên");
            hoten=Console.ReadLine();
            Console.WriteLine("Nhập mã sinh viên");
            masv = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh");
            namsinh= Int16.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn cslt");
            diemcslt= double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn csdl");
            diemcsdl=double.Parse(Console.ReadLine());
        }
        public static double diemtbc( double diemcslt,double diemcsdl)
        {
            double diemtb;

         diemtb = (diemcsdl + diemcslt) / 2;
            return diemtb;

        }
        public void xuat()
        {
            Console.WriteLine("Họ và tên sinh viên là: {0}", hoten);
            Console.WriteLine("Mã sinh viên là {0}",masv);
            Console.WriteLine("Năm sinh là: {0}", namsinh);
            Console.WriteLine("Điểm môn cslt là: {0}", diemcslt);
            Console.WriteLine("Điểm môn csdl là:{0} ", diemcsdl);
            Console.WriteLine("Điểm trung bình là:{0}", diemtbc(diemcslt,diemcsdl));
        }

        
    }
}
