using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class BT1_BT2
    {
        // Khai báo giao diện IBook với các thuộc tính và phương thức cần thiết
        public interface IBook
        {
            // Chỉ mục để quản lý các chương của sách
            string this[int id] { get; set; }
            // Các thuộc tính cơ bản của sách
            string Title { get; set; }
            string Author { get; set; }
            string Publisher { get; set; }
            int Year { get; set; }
            string ISBN { get; set; }
            // Phương thức để hiển thị thông tin sách
            void Show();
        }
        // Lớp Book triển khai giao diện IBook
        public class Book : IBook
        {
            // Các trường dữ liệu để lưu trữ thông tin sách
            private string isbn;
            private string title;
            private string author;
            private string publisher;
            private int year;
            // Sử dụng ArrayList để quản lý danh sách chương của sách
            private ArrayList chapter = new ArrayList();
            // Triển khai chỉ mục để quản lý các chương của sách
            public string this[int index]
            {
                // Lấy thông tin chương tại vị trí index
                get
                {
                    // Kiểm tra index hợp lệ trước khi truy cập
                    if (index >= 0 && index < chapter.Count)
                        return (string)chapter[index];
                    else
                        throw new IndexOutOfRangeException();
                }
                set
                {
                    // Kiểm tra index hợp lệ trước khi gán giá trị
                    if (index >=0  && index < chapter.Count)
                        chapter[index] = value;
                    else if (index == chapter.Count)
                        chapter.Add(value);
                    else
                        throw new IndexOutOfRangeException();
                }
            }
            // Triển khai các thuộc tính cơ bản của sách
            public string Title 
            { 
                get {return title;}
                set {title = value;}
            }
            public string Author 
            {
                get {return author;}
                set {author = value;}
            }
            public string Publisher 
            {
                get {return publisher;}
                set {publisher = value;}
            }
            public int Year 
            {
                get {return year;}
                set {year = value;}
            }
            public string ISBN 
            {
                get { return isbn;}
                set {isbn = value;}
            }
            // Các constructor để khởi tạo đối tượng Book
            // Constructor mặc định khởi tạo các thuộc tính với giá trị mặc định
            public Book()
            {
                isbn = "";
                title = "";
                author = "";
                publisher = "";
                year = 0;
                chapter = new ArrayList();
            }
            // Constructor có tham số để khởi tạo các thuộc tính với giá trị cụ thể
            public Book(string isbn, string title, string author, string publisher, int year)
            {
                this.isbn = isbn;
                this.title = title;
                this.author = author;
                this.publisher = publisher;
                this.year = year;
                this.chapter = new ArrayList();
            }
            // Phương thức để hiển thị thông tin sách
            public void Show()
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Publisher: " + publisher);
                Console.WriteLine("Year: " + year);
                Console.WriteLine("ISBN: " + isbn);
                Console.WriteLine("Chapters: ");
                for (int i = 0; i < chapter.Count; i++)
                {
                    Console.WriteLine("\t(0): {1}", i + 1, chapter[i]);
                }
                Console.WriteLine("----------------------------");
            }
            // Phương thức để nhập thông tin sách từ người dùng
            public void Input()
            {
                Console.Write("Title: ");
                title = Console.ReadLine();
                Console.Write("Author: ");
                author = Console.ReadLine();
                Console.Write("Publisher: ");
                publisher = Console.ReadLine();
                Console.Write("ISBN: ");
                isbn = Console.ReadLine();
                Console.Write("Year: ");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine("Input chapter (finished with emty string): ");
                string str;
                // Sử dụng vòng lặp để nhập các chương của sách cho đến khi người dùng nhập chuỗi rỗng
                do
                {
                    str = Console.ReadLine();
                    if (str.Length > 0)
                        chapter.Add(str);
                }while (str.Length > 0);
            }
        }
        // Lớp BookList để quản lý danh sách các cuốn sách
        class BookList
        {
            // Sử dụng ArrayList để quản lý danh sách các cuốn sách
            private ArrayList list = new ArrayList();
            // Phương thức để thêm một cuốn sách mới vào danh sách
            public void AddBook()
            {
                Book b = new Book();
                b.Input();
                list.Add(b);
            }
            // Phương thức để hiển thị thông tin của tất cả các cuốn sách trong danh sách
            public void ShowList()
            {
                foreach (Book b in list)
                    b.Show();
            }
            // Phương thức để nhập thông tin cho một số lượng cuốn sách nhất định từ người dùng
            public void InputList()
            {
                int n;
                Console.Write("Amount of book: ");
                n = int.Parse(Console.ReadLine());
                // Sử dụng vòng lặp để thêm n cuốn sách vào danh sách
                while (n > 0)
                {
                    AddBook();
                    n--;
                }
            }
        }
        // Lớp Program để chạy chương trình
        class Program
        {
            static void Main(string[] args)
            {
                // Tạo một đối tượng BookList để quản lý danh sách các cuốn sách
                BookList bl = new BookList();
                bl.InputList();
                bl.ShowList();
                Console.ReadLine();
            }
        }
    }
}
