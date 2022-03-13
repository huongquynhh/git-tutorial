using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Không_gian_2_chiều
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.OutputEncoding = Encoding.UTF8;

            Diem A = new Diem();
            Diem B = new Diem();
            Diem C=new Diem();
            Console.WriteLine("Nhập tọa độ điểm A:");
            A.nhap();
            A.xuat();
            Console.WriteLine("Nhập tọa độ điểm B");
            B.nhap();
            B.xuat();
            C.kc(A,B);
            C.xuatkc();
            Console.ReadLine();
        }
    }
}
