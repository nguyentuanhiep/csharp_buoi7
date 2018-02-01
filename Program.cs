using System;

namespace csharp_buoi7
{
    class Program
    {
        static void Main(string[] args)
        {
            //bai1();
            bai2();
            //bai3();
        }

        static void bai1()
        {
            var car1 = new Car();
            car1.Color = "White";
            car1.Year = 2009;
            car1.Brand = "Toyota";

            var car2 = new Car("Red", 2008, "Lamborghini");
            var car3 = new Car("Green");
            var car4 = new Car("Pink", 2013);
            var car5 = new Car{Color = "Blue", Year = 2010, Brand = "Huyndai" };
            System.Console.WriteLine("Co {0} o to", Car.count);
        }

        static void bai2()
        {
            var student1 = new Student("Nguyen Van A", 12, "a@gmail.com", "0123456789", "a01");
            System.Console.WriteLine("Hoc sinh: {0}. {1} tuoi. Email: {2}. SDT: {3}. Ma so: {4}.", student1.Name, student1.Age, student1.Email, student1.Phone, student1.Id);
            var student2 = new Student("Tran Van B", 14, "b@yahoo.com");

            var teacher1 = new Teacher("Trinh Minh Cuong", 43, "cuong@techmaster.vn", "0902209011", "Tin hoc");
            System.Console.WriteLine("Giao vien: {0}. {1} tuoi. Email:{2}. SDT: {3}. Bo mon: {4}.", teacher1.Name, teacher1.Age, teacher1.Email, teacher1.Phone, teacher1.Subject);
        }

        static void bai3()
        {
            System.Console.WriteLine("Nhap vao 2 so");
            System.Console.WriteLine("So thu nhat la");
            int x = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("So thu hai la");
            int y = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Tong, Hieu, Tich, Thuong cua 2 so do la");
            Calculator.Add(x,y);
            Calculator.Substract(x,y);
            Calculator.Multiply(x,y);
            Calculator.Divide(x,y);

        }
    }

    class Car 
    {
        public string Color {get; set;}
        public int Year {get; set;}
        public string Brand {get; set;}

        public static int count;
        

        public Car()
        {
            count++;
        }

        public Car(string color)
        {
            Color = color;
            count++;
        }

        public Car(string color, int year)
        {
            Color = color;
            Year = year;
            count++;
        }

        public Car(string color, int year, string brand)
        {
            Color = color;
            Year = year;
            Brand = brand;
            count++;
        }
    }


    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age, string phone)
        {
            Name = name;
            Age = age;
            Phone = phone;
        }

        public Person(string name, int age, string phone, string email)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Email = email;
        }


        
    }
    class Student:Person
    {
        public string Id { get; set; }
        
        public Student( string name, int age, string id):base(name, age)
        {
            Id=id;
        }
        public Student(string name, int age, string email, string phone, string id):base(name, age, phone, email)
        {
            Id  = id;
        }
    }

    class Teacher:Person
    {
        public string Subject { get; set; }
        public Teacher(string subject, string name, int age):base(name, age)
        {   
            Subject = subject;
        }
        public Teacher(string name, int age, string email, string phone, string subject):base(name, age, phone, email)
        {
            Subject  = subject;
        }
    }

    static class Calculator
    {
        public static void Add (int x, int y) {
            System.Console.WriteLine(x+y);
        }

        public static void Substract (int x, int y) {
            System.Console.WriteLine(x-y);
        }

        public static void Multiply (int x, int y) {
            System.Console.WriteLine(x*y);
        }

        public static void Divide (int x, int y) {
            float z = (float)x/(float)y;
            System.Console.WriteLine(z);
        }
    }
}
