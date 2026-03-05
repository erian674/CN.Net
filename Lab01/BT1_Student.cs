using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Thực hành xây dựng lớp theo Lập trình hướng đối tượng
namespace Lab01
{
    internal class BT1_Student
    {
        //Khai báo các thuộc tính của sinh viên
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        //Constructor mặc định
        public BT1_Student()
        {
            SID = 1;
            TenSV = "Nguyễn Văn A";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        //Constructor sao chép
        public BT1_Student(BT1_Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa= stu.Khoa;
            DiemTB= stu.DiemTB;
        }
        //Constructor có tham số
        public BT1_Student(int id, string ten, string khoa, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = khoa;
            DiemTB = dtb;
        }
        //Các thuộc tính get/set
        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        //Phương thức hiển thị thông tin sinh viên
        public void show(int thuTu)
        {
            Console.WriteLine("Thông tin sinh viên thứ {0}:", thuTu);
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Họ tên: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Điểm trung bình: {0}", this.DiemTB);
            Console.WriteLine("--------------------------------------");
        }
    }
    //Lớp Tester để kiểm tra các phương thức của lớp BT1_Student
    class Tester
    {
        //Phương thức Main để nhập và xuất thông tin sinh viên
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Hỗ trợ in tiếng Việt ra màn hình (Output)
            Console.InputEncoding = Encoding.UTF8;
            //Tạo một mảng đối tượng BT1_Student để lưu thông tin sinh viên
            BT1_Student[] DSSV;
            int n;
            Console.Write("Nhập vào số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new BT1_Student[n];
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("=== NHẬP DANH SÁCH SINH VIÊN ===");
            Console.WriteLine("--------------------------------------");
            //Nhập thông tin sinh viên từ bàn phím
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new BT1_Student();
                Console.Write("Nhập mssv {0}:  ", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Nhập họ tên: ");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhập khoa: ");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhập điểm trung bình: ");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------");
            }
            //Xuất thông tin sinh viên
            Console.WriteLine("=== XUẤT DANH SÁCH SINH VIÊN ====");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < DSSV.Length; i++)
            {
                DSSV[i].show(i + 1);
            }
            Console.ReadLine();
        }
    }
}
