using System.Globalization;
using System;
using System.Linq;
using System.Text;
namespace New_folder
{
     class item
    {
        private string tenMuc; //Tên mục hóa đơn
        private float soLuong; //Số lượng
        private float gia; //Giá tiền 
        public string tenmuc{
            get
            {
                return tenMuc;
            }
            set{
                tenMuc=value;
            }
        }
        public float SoLuong
        {
        get
            {
                return soLuong;
            }
            set{
                soLuong=value;
            }
        } 
        public float Gia{
            get
            {
                return gia;
            }
            set{
                gia=value;
            }
        }
        public item()
        {
            tenMuc="";
            soLuong=0;
            gia=0;
        }
        public virtual void nhap()
        {
            Console.WriteLine("tenmuc");
            tenmuc=Console.ReadLine();
            Console.Write("Nhập số lượng:");
            SoLuong = float.Parse(Console.ReadLine());
            Console.Write("Nhập giá bán:");
            Gia = float.Parse(Console.ReadLine());
        }
        public virtual void hien()
        {
            
            Console.WriteLine("{0}\t{1}\t{2}\t", tenmuc,SoLuong, Gia);
        }
        public virtual float tinhtien()
        {
            return SoLuong*Gia;
        }
    }
    class khuyenmai:item{
        private float Khuyenmai;
        public float KhuyenMai{
            get{
                return Khuyenmai;
            }
            set{
                Khuyenmai=value;
            }
        }
        public khuyenmai()
        {
                Khuyenmai=0;
                tenmuc="";
                SoLuong=0;
                Gia=0;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap gia khuyen mai");
            KhuyenMai=float.Parse(Console.ReadLine());
        }
        public override void hien()
        {
            Console.WriteLine("Tên mục\t Số lượng\t Giá bán\tKhuyen mai\ttong tien");
            base.hien();
             Console.WriteLine("\t" + KhuyenMai + "%\t\t\t" + tinhtien() + "\n");
        }
        public override float tinhtien()
        {
            return SoLuong* Gia*(1-KhuyenMai);
        }
    }
    class Bill{
        private string maKH, tenKH; //số điện thoại khách hàng và Tên khách hàng
        private item []items; //Các mục hóa đơn 
        public void nhap()
        {
            Console.WriteLine("ma kh");
            maKH=Console.ReadLine();
            Console.WriteLine("ten kh");
            tenKH=Console.ReadLine();
             Console.WriteLine("nhap so luong muc hoa dơn");
             items= new item[int.Parse(Console.ReadLine())];
              for (int i = 0; i < items.Count(); i++)
            {
                Console.WriteLine("Nhap san pham thu " + (i + 1));

                items[i] = new khuyenmai();
                items[i].nhap();
            }
        }
        public void hien(){
             Console.WriteLine("Ma kh " + maKH);
            Console.WriteLine("Ten kh: " + tenKH);
    
            Console.Write("Ten sp" + "\t\t" + "Sl" + "\t\t" + "Gia" + "\t\t" + "Khuyến mãi" + "\t\t" + "Thành tiền" + "\n");
             for (int i = 0; i < items.Count(); i++)
            {
                items[i].hien();
            }
        }
         public double TongTien()
        {
            double tt = 0;
            for (int i = 0; i < items.Count(); i++)
            {
                tt = tt + items[i].tinhtien();
            }
            return tt;
        }
    }
    class Program
    {      
       
        static void Main(string[] args)
        { 
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Bill ds = new Bill();
            ds.nhap();
            ds.hien();
            Console.WriteLine("Tổng tiền của hóa đơn la =" + ds.TongTien());
            Console.ReadKey();
           
        }
    }
}
