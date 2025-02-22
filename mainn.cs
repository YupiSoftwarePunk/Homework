namespace HomeWork
{
    internal class Mainn
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 20, 30);

            point.Print();

            point.MoveBy(1, 5, 25);

            point.Print();

            Pc pc = new Pc("Asus ROG 12555", 12.22, 32, 1000);
            pc.Info();

            User user = new User("Alex", "Smith", "Peter", 22);
            user.Fio();

            PostOffice postOffice = new PostOffice(66778839, "NY", "Wall st.", 22, 45, 195, "hello");
            postOffice.Info();

            Laptop msi = new Laptop("MSI Catana", 12.22, 32, 1000, 2000);
            msi.Info();

            SmartPhone iphone11 = new SmartPhone("iphone 11", 7.22, 16, 32, 300, "ios");
            iphone11.Info();

            Rectangle rect = new Rectangle(2, 4, 7, 1);
            rect.Perimeter();
            rect.Square();

            Triangle triangle = new Triangle(10, 10, 10);
            triangle.Perimeter();
            triangle.Square();
            triangle.Info();

            Circle circle = new Circle(2, 4, 5);
            circle.Square();
            circle.Lenght();

            Square square = new Square(1, 3, 5);
            square.Perimeter();
            square.Area();
        }
    }
}
