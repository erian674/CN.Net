using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dùng lập trình hướng đối tượng để xây dựng 1 ứng dụng quản lý thực tế hoàn chỉnh
namespace Lab01
{
    internal class BT4_Student
    {
        // Lớp trừu tượng Employee
        abstract class Employee
        {
            // Thuộc tính chung cho tất cả nhân viên
            public string FullName { get; set; }
            public int BirthYear { get; set; }
            public string Degree { get; set; }
            // Constructor mặc định
            protected Employee()
            {
                FullName = "Trần Văn A";
                BirthYear = 1980;
                Degree = "Đại học";
            }
            // Constructor có tham số
            protected Employee(string fullName, int birthYear, string degree)
            {
                FullName = fullName;
                BirthYear = birthYear;
                Degree = degree;
            }
            // Phương thức trừu tượng để tính lương
            public abstract float CalculateSalary();
            // Phương thức hiển thị thông tin chung của nhân viên
            public virtual void Display()
            {
                Console.WriteLine($"Họ tên: {FullName}");
                Console.WriteLine($"Năm sinh: {BirthYear}");
                Console.WriteLine($"Bằng cấp: {Degree}");
                Console.WriteLine($"Lương: {CalculateSalary():N0}");
            }
        }
        // Lớp Manager kế thừa từ Employee
        class Manager : Employee
        {
            // Thuộc tính riêng của Manager
            public string Position { get; set; }
            public int WorkDaysPerMonth { get; set; }
            public float SalaryGrade { get; set; }
            // Constructor mặc định
            public Manager() : base()
            {
                Position = "Trưởng phòng";
                WorkDaysPerMonth = 20;
                SalaryGrade = 600000;
            }
            // Constructor có tham số
            public Manager(string fullName, int birthYear, string degree,
                           string position, int workDaysPerMonth, float salaryGrade)
                : base(fullName, birthYear, degree)
            {
                Position = position;
                WorkDaysPerMonth = workDaysPerMonth;
                SalaryGrade = salaryGrade;
            }
            // Phương thức nhập dữ liệu cho Manager
            public virtual void InputData()
            {
                Console.Write("    Họ tên: ");
                FullName = Console.ReadLine();
                Console.Write("    Năm sinh: ");
                BirthYear = int.Parse(Console.ReadLine());
                Console.Write("    Bằng cấp: ");
                Degree = Console.ReadLine();
                Console.Write("    Chức vụ: ");
                Position = Console.ReadLine();
                Console.Write("    Số ngày công trong tháng: ");
                WorkDaysPerMonth = int.Parse(Console.ReadLine());
                Console.Write("    Bậc lương: ");
                SalaryGrade = float.Parse(Console.ReadLine());
            }
            // Phương thức tính lương cho Manager
            public override float CalculateSalary()
            {
                return WorkDaysPerMonth * SalaryGrade;
            }
            // Phương thức hiển thị thông tin cho Manager, ghi đè phương thức Display của lớp Employee
            public override void Display()
            {
                Console.WriteLine("========= NHÀ QUAN LÝ =========");
                base.Display();
                Console.WriteLine($"Chức vụ: {Position}");
                Console.WriteLine($"Ngày công: {WorkDaysPerMonth}");
                Console.WriteLine("================================");
            }
        }
        // Lớp Scientist kế thừa từ Manager
        class Scientist : Manager
        {
            // Thuộc tính riêng của Scientist
            public int PapersPublished { get; set; }
            // Constructor mặc định
            public Scientist() : base()
            {
                Position = "Nhân viên";
                PapersPublished = 0;
                WorkDaysPerMonth = 20;
                SalaryGrade = 500000;
            }
            // Constructor có tham số
            public Scientist(string fullName, int birthYear, string degree,
                            string position, int papersPublished,
                            int workDaysPerMonth, float salaryGrade)
                : base(fullName, birthYear, degree, position, workDaysPerMonth, salaryGrade)
            {
                PapersPublished = papersPublished;
            }
            // Phương thức nhập dữ liệu cho Scientist, ghi đè phương thức InputData của lớp Manager
            public override void InputData()
            {
                Console.Write("    Họ tên: ");
                FullName = Console.ReadLine();
                Console.Write("    Năm sinh: ");
                BirthYear = int.Parse(Console.ReadLine());
                Console.Write("    Bằng cấp: ");
                Degree = Console.ReadLine();
                Console.Write("    Chức vụ: ");
                Position = Console.ReadLine();
                Console.Write("    Số bài báo đã công bố: ");
                PapersPublished = int.Parse(Console.ReadLine());
                Console.Write("    Số ngày công trong tháng: ");
                WorkDaysPerMonth = int.Parse(Console.ReadLine());
                Console.Write("    Bậc lương: ");
                SalaryGrade = float.Parse(Console.ReadLine());
            }
            // Phương thức tính lương cho Scientist, ghi đè phương thức CalculateSalary của lớp Manager
            public override float CalculateSalary()
            {
                float baseSalary = WorkDaysPerMonth * SalaryGrade;
                float bonus = PapersPublished * 50000;
                return baseSalary + bonus;
            }
            // Phương thức hiển thị thông tin cho Scientist, ghi đè phương thức Display của lớp Manager
            public override void Display()
            {
                Console.WriteLine("========= NHÀ KHOA HỌC (CÓ QUẢN LÝ) =========");
                Console.WriteLine($"Họ tên: {FullName}");
                Console.WriteLine($"Năm sinh: {BirthYear}");
                Console.WriteLine($"Bằng cấp: {Degree}");
                Console.WriteLine($"Chức vụ: {Position}");
                Console.WriteLine($"Số bài báo: {PapersPublished}");
                Console.WriteLine($"Ngày công: {WorkDaysPerMonth}");
                Console.WriteLine($"Bậc lương: {SalaryGrade:N0}");
                Console.WriteLine($"Lương cơ bản: {WorkDaysPerMonth * SalaryGrade:N0}");
                Console.WriteLine($"Thưởng (bài báo): {PapersPublished * 50000:N0}");
                Console.WriteLine($"Tổng lượng: {CalculateSalary():N0}");
                Console.WriteLine("==========================================");
            }
        }
        // Lớp LabTechnician kế thừa từ Employee
        class LabTechnician : Employee
        {
            // Thuộc tính riêng của LabTechnician
            public float MonthlySalary { get; set; }
            // Constructor mặc định
            public LabTechnician() : base()
            {
                MonthlySalary = 3000000;
            }
            // Constructor có tham số
            public LabTechnician(string fullName, int birthYear, string degree,
                                float monthlySalary)
                : base(fullName, birthYear, degree)
            {
                MonthlySalary = monthlySalary;
            }
            // Phương thức nhập dữ liệu cho LabTechnician
            public void InputData()
            {
                Console.Write("    Họ tên: ");
                FullName = Console.ReadLine();
                Console.Write("    Năm sinh: ");
                BirthYear = int.Parse(Console.ReadLine());
                Console.Write("    Bằng cấp: ");
                Degree = Console.ReadLine();
                Console.Write("    Lương trong tháng: ");
                MonthlySalary = float.Parse(Console.ReadLine());
            }
            // Phương thức tính lương cho LabTechnician
            public override float CalculateSalary()
            {
                return MonthlySalary;
            }
            // Phương thức hiển thị thông tin cho LabTechnician, ghi đè phương thức Display của lớp Employee
            public override void Display()
            {
                Console.WriteLine("===== NHÂN VIÊN PHÒNG THÍ NGHIỆM =====");
                base.Display();
                Console.WriteLine("========================================");
            }
        }
        // Lớp Tester để kiểm tra chương trình
        class Tester
        {
            // Danh sách để lưu trữ tất cả nhân viên
            private static List<Employee> employees = new List<Employee>();
            // Phương thức hiển thị menu chức năng
            private static void ShowMenu()
            {
                Console.WriteLine("===== QUẢN LÝ NHÂN SỰ VIỆN KHOA HỌC =====");
                Console.WriteLine("1. Thêm nhà khoa học");
                Console.WriteLine("2. Thêm nhà quản lý");
                Console.WriteLine("3. Thêm nhân viên phòng thí nghiệm");
                Console.WriteLine("4. Hiển thị danh sách nhân viên");
                Console.WriteLine("5. Tính tổng lương từng loại");
                Console.WriteLine("6. Thoát chương trình");
                Console.Write("Chọn chức năng (1-6): ");
            }
            // Phương thức để thêm một nhà khoa học mới vào danh sách
            private static void AddScientist()
            {
                Console.WriteLine("Nhập thông tin nhà khoa học: ");
                var scientist = new Scientist();
                scientist.InputData();
                employees.Add(scientist);
                Console.WriteLine("✓ Thêm nhà khoa học thành công!");
            }
            // Phương thức để thêm một nhà quản lý mới vào danh sách
            private static void AddManager()
            {
                Console.WriteLine("Nhập thông tin nhà quản lý: ");
                var manager = new Manager();
                manager.InputData();
                employees.Add(manager);
                Console.WriteLine("✓ Thêm nhà quản lý thành công!");
            }
            // Phương thức để thêm một nhân viên phòng thí nghiệm mới vào danh sách
            private static void AddLabTechnician()
            {
                Console.WriteLine("Nhập thông tin nhân viên phòng thí nghiệm: ");
                var technician = new LabTechnician();
                technician.InputData();
                employees.Add(technician);
                Console.WriteLine("✓ Thêm nhân viên phòng thí nghiệm thành công!");
            }
            // Phương thức để hiển thị tất cả nhân viên trong danh sách
            private static void DisplayAllEmployees()
            {
                Console.WriteLine("===== DANH SÁCH NHÂN VIÊN =====");
                if (employees.Count == 0)
                {
                    Console.WriteLine("Danh sách trống!");
                    return;
                }

                int index = 1;
                foreach (var employee in employees)
                {
                    Console.WriteLine($"--- Nhân viên thứ {index} ---");
                    employee.Display();
                    index++;
                }
            }
            // Phương thức để tính tổng lương cho từng loại nhân viên và hiển thị kết quả
            private static void CalculateTotalSalaries()
            {
                // Biến để lưu tổng lương của từng loại nhân viên
                float scientistSalary = 0;
                float managerSalary = 0;
                float technicianSalary = 0;
                // Duyệt qua danh sách nhân viên và cộng dồn lương theo từng loại
                foreach (var employee in employees)
                {
                    if (employee is Scientist)
                    {
                        scientistSalary += employee.CalculateSalary();
                    }
                    else if (employee is Manager)
                    {
                        managerSalary += employee.CalculateSalary();
                    }
                    else if (employee is LabTechnician)
                    {
                        technicianSalary += employee.CalculateSalary();
                    }
                }
                // Hiển thị tổng lương cho từng loại nhân viên và tổng cộng
                Console.WriteLine("===== TỔNG LƯƠNG CHI TRẢ =====");
                Console.WriteLine($"Tổng lương nhà khoa học: {scientistSalary:N0}");
                Console.WriteLine($"Tổng lương nhà quản lý: {managerSalary:N0}");
                Console.WriteLine($"Tổng lương nhân viên phòng thí nghiệm: {technicianSalary:N0}");
                Console.WriteLine($"{'=',-30}");
                Console.WriteLine($"Tổng cộng: {scientistSalary + managerSalary + technicianSalary:N0}");
            }
            // Phương thức Main để chạy chương trình
            public static void Main()
            {
                Console.OutputEncoding = Encoding.UTF8; // Hỗ trợ in tiếng Việt ra màn hình (Output)
                Console.InputEncoding = Encoding.UTF8;
                int choice;
                // Vòng lặp để hiển thị menu và xử lý lựa chọn của người dùng
                do
                {
                    ShowMenu();
                    choice = int.Parse(Console.ReadLine());
                    // Xử lý lựa chọn của người dùng bằng cách gọi các phương thức tương ứng
                    switch (choice)
                    {
                        // Các case tương ứng với từng chức năng trong menu
                        case 1:
                            AddScientist();
                            break;
                        case 2:
                            AddManager();
                            break;
                        case 3:
                            AddLabTechnician();
                            break;
                        case 4:
                            DisplayAllEmployees();
                            break;
                        case 5:
                            CalculateTotalSalaries();
                            break;
                        case 6:
                            Console.WriteLine("Tạm biệt!");
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ!");
                            break;
                    }
                } while (choice != 6);

                Console.ReadLine();
            }
        }
    }
}
