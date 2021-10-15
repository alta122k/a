using System;
using System.Text;

namespace Bai2
{
   class Item
    {
        private string tenmuc;
        private float soluong;
        private float gia;
        public float SoLuong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }
        public string TenMuc
        {
            get
            {
                return tenmuc;
            }

            set
            {
                tenmuc = value;
            }
        }

        public float Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }
        public Item()
        {
            tenmuc = "";
            gia = 0;
            soluong = 0;
        }
        public void nhap()
        {
            Console.Write("Nhập tên mục:");
            TenMuc = Console.ReadLine();
            Console.Write("Nhập số lượng:");
            SoLuong = float.Parse(Console.ReadLine());
            Console.Write("Nhập giá bán:");
            Gia = float.Parse(Console.ReadLine());
        }
        public void hien()
        {
            
            Console.Write("{0}\t{1}\t{2}\t", TenMuc,SoLuong, Gia);
        }
        public float tinhtien()
        {
            return SoLuong * Gia;
        }
    }
    class Item_KM: Item
    {
        private float KhuyenMai;
        public float khuyenmai
        {
            get
            {
                return KhuyenMai;
            }

            set
            {
                KhuyenMai = value;
            }
        }
        public Item_KM()
        {
            TenMuc = "";
            Gia = 0;
            SoLuong = 0;
            KhuyenMai = 0;
        }
        /*
         - Phương thức khởi tạo không tham số với việc khởi tạo các thành phần dữ liệu kiểu s
            à 0 và kiểu xâu là xâu rỗng
            - Phương thức “nhap” để nhập thông tin cho mục hóa đơn
            - Phương thức “hienThi” để in thông tin mục hóa đơn ra màn hình
            - Phương “tinhTien” để tính tiền cho một mục hóa đơn(=soLuong* gia*(1-
            KhuyenMai))
         */
        public void Nhap()
        {
            base.nhap();
            do
            {
                Console.Write("Nhập khuyến mại:");
                KhuyenMai = float.Parse(Console.ReadLine());
            } while (KhuyenMai < 0 || KhuyenMai >= 1);
            
            
        }
        public void Hien()
        {
            Console.WriteLine("Tên mục\t Số lượng\t Giá bán\tKhuyen mai");
            base.hien();
            Console.Write(KhuyenMai);
        }
        public float Tinh()
        {
            return base.tinhtien() * (1 - KhuyenMai);
        }
    }
    class Bill
    {
        private string maKH, tenKH; //số điện thoại khách hàng và Tên khách hàng
        private Item[] items;
    }
    class Program
    {

        static void Main(string[] args)
        {
            Item item=new Item();
            item.nhap();
            item.hien();
            Console.ReadKey();
        }
    }
}



