using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class BT2_Student
    {
        class Student
        {
            // Các thuộc tính private (giữ nguyên như bài 1)
            private int SID;
            private string TenSV;
            private string Khoa;
            private float DiemTB;

            // Constructor mặc định
            public Student()
            {
                SID = 1;
                TenSV = "Nguyen Van Nam";
                Khoa = "CNTT";
                DiemTB = 7;
            }

            // Constructor tham số
            public Student(int id, string ten, string kh, float dtb)
            {
                SID = id;
                TenSV = ten;
                Khoa = kh;
                DiemTB = dtb;
            }

            // Cho SID
            public int GetSID()
            {
                return SID;
            }
            public void SetSID(int id)
            {
                SID = id;
            }

            // Cho TenSV
            public string GetTenSV()
            {
                return TenSV;
            }
            public void SetTenSV(string ten)
            {
                TenSV = ten;
            }

            // Cho Khoa
            public string GetKhoa()
            {
                return Khoa;
            }
            public void SetKhoa(string kh)
            {
                Khoa = kh;
            }

            // Cho DiemTB
            public float GetDiemTB()
            {
                return DiemTB;
            }
            public void SetDiemTB(float diem)
            {
                DiemTB = diem;
            }

            // --- CÁC PHƯƠNG THỨC CHỨC NĂNG ---

            // Phương thức hiển thị (giữ nguyên)
            public void Show()
            {
                Console.WriteLine("MSSV: {0}", this.SID);
                Console.WriteLine("Ten SV: {0}", this.TenSV);
                Console.WriteLine("Khoa: {0}", this.Khoa);
                Console.WriteLine("Diem TB: {0}", this.DiemTB);
                Console.WriteLine("-------------------");
            }
            public void Nhap1SV()
            {
                Console.Write("Nhap MaSV: ");
                SID = int.Parse(Console.ReadLine());

                Console.Write("Ho ten SV: ");
                TenSV = Console.ReadLine();

                Console.Write("Nhap khoa: ");
                Khoa = Console.ReadLine();

                Console.Write("Nhap Diem TB: ");
                DiemTB = float.Parse(Console.ReadLine());
            }
        }
        //class Tester
        //{
        //    public static void Main(string[] args)
        //    {
        //        BT1_Student[] DSSV;
        //        int n;
        //        Console.WriteLine("Nhap vao so luong SV:");
        //        n = int.Parse(Console.ReadLine());
        //        DSSV = new BT1_Student[n];
        //        Console.WriteLine("\n === NHAP DS SINH VIEN ===");
        //        for (int i = 0; i < n; i++)
        //        {
        //            DSSV[i] = new BT1_Student();
        //            Console.Write("Nhap masv {0}:  ", i + 1);
        //            DSSV[i].StudentID = int.Parse(Console.ReadLine());
        //            Console.Write("Ho ten SV: ");
        //            DSSV[i].Name = Console.ReadLine();
        //            Console.Write("Nhap Khoa: ");
        //            DSSV[i].Faculty = Console.ReadLine();
        //            Console.Write("Nhap diem tb: ");
        //            DSSV[i].Mark = float.Parse(Console.ReadLine());
        //        }

        //        Console.WriteLine("\n === XUAT DS SINH VIEN ====");
        //        foreach (BT1_Student sv in DSSV)
        //            sv.show();
        //        Console.ReadLine();

        //    }
        //}
    }
}
