using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class BT1_Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public BT1_Student()
        {
            SID = 1;
            TenSV = "Nguyen Van A";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public BT1_Student(BT1_Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa= stu.Khoa;
            DiemTB= stu.DiemTB;
        }

        public BT1_Student(int id, string ten, string khoa, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = khoa;
            DiemTB = dtb;
        }

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

        public void show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
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
    //        for(int i = 0; i < n; i++)
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
