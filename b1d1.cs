using System;
using System.Text;
namespace New_folder
{
    class Program
    {
       
        public static void nhap()
        {
            int dlt=0;
            int dth=0;
           do
           {
               Console.WriteLine("nhập diem lt");
               dlt=int.Parse(Console.ReadLine());
           }
           while(dlt<0||dlt>10);

           do{
                Console.WriteLine("nhập diem th");
               dth=int.Parse(Console.ReadLine());
           }
           while(dth<0||dth>10);
           ketqua(dlt,dth);
        }
        public static bool ketqua(int lt,int th)
        {
            if(lt<5)
            {
                Console.WriteLine("trượt ly thuyet k dc thi th");
            }
            else if(lt>5&&th<5)
            {
                Console.WriteLine("truot th");
            }
            else
            {
                Console.WriteLine("do");
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do{
                nhap();
                Console.WriteLine("thoat?");
            }
            while
            (Console.ReadLine()!="y");
        }
    }
}
