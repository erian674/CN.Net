using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class BT3_BT4
    {
        // Lớp Account đại diện cho một tài khoản ngân hàng
        public class Account
        {
            // Các trường dữ liệu để lưu trữ thông tin tài khoản
            private string accountID; 
            private string firstName;
            private string lastName;
            private decimal balance;
            // Các thuộc tính để truy cập và sửa đổi thông tin tài khoản
            public string AccountID
            {
                get { return accountID; }
                set { accountID = value; }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public decimal Balance
            {
                get { return balance; }
                set { balance = value; }
            }
            // Constructor mặc định để khởi tạo tài khoản với giá trị mặc định
            public Account()
            {
                accountID = "";
                firstName = "";
                lastName = "";
                balance = 0;
            }
            // Constructor có tham số để khởi tạo tài khoản với thông tin cụ thể
            public Account(string id, string fname, string lname, decimal bal)
            {
                accountID = id;
                firstName = fname;
                lastName = lname;
                balance = bal;
            }
            // Phương thức để nhập thông tin tài khoản từ người dùng
            public void FillInfo()
            {
                Console.Write("Account ID: ");
                accountID = Console.ReadLine();

                Console.Write("First Name: ");
                firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                lastName = Console.ReadLine();

                Console.Write("Balance: ");
                balance = decimal.Parse(Console.ReadLine());
            }
            // Phương thức để hiển thị thông tin tài khoản
            public void Query()
            {
                Console.WriteLine("Account ID: {0} | Name: {1} {2} | Balance: {3}",
                    accountID, firstName, lastName, balance);
            }
            // Phương thức để chuyển đổi thông tin tài khoản thành chuỗi định dạng để lưu vào file
            public override string ToString()
            {
                return string.Format("{0},{1},{2},{3}", accountID, firstName, lastName, balance);
            }
        }
        // Lớp AccountList để quản lý danh sách các tài khoản
        public class AccountList
        {
            // Sử dụng ArrayList để lưu trữ danh sách tài khoản
            private ArrayList Accounts = new ArrayList();
            // Phương thức để thêm một tài khoản mới vào danh sách
            public void NewAccount()
            {
                // Tạo một đối tượng Account mới và nhập thông tin từ người dùng
                Account acc = new Account();
                acc.FillInfo();
                Accounts.Add(acc);
                Console.WriteLine("Account added successfully!\n");
            }
            // Phương thức để hiển thị tất cả các tài khoản trong danh sách
            public void Report()
            {
                // Kiểm tra nếu danh sách tài khoản rỗng
                if (Accounts.Count == 0)
                {
                    Console.WriteLine("No accounts in the list!\n");
                    return;
                }

                Console.WriteLine("\n========== ACCOUNT LIST ==========");
                // Duyệt qua từng tài khoản và hiển thị thông tin
                foreach (Account acc in Accounts)
                {
                    acc.Query();
                }
                Console.WriteLine("==================================\n");
            }
            // Phương thức để lưu danh sách tài khoản vào một file
            public void SaveFile()
            {
                // Sử dụng khối try-catch để xử lý lỗi khi làm việc với file
                try
                {
                    Console.Write("Input file name to save:");
                    string filename = Console.ReadLine();
                    // Tạo FileStream để ghi file
                    FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
                    // Tạo StreamWtiter
                    StreamWriter writer = new StreamWriter(output);
                    // Duyệt qua từng tài khoản và ghi vào file
                    foreach (Account acc in Accounts)
                    {
                        writer.WriteLine("{0},{1},{2},{3}",
                        acc.AccountID, acc.FirstName, acc.LastName, acc.Balance);
                    }
                    // Đóng kết nối
                    writer.Close();
                    output.Close();

                    Console.WriteLine("File saved successfully!\n");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            // Phương thức để tải danh sách tài khoản từ một file
            public void LoadFile()
            {
                // Sử dụng khối try-catch để xử lý lỗi khi làm việc với file
                try
                {
                    Console.Write("Input file name to load:");
                    string filename = Console.ReadLine();
                    // Xóa danh sách hiện tại
                    Accounts.Clear();
                    // Tạo FileStream để đọc file
                    FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    // Tạo StreamReader
                    StreamReader reader = new StreamReader(input);
                    // Đọc từng dòng
                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        // Tách chuỗi thành các phần bởi dấu phẩy
                        string[] list = str.Split(',');
                        // Tạo đối tượng
                        Account acc = new Account(
                                list[0],                          
                                list[1],                          
                                list[2],                          
                                decimal.Parse(list[3])            
                            );
                        // Thêm vào danh sách
                        Accounts.Add(acc);
                    }
                    // Đóng kết nối
                    reader.Close();
                    input.Close();

                    Console.WriteLine("File loaded successfully!\n");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        // Lớp Program chứa phương thức Main để chạy chương trình
        class Program
        {
            static void Main(string[] args)
            {
                // Tạo một đối tượng AccountList để quản lý danh sách tài khoản
                AccountList accountList = new AccountList();
                string command;

                Console.WriteLine("========== ACCOUNT MANAGEMENT SYSTEM ==========\n");
                // Vòng lặp chính để hiển thị menu và xử lý các lệnh từ người dùng
                while (true)
                {
                    Console.WriteLine("\n----- MENU -----");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Save");
                    Console.WriteLine("3. Load");
                    Console.WriteLine("4. Report");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter command: ");
                    command = Console.ReadLine();
                    // Sử dụng switch-case để xử lý các lệnh từ người dùng
                    switch (command)
                    {
                        case "1":
                            accountList.NewAccount();
                            break;

                        case "2":
                            accountList.SaveFile();
                            break;

                        case "3":
                            accountList.LoadFile();
                            break;

                        case "4":
                            accountList.Report();
                            break;

                        case "5":
                            Console.WriteLine("Program terminated!");
                            return;

                        default:
                            Console.WriteLine("Invalid command! Please try again.\n");
                            break;
                    }
                }
            }
        }
    }
}
