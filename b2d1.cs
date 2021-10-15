using System;
using System.Text;

namespace Bai2
{
    struct SinhVien
    {
        public string Hoten, QueQuan,MaSinhVien,Lop;
        public void Nhap()
        {
            Console.Write("Quê quán: ");
            QueQuan = Console.ReadLine();
            Console.Write("Họ tên: ");
            Hoten = Console.ReadLine();
            Console.Write("Mã Sinh viên: ");
            MaSinhVien = Console.ReadLine();
            Console.Write("Lop: ");
            Lop = Console.ReadLine();
        }
        public void Hien()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", Hoten, QueQuan, MaSinhVien, Lop);
        }
    }
    class Node
    {
        public SinhVien info;
        public Node pnext;
    }
    class Links
    {
        public Node Head, Tail;
        public Links()
        {
            Head = Tail = null;
        }
        public Node GetNode(SinhVien A)
        {
            Node P = new Node();
            P.info = A;
            P.pnext = null;
            return P;
        }
        public void ThemCuoi(SinhVien A)
        {
            Node P = GetNode(A);
            if (Head == null)
            {
                Head = Tail = P;
            }
            else
            {
                Tail.pnext = P;
                Tail = P;
            }
        }
        public void ThemDau(SinhVien A)
        {
            Node P = GetNode(A);
            if (Head == null)
            {
                Head = Tail = P;
            }
            else
            {
                P.pnext = Head;
                Head = P;
            }
        }
        public void XoaCuoi()
        {
            for (Node P = Head; P!= null; P = P.pnext)
            {
                if(P.pnext.pnext == null)
                {
                    Tail = P;
                    P.pnext = null;
                }
                
            }
        }
        public void Nhap()
        {
            //int n;
            //do
            //{
            //    Console.Write("Số lượng sinh viên nhập vào là: ");
            //    n = int.Parse(Console.ReadLine());
            //} while (n <= 0);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sinh viên thứ: {0}", i + 1);
                SinhVien ThongTin = new SinhVien();
                ThongTin.Nhap();
                ThemDau(ThongTin);
            }
        }
        public void HienDau()
        {
            Head.info.Hien();
        }
        public void HienCuoi()
        {
            Tail.info.Hien();
        }
        public void HienThi()
        {
            for (Node P = Head; P != null; P = P.pnext)
            {
                P.info.Hien();
            }
        }
        public void DanhSachThuocQueQuan(string Y, out Links DanhSach)
        {
            DanhSach = new Links();
            if (Head == null)
            {
                throw new Exception("Danh sách ban đầu rỗng");
}
            else
            {
                Node P = Head;
                while (P != null)
                {
                    if (P.info.QueQuan.ToLower() == Y.ToLower())
                    {
                        DanhSach.ThemCuoi(P.info);
                    }
                    P = P.pnext;
                }
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Links DanhSach = new Links();
            int i = 0;
            do
            {
                Console.WriteLine("Nhập thông tin cho sinh viên");
                DanhSach.Nhap();
                Console.WriteLine("Bạn muốn thóa? Nhấn chữ y");
            } while (Console.ReadLine() != "y");

            Console.WriteLine("Hiện thị danh sách");
            DanhSach.HienThi();
            Console.WriteLine("Hiện thị đầu danh sách");
            DanhSach.HienDau();
            Console.WriteLine("Hiện thị danh sách sau khi xóa cuối");
            DanhSach.XoaCuoi();
            DanhSach.HienThi();
            Console.WriteLine("Hiện thị danh sách sinh thuộc Hà Nội");
            Links DanhSachTen = new Links();
            DanhSachTen = DanhSach;
            DanhSachTen.DanhSachThuocQueQuan("Ha Noi", out DanhSachTen);
            DanhSachTen.HienThi();
            Console.ReadKey();
        }
    }
}