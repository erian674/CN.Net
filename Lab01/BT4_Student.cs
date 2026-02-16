using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class BT4_Student
    {
        // Lớp trừu tượng cơ sở
        abstract class Employee
        {
            public string FullName { get; set; }
            public int BirthYear { get; set; }
            public string Degree { get; set; }

            protected Employee()
            {
                FullName = "Tran Van A";
                BirthYear = 1980;
                Degree = "Dai hoc";
            }

            protected Employee(string fullName, int birthYear, string degree)
            {
                FullName = fullName;
                BirthYear = birthYear;
                Degree = degree;
            }

            // Phương thức trừu tượng - bắt buộc lớp con phải triển khai
            public abstract float CalculateSalary();

            // Phương thức ảo
            public virtual void Display()
            {
                Console.WriteLine($"Ho ten: {FullName}");
                Console.WriteLine($"Nam sinh: {BirthYear}");
                Console.WriteLine($"Bang cap: {Degree}");
                Console.WriteLine($"Luong: {CalculateSalary():N0}");
            }
        }

        // Nhà quản lý (Lớp cơ sở)
        class Manager : Employee
        {
            public string Position { get; set; }
            public int WorkDaysPerMonth { get; set; }
            public float SalaryGrade { get; set; }

            public Manager() : base()
            {
                Position = "Truong phong";
                WorkDaysPerMonth = 20;
                SalaryGrade = 600000;
            }

            public Manager(string fullName, int birthYear, string degree,
                           string position, int workDaysPerMonth, float salaryGrade)
                : base(fullName, birthYear, degree)
            {
                Position = position;
                WorkDaysPerMonth = workDaysPerMonth;
                SalaryGrade = salaryGrade;
            }

            public virtual void InputData()
            {
                Console.Write("    Ho ten: ");
                FullName = Console.ReadLine();
                Console.Write("    Nam sinh: ");
                BirthYear = int.Parse(Console.ReadLine());
                Console.Write("    Bang cap: ");
                Degree = Console.ReadLine();
                Console.Write("    Chuc vu: ");
                Position = Console.ReadLine();
                Console.Write("    So ngay cong trong thang: ");
                WorkDaysPerMonth = int.Parse(Console.ReadLine());
                Console.Write("    Bac luong: ");
                SalaryGrade = float.Parse(Console.ReadLine());
            }

            public override float CalculateSalary()
            {
                return WorkDaysPerMonth * SalaryGrade;
            }

            public override void Display()
            {
                Console.WriteLine("========= NHA QUAN LY =========");
                base.Display();
                Console.WriteLine($"Chuc vu: {Position}");
                Console.WriteLine($"Ngay cong: {WorkDaysPerMonth}");
                Console.WriteLine("================================");
            }
        }

        // Nhà khoa học - kế thừa từ Nhà quản lý
        // (Nhà khoa học cũng có thể làm công tác quản lý)
        class Scientist : Manager
        {
            public int PapersPublished { get; set; }

            public Scientist() : base()
            {
                Position = "Nhan vien";
                PapersPublished = 0;
                WorkDaysPerMonth = 20;
                SalaryGrade = 500000;
            }

            public Scientist(string fullName, int birthYear, string degree,
                            string position, int papersPublished,
                            int workDaysPerMonth, float salaryGrade)
                : base(fullName, birthYear, degree, position, workDaysPerMonth, salaryGrade)
            {
                PapersPublished = papersPublished;
            }

            // Ghi đè InputData để thêm nhập số bài báo
            public override void InputData()
            {
                Console.Write("    Ho ten: ");
                FullName = Console.ReadLine();
                Console.Write("    Nam sinh: ");
                BirthYear = int.Parse(Console.ReadLine());
                Console.Write("    Bang cap: ");
                Degree = Console.ReadLine();
                Console.Write("    Chuc vu: ");
                Position = Console.ReadLine();
                Console.Write("    So bai bao da cong bo: ");
                PapersPublished = int.Parse(Console.ReadLine());
                Console.Write("    So ngay cong trong thang: ");
                WorkDaysPerMonth = int.Parse(Console.ReadLine());
                Console.Write("    Bac luong: ");
                SalaryGrade = float.Parse(Console.ReadLine());
            }

            // Tính lương: ngày công * bậc lương (giống Manager)
            // (Có thể thêm thưởng dựa trên số bài báo)
            public override float CalculateSalary()
            {
                float baseSalary = WorkDaysPerMonth * SalaryGrade;
                // Có thể thêm bonus: +50,000 cho mỗi bài báo
                float bonus = PapersPublished * 50000;
                return baseSalary + bonus;
            }

            // Ghi đè Display
            public override void Display()
            {
                Console.WriteLine("========= NHA KHOA HOC (CO QUAN LY) =========");
                Console.WriteLine($"Ho ten: {FullName}");
                Console.WriteLine($"Nam sinh: {BirthYear}");
                Console.WriteLine($"Bang cap: {Degree}");
                Console.WriteLine($"Chuc vu: {Position}");
                Console.WriteLine($"So bai bao: {PapersPublished}");
                Console.WriteLine($"Ngay cong: {WorkDaysPerMonth}");
                Console.WriteLine($"Bac luong: {SalaryGrade:N0}");
                Console.WriteLine($"Luong co ban: {WorkDaysPerMonth * SalaryGrade:N0}");
                Console.WriteLine($"Thuong (bai bao): {PapersPublished * 50000:N0}");
                Console.WriteLine($"Tong luong: {CalculateSalary():N0}");
                Console.WriteLine("==========================================");
            }
        }

        // Nhân viên phòng thí nghiệm
        class LabTechnician : Employee
        {
            public float MonthlySalary { get; set; }

            public LabTechnician() : base()
            {
                MonthlySalary = 3000000;
            }

            public LabTechnician(string fullName, int birthYear, string degree,
                                float monthlySalary)
                : base(fullName, birthYear, degree)
            {
                MonthlySalary = monthlySalary;
            }

            public void InputData()
            {
                Console.Write("    Ho ten: ");
                FullName = Console.ReadLine();
                Console.Write("    Nam sinh: ");
                BirthYear = int.Parse(Console.ReadLine());
                Console.Write("    Bang cap: ");
                Degree = Console.ReadLine();
                Console.Write("    Luong trong thang: ");
                MonthlySalary = float.Parse(Console.ReadLine());
            }

            public override float CalculateSalary()
            {
                return MonthlySalary;
            }

            public override void Display()
            {
                Console.WriteLine("===== NHAN VIEN PHONG THI NGHIEM =====");
                base.Display();
                Console.WriteLine("========================================");
            }
        }

        // Lớp Tester
        class Tester
        {
            private static List<Employee> employees = new List<Employee>();

            private static void ShowMenu()
            {
                Console.WriteLine("\n===== QUAN LY NHAN SU VIEN KHOA HOC =====");
                Console.WriteLine("1. Them nha khoa hoc");
                Console.WriteLine("2. Them nha quan ly");
                Console.WriteLine("3. Them nhan vien phong thi nghiem");
                Console.WriteLine("4. Hien thi danh sach nhan vien");
                Console.WriteLine("5. Tinh tong luong tung loai");
                Console.WriteLine("6. Thoat chuong trinh");
                Console.Write("Chon chuc nang (1-6): ");
            }

            private static void AddScientist()
            {
                Console.WriteLine("\nNhap thong tin nha khoa hoc:");
                var scientist = new Scientist();
                scientist.InputData();
                employees.Add(scientist);
                Console.WriteLine("✓ Them nha khoa hoc thanh cong!");
            }

            private static void AddManager()
            {
                Console.WriteLine("\nNhap thong tin nha quan ly:");
                var manager = new Manager();
                manager.InputData();
                employees.Add(manager);
                Console.WriteLine("✓ Them nha quan ly thanh cong!");
            }

            private static void AddLabTechnician()
            {
                Console.WriteLine("\nNhap thong tin nhan vien phong thi nghiem:");
                var technician = new LabTechnician();
                technician.InputData();
                employees.Add(technician);
                Console.WriteLine("✓ Them nhan vien phong thi nghiem thanh cong!");
            }

            private static void DisplayAllEmployees()
            {
                Console.WriteLine("\n===== DANH SACH NHAN VIEN =====");
                if (employees.Count == 0)
                {
                    Console.WriteLine("Danh sach trong!");
                    return;
                }

                int index = 1;
                foreach (var employee in employees)
                {
                    Console.WriteLine($"\n--- Nhan vien thu {index} ---");
                    employee.Display();
                    index++;
                }
            }

            private static void CalculateTotalSalaries()
            {
                float scientistSalary = 0;
                float managerSalary = 0;
                float technicianSalary = 0;

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

                Console.WriteLine("\n===== TONG LUONG CHI TRA =====");
                Console.WriteLine($"Tong luong nha khoa hoc: {scientistSalary:N0}");
                Console.WriteLine($"Tong luong nha quan ly: {managerSalary:N0}");
                Console.WriteLine($"Tong luong nhan vien phong thi nghiem: {technicianSalary:N0}");
                Console.WriteLine($"{'=',-30}");
                Console.WriteLine($"Tong cong: {scientistSalary + managerSalary + technicianSalary:N0}");
            }

            public static void Main()
            {
                int choice;

                do
                {
                    ShowMenu();
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
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
                            Console.WriteLine("Tam biet!");
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le!");
                            break;
                    }
                } while (choice != 6);

                Console.ReadLine();
            }
        }
    }
}
