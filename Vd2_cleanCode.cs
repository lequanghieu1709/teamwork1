using System;
using System.Collections.Generic;

class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }

    public override string ToString()
    {
        return $"ID:{Id} Name:{Name} Age:{Age} GPA:{GPA}";
    }
}

public class BadSchoolProgram
{
    static List<Student> students = new List<Student>();
    {
<<<<<<< HEAD
        List<string> students = new List<string>();
=======
        static void addStudent()
    {
        Console.WriteLine("\n--- THEM SINH VIEN ---");
        Console.Write("Nhap id: ");
        string id = Console.ReadLine();
        Console.Write("Nhap ten: ");
        string name = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Nhap GPA: ");
        double gpa = double.Parse(Console.ReadLine());
        
        students.Add(new Student { Id = id, Name = name, Age = age, GPA = gpa });
        
        Console.WriteLine("Da them sinh vien thanh cong!\n");
    }
>>>>>>> 7d9fc68 (update thành công)

        int mainMenu = 0;
        while (mainMenu != 99)
        {
            Console.WriteLine("============= MENU CHINH =============");
            Console.WriteLine("1. Quan ly Sinh vien");
            Console.WriteLine("2. Quan ly Giao vien");
            Console.WriteLine("3. Quan ly Mon hoc");
            Console.WriteLine("4. Quan ly Dang ky hoc");
            Console.WriteLine("5. Quan ly Diem");
            Console.WriteLine("6. Bao cao tong hop");
            Console.WriteLine("99. Thoat");
            Console.Write("Nhap lua chon: ");
            mainMenu = int.Parse(Console.ReadLine());
            
            switch(mainMenu){
                case 1: studentsMenu(); break;                       
            }
        }
    }
    static void studentMenu(){
        int menuStudents = 0; 
        while (menuStudents != 9)
        {
            Console.WriteLine("--- QUAN LY SINH VIEN ---");
            Console.WriteLine("1. Them SV");
            Console.WriteLine("2. Xoa SV");
            Console.WriteLine("3. Cap nhat SV");
            Console.WriteLine("4. Hien thi tat ca SV");
            Console.WriteLine("5. Tim SV theo ten");
            Console.WriteLine("6. Tim SV GPA > 8");
            Console.WriteLine("7. Sap xep theo ten");
            Console.WriteLine("8. Sap xep theo GPA");
            Console.WriteLine("9. Quay lai");
            menuStudents = int.Parse(Console.ReadLine());

            switch (menuStudents){
                case 1: addStudent(); break;
                case 2: removeSudent(); break;
                case 3: updateStudent(); break;
                case 4: showAllStudents(); break;
                case 5: searchStudent(); break;
                case 6: masterStudent(); break;
                case 7: sortName(); break;
                case 8: sortGPA(); break;
            }
        }
    }
    static void addStudent(){
        Console.Write("Nhap id: ");
        string id = Console.ReadLine();
        Console.Write("Nhap ten: ");
        string name = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Nhap GPA: ");
        double gpa = double.Parse(Console.ReadLine());
        students.Add(new Student {Id=id, Name=name, Age=age, GPA=gpa});
        break;
    }
    static void removeSudent(){
        Console.Write("Nhap id can xoa: ");
        string id = Console.ReadLine();
        Student studentToRemove = students.Find(s => s.Id == id);
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine("Da xoa sinh vien!\n");
        }
    }
    static void updateStudent(){
        Console.Write("Nhap id can cap nhat: ");
        string id = Console.ReadLine();
        Student studentToUpdate = students.Find(s => s.Id == id);
        if (studentToUpdate != null)
        {
            Console.Write("Nhap ten moi: ");
            studentToUpdate.Name = Console.ReadLine();
            Console.Write("Nhap tuoi moi: ");
            studentToUpdate.Age = int.Parse(Console.ReadLine());
            Console.Write("Nhap GPA moi: ");
            studentToUpdate.GPA = double.Parse(Console.ReadLine());

            Console.WriteLine("Da cap nhat sinh vien!\n");
        }
    }
    static void showAllStudents(){
        foreach (var s in students)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
    }
    static void searchStudent(){
        Console.Write("Nhap ten: ");
        string name = Console.ReadLine();
        foreach (var s in students)
        {
            if (s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Tim thay: " + s);
        }
    } 
    static void masterStudent(){
        if (s.GPA > 8.0){
            Console.WriteLine("Sinh vien gioi: " + s);
        }    
    }
    static void sortName(){
        students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
        Console.WriteLine("Da sap xep theo ten.");
    }
    static void sortGPA(){
        students.Sort((s1, s2) => s2.GPA.CompareTo(s1.GPA));
        Console.WriteLine("Da sap xep theo GPA.");
    }
}
