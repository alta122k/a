using System;
using System.Text;

namespace Bai3_De2
{
    public class Point
    {
       
        public int x, y;
        public Point()
        {
            x = y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point C)
        {
            this.x = C.x;
            this.y = C.y;
        }
        public void HienThiToaDo(Point show)
        {
            Console.WriteLine("Hoành độ: {0}. Tung độ: {1}",show.x,show.y);
        }
        public void NhapToaDo()
        {
            Console.Write("Tung độ của điểm: ");
            int hoanhDo = int.Parse(Console.ReadLine());
            Console.Write("Hoành độ của điểm: ");
            int TungDo = int.Parse(Console.ReadLine());
            x = hoanhDo;
            y = TungDo;
        }

    }

    public class DoanThang
    {
        public Point A, B;

        public DoanThang()
        {
            A = B = new Point(0,0);
        }
        public DoanThang(Point A,Point B)
        {
            this.A = A;
            this.B = B;
        }
        public void NhapToaDo()
        {
            
            Console.Write("Tung độ của điểm x: ");
            int hoanhDoX = int.Parse(Console.ReadLine());
            Console.Write("Hoành độ của điểm x: ");
            int TungDoX = int.Parse(Console.ReadLine());
            Point newA = new Point(hoanhDoX, TungDoX);
            A = newA;


            Console.Write("Tung độ của điểm y: ");
            int hoanhDoY = int.Parse(Console.ReadLine());
            Console.Write("Hoành độ của điểm y: ");
            int TungDoY = int.Parse(Console.ReadLine());
            Point newB = new Point(hoanhDoY, TungDoY);
            B = newB;
        }
        public double TinhDoDai()
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }
        public void HienThi()
        {
            Console.WriteLine("Điểm đầu: ({0},{1}) - Điểm cuối: ({2},{3}) - Độ dài: {4}",A.x, A.y, B.x, B.y,TinhDoDai());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            DoanThang[] listDoanThang = new DoanThang[3];
            Console.OutputEncoding = Encoding.UTF8;

            int i = 1;
            do
            {
                DoanThang doanThang = new DoanThang();
                doanThang.NhapToaDo();
                listDoanThang[i-1] = doanThang;
                doanThang.HienThi();
                i++;
            } while (i <=3);
            foreach (var item in listDoanThang)
            {
                Console.WriteLine(item.TinhDoDai());
            }
            double DoanAB = listDoanThang[0].TinhDoDai();
            double DoanBC = listDoanThang[1].TinhDoDai();
            double DoanAC = listDoanThang[2].TinhDoDai();
            if ((DoanAB+DoanAC<DoanBC)|| (DoanAB + DoanBC < DoanAC) || (DoanAC + DoanBC < DoanAB))
            {
                Console.WriteLine("Không thể là tam giác");
            }
            else
            {
                
                if ((DoanAB == DoanBC) && (DoanBC == DoanAC) && (DoanAC == DoanAB))
                {
                    Console.WriteLine("Là tam giác đều");
                }
                else if((DoanAB == DoanAC) || (DoanAC == DoanBC) || (DoanBC == DoanAB))
                {
                    Console.WriteLine("Là tam giác cân");
                }
                else if (
                    (Math.Pow(DoanAB,2) + Math.Pow(DoanBC, 2) == Math.Pow(DoanAC, 2)) || (Math.Pow(DoanAB, 2) + Math.Pow(DoanAC, 2) == Math.Pow(DoanBC, 2)) || (Math.Pow(DoanBC, 2) + Math.Pow(DoanAC, 2) == Math.Pow(DoanAB, 2)))
                {
                    Console.WriteLine("Là tam giác vuông");
                }
                else
                {
                    Console.WriteLine("Là tam giác thường");
                }
            }
         
        }
    }
}
