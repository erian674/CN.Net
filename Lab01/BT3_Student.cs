using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Tính kế thừa và Tính đa hình trong Lập trình hướng đối tượng
namespace Lab01
{
    internal class BT3_Student
    {
        class Person
        {
            // Các thuộc tính của lớp Person
            private string fullName;
            private int birthYear;
            private string degree;
            public string FullName { get => fullName; set => fullName = value; }
            public int BirthYear { get => birthYear; set => birthYear = value; }
            public string Degree { get => degree; set => degree = value; }
            // Constructor mặc định
            public Person()
            {
                FullName = "NO NAME";
                BirthYear = 1900;
                Degree = "Đại học";
            }
            // Constructor có tham số
            public Person(string fullName, int birthYear, string degree)
            {
                FullName = fullName;
                BirthYear = birthYear;
                Degree = degree;
            }
            // Phương thức hiển thị thông tin của Person
            public virtual void Display()
            {
                Console.WriteLine($"Họ tên: {FullName}");
                Console.WriteLine($"Năm sinh: {BirthYear}");
                Console.WriteLine($"Bằng cấp: {Degree}");
            }
            // Phương thức ToString để trả về chuỗi đại diện cho đối tượng Person
            public override string ToString()
            {
                return $"{FullName} - {BirthYear} - {Degree}";
            }

        }
        // Lớp Student kế thừa từ lớp Person
        class Student : Person
        {
            // Các thuộc tính của lớp Student
            private int studentID;
            private string faculty;
            private float mark;
            public int StudentID { get => studentID; set => studentID = value; }
            public string Faculty { get => faculty; set => faculty = value; }
            public float Mark { get => mark; set => mark = value; }
            // Constructor mặc định
            public Student() : base()
            {
                StudentID = 1;
                Faculty = "A";
                Mark = 0;
            }
            // Constructor có tham số
            public Student(int id, string fullName, int birthYear, string degree,
                           string faculty, float mark)
                : base(fullName, birthYear, degree)
            {
                StudentID = id;
                Faculty = faculty;
                Mark = mark;
            }
            // Phương thức hiển thị thông tin của Student, ghi đè phương thức Display của lớp Person
            public override void Display()
            {
                Console.WriteLine("=================================");
                Console.WriteLine($"MSSV: {StudentID}");
                base.Display();
                Console.WriteLine($"Khoa: {Faculty}");
                Console.WriteLine($"Điểm trung bình: {Mark}");
                Console.WriteLine("=================================");
            }
            // Phương thức ToString để trả về chuỗi đại diện cho đối tượng Student, ghi đè phương thức ToString của lớp Person
            public override string ToString()
            {
                return $"MSSV: {StudentID} - {FullName} - {Faculty} - {Mark}";
            }
            // Phương thức để nhập thông tin của Student từ bàn phím
            public void InputData()
            {
                Console.Write("  Mã số sinh viên: ");
                StudentID = int.Parse(Console.ReadLine());

                Console.Write("  Họ tên: ");
                FullName = Console.ReadLine();

                Console.Write("  Năm sinh: ");
                BirthYear = int.Parse(Console.ReadLine());

                Console.Write("  Bằng cấp: ");
                Degree = Console.ReadLine();

                Console.Write("  Khoa: ");
                Faculty = Console.ReadLine();

                Console.Write("  Điểm trung binh: ");
                Mark = float.Parse(Console.ReadLine());
            }
        }
        // Lớp Tester để kiểm tra chương trình
        class Tester
        {
            // Phương thức để nhập thông tin của một sinh viên từ bàn phím và trả về đối tượng Student
            private static Student InputOneStudent(int index)
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ {index + 1}");
                Console.WriteLine("=================================");
                Student st = new Student();
                st.InputData();
                return st;
            }
            // Phương thức để nhập thông tin của n sinh viên và trả về một danh sách các đối tượng Student
            private static ArrayList InputStudentList(int n)
            {
                ArrayList students = new ArrayList();
                for (int i = 0; i < n; i++)
                {
                    students.Add(Tester.InputOneStudent(i));
                }
                return students;
            }
            // Phương thức để hiển thị thông tin của tất cả các sinh viên trong danh sách
            private static void DisplayStudentList(ArrayList students)
            {
                Console.WriteLine("====== DANH SÁCH SINH VIÊN ======");
                int i = 1;
                foreach (Student student in students)
                {
                    Console.WriteLine($"--- Sinh viên thứ {i++} ---");
                    student.Display();
                }

            }
            // Phương thức Main để chạy chương trình
            public static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8; // Hỗ trợ in tiếng Việt ra màn hình (Output)
                Console.InputEncoding = Encoding.UTF8;
                // Nhập số lượng sinh viên từ bàn phím
                int n;
                Console.Write("Nhập vào số lượng sinh viên:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("=================================");
                // Nhập thông tin của n sinh viên và lưu vào một danh sách
                var DSSV = InputStudentList(n);
                DisplayStudentList(DSSV);

                Console.ReadLine();
            }
        }
    }
}
