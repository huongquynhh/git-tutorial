using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Không_gian_2_chiều
{
    internal class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            x = 0;
            y = 0;
        }
      
        public Diem(double x, double y)
        {
            this.x = x;
             this.y = y;
        }
        
        public void nhap()
        {
            Console.WriteLine(" Nhập x");
             x= double.Parse(Console.ReadLine());
            Console.WriteLine(" Nhập y");
            y = double.Parse(Console.ReadLine());    
        }
        public double  kc(Diem A, Diem B)
        {
            double kc = new double();

            kc = Math.Sqrt(Math.Pow(B.x - A.x,2) + Math.Pow(B.y - A.y,2));
            return kc;
        }
        public void xuat()
        {
            Console.WriteLine("Tọa độ điểm là  ({0},{1}):", x, y);
        }
        public void xuatkc()
        {
            Diem A = new Diem();
            Diem B = new Diem();
           
            Console.WriteLine("Khoảng cách giữa hai điểm là: {0}", kc(A,B));

        }

    }
    }

