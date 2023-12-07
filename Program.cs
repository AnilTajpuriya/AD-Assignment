//namespace Assignment
//{
//    internal class Car
//    {
//        private string brand;
//        private int year;
//        private float price;

//        public Car(string brand, int year, float price)
//        {
//            this.brand = brand;
//            this.year = year;
//            this.price = price;
//        }

//        public void printCarDetails()
//        {
//            Console.WriteLine($"Brand={brand}");
//            Console.WriteLine($"Year={year}");
//            Console.WriteLine($"Price={price}");
//        }

//        static void Main(string[] args)
//        {
//            Car C = new Car("Lamborgini", 2023, 500000.00f);
//            C.printCarDetails();

//            Car D = new Car("Ducati", 2023, 400000.00f);
//            D.printCarDetails();

//        }
//    }
//}
////////////////////////////////////////////////////////////////////////

//Exercise 2

//using Assignment;

//namespace Assignment
//{
//    public class BankAccount
//    {
//        private string accountNumber;
//        private decimal balance;


//        public BankAccount(string accountNumber)
//        {
//            this.accountNumber = accountNumber;
//            this.balance = 0;
//        }
//        public void Deposit(decimal amount)
//        {
//            balance += amount;
//        }
//        public void Withdraw(decimal amount)
//        {
//            if (amount < balance)
//            {
//                balance -= amount;
//            }
//            else
//            {
//                Console.WriteLine("Your balance is not sufficient.");
//            }


//        }
//        public decimal GetBalance()
//        {
//            return balance;
//        }

//    }
//}

//class Account
//{
//    static void Main()
//    {
//        BankAccount acc = new BankAccount("09234");
//        acc.Deposit(1000);
//        acc.Withdraw(500);
//        Console.WriteLine(" Your Final Balance:" + acc.GetBalance());
//    }
//}
///////////////////////////////////////////////////////////////////////////////////

//Exercise 3
//using System;

//public class Rectangle
//{
//    private float length;
//    private float width;

//    public Rectangle(float length, float width)
//    {
//        this.length = length;
//        this.width = width;
//    }

//    public float CalculateArea()
//    {
//        return length * width;
//    }

//    static void Main(string[] args)
//    {
//        Rectangle rec = new Rectangle(4.5f, 3.2f);
//        float area = rec.CalculateArea();
//        Console.WriteLine("The area of rectangle is:" + area);
//    }
//}
/////////////////////////////////////////////////////////////////////////////////////
//Exercise 4
//using System;

//public class Shape
//{
//    public virtual float CalculateArea()
//    {
//        return 0;
//    }
//}

//public class Circle : Shape
//{
//    private float radius;
//    public Circle(float radius)
//    {
//        this.radius = radius;
//    }
//    public override float CalculateArea()
//    {
//        return (float)(Math.PI * radius * radius);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Circle C = new Circle(5);
//        float area = C.CalculateArea();
//        Console.WriteLine("The area of the circle is :" + area);
//    }
//}
///////////////////////////////////////////////////////////////////////////////////////

//Exercise 5
//using System;

//public class Student
//{
//    private string name;
//    private int age;
//    private string major;

//    public Student(string name, int age, string major)
//    {
//        this.name = name;
//        this.age = age;
//        this.major = major;
//    }

//    public void Introduce()
//    {
//        Console.WriteLine($"My name is {name}. I'm {age} years old.My major is {major}.");
//    }

//    static void Main(string[] args)
//    {
//        Student s = new Student("John Doe", 20, "Computer Science");
//        s.Introduce();
//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////

//Exercise 6

//using System;
//using System.Collections.Generic;

//public class Stack<T>
//{
//    private List<T> items;

//    public Stack()
//    {
//        items = new List<T>();
//    }

//    public void Push(T item)
//    {
//        items.Add(item);
//    }

//    public T Pop()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("This Stack is empty");
//        }

//        int lastIndex = items.Count - 1;
//        T item = items[lastIndex];
//        items.RemoveAt(lastIndex);
//        return item;
//    }

//    public T Peek()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("This Stack is empty");
//        }

//        return items[items.Count - 1];
//    }

//    public bool IsEmpty()
//    {
//        return items.Count == 0;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Stack<int> S = new Stack<int>();

//        S.Push(1);
//        S.Push(2);
//        S.Push(3);

//        Console.WriteLine("Peek: " + S.Peek());

//        Console.WriteLine("Popped item: " + S.Pop());

//        Console.WriteLine("Peek: " + S.Peek());

//        Console.WriteLine("Popped item: " + S.Pop());

//        Console.WriteLine("Peek: " + S.Peek());

//        Console.WriteLine("Popped item: " + S.Pop());

//        Console.WriteLine("Is stack empty? " + S.IsEmpty());
//    }
//}
////////////////////////////////////////////////////////////////////////////////
//Exercise 7
//using System;

//public class Calendar
//{
//    public enum DaysOfWeek
//    {
//        Monday,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }

//    public void PrintWeekdays()
//    {
//        for (int i = (int)DaysOfWeek.Monday; i <= (int)DaysOfWeek.Friday; i++)
//        {
//            Console.WriteLine((DaysOfWeek)i);
//        }
//    }
//     static void Main(string[] args)
//    {
//        Calendar C = new Calendar();
//        C.PrintWeekdays();
//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////
//Exercise 8

//using System;

//public struct Point2D
//{
//    public float x;
//    public float y;
//}

//public class Calculation
//{
//    public static float CalculateDistance(Point2D point1, Point2D point2)
//    {
//        float xDifference = point2.x - point1.x;
//        float yDifference = point2.y - point1.y;
//        return (float)Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2));
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Point2D point1 = new Point2D { x = 4, y = 5 };
//        Point2D point2 = new Point2D { x = 3, y = 4 };

//        float distance = Calculation.CalculateDistance(point1, point2);
//        Console.WriteLine("Distance: " + distance);
//    }
//}