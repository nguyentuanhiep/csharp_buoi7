### Buổi 7:
* Chủ đề: oop: abstraction, encapsulation & inheritance, object initialiser
#### Bài tập:
1. Tạo 1 chương trình quản lý ô tô: dựng 1 class Car có các thuộc tính phù hợp (Color, Year, Brand, Mileage,...). Trong class Car cần khởi tạo các constructors khác nhau nhận tham số đầu vào khi khởi tạo đối tượng khác nhau. Ngoài ra, tạo biến và phương thức static để có thể kiểm tra số lượng đối tượng ô tô được tạo ra. Ví dụ sau khi có class Car, trong hàm Main ta có thể gọi các câu lệnh dưới đây và in ra kết quả đúng.
```cs
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2008);

            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
```
2. Tạo 1 base class Person, các lớp con Student, Teacher,... kế thừa từ nó. Lớp Person có 1 số đặc tính chung, còn mỗi lớp con sẽ có 1 số thuộc tính hay phương thức riêng biệt của nó. 
3. Tạo và sử dụng static Calculator class có các phương thức Add, Substract, Multiply, Divide,...
4. Nâng cao class Person với nhiều constructor, lớp con sử dụng lại base contructors, gợi ý từ khóa  `public Student () : base () {...}`
