using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Thực hành đóng gói dữ liệu bằng get/set và xây dựng lớp theo Lập trình hướng đối tượng
namespace Lab01
{
    internal class BT2_Student
    {
        class Student
        {
            //Khai báo các thuộc tính của sinh viên
            private int SID;
            private string TenSV;
            private string Khoa;
            private float DiemTB;

            //Constructor mặc định
            public Student()
            {
                SID = 1;
                TenSV = "Nguyễn Văn Nam";
                Khoa = "CNTT";
                DiemTB = 7;
            }
            //Constructor có tham số
            public Student(int id, string ten, string kh, float dtb)
            {
                SID = id;
                TenSV = ten;
                Khoa = kh;
                DiemTB = dtb;
            }
            //Các thuộc tính get/set
            public int GetSID()
            {
                return SID;
            }
            public void SetSID(int id)
            {
                SID = id;
            }
            public string GetTenSV()
            {
                return TenSV;
            }
            public void SetTenSV(string ten)
            {
                TenSV = ten;
            }
            public string GetKhoa()
            {
                return Khoa;
            }
            public void SetKhoa(string kh)
            {
                Khoa = kh;
            }
            public float GetDiemTB()
            {
                return DiemTB;
            }
            public void SetDiemTB(float diem)
            {
                DiemTB = diem;
            }
            //Phương thức hiển thị thông tin sinh viên
            public void Show(int thuTu)
            {
                Console.WriteLine("Thông tin sinh viên thứ {0}:", thuTu);
                Console.WriteLine("MSSV: {0}", this.SID);
                Console.WriteLine("Họ tên: {0}", this.TenSV);
                Console.WriteLine("Khoa: {0}", this.Khoa);
                Console.WriteLine("Điểm trung bình: {0}", this.DiemTB);
                Console.WriteLine("--------------------------------------");
            }
            //Phương thức nhập thông tin sinh viên
            public void Nhap1SV()
            {
                Console.Write("Nhập mssv: ");
                SID = int.Parse(Console.ReadLine());
                Console.Write("Nhập họ tên: ");
                TenSV = Console.ReadLine();
                Console.Write("Nhập khoa: ");
                Khoa = Console.ReadLine();
                Console.Write("Nhập điểm trung bình: ");
                DiemTB = float.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------");
            }
        }
        //Lớp Tester để kiểm tra chương trình
        class Tester
        {
            //Phương thức Main để chạy chương trình
            public static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8; // Hỗ trợ in tiếng Việt ra màn hình (Output)
                Console.InputEncoding = Encoding.UTF8;
                //Tạo mảng đối tượng sinh viên
                Student[] DSSV;
                int n;
                Console.Write("Nhập vào số lượng sinh viên: ");
                n = int.Parse(Console.ReadLine());
                DSSV = new Student[n];
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("=== NHẬP DANH SÁCH SINH VIÊN ===");
                Console.WriteLine("--------------------------------------");
                //Nhập thông tin cho từng sinh viên
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"-- Nhập thông tin sinh viên thứ {i + 1} --");
                    DSSV[i] = new Student();
                    DSSV[i].Nhap1SV();
                }
                //Xuất thông tin của tất cả sinh viên
                Console.WriteLine("=== XUẤT DANH SÁCH SINH VIÊN ====");
                Console.WriteLine("--------------------------------------");
                for (int i = 0; i < DSSV.Length; i++)
                {
                    DSSV[i].Show(i + 1);
                }
                Console.ReadLine();
            }
        }
    }
}
