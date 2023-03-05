class NestedClasses
{
    NestedClasses()
    {
        A a = new A();
        a.PropA = 1;

        A.B b = new A.B();
        b.PropB = 2;
    }
}

// Nested Class (İçiçe Sınıflar)
class A
{
    public int PropA { get; set; }

    public A()
    {
        Console.WriteLine("A Class");
    }

    public class B
    {
        public int PropB { get; set; }
        public B()
        {
            Console.WriteLine("A.B Class");
        }
    }
}