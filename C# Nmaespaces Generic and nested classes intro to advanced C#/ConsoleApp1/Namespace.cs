class Namespaces
{
    Namespaces()
    {
        // Using different namespaces.
        ProjectA.TeamB.ClassA x2 = new ProjectA.TeamB.ClassA();
        ProjectB.TeamA.ClassA x3 = new ProjectB.TeamA.ClassA();
    }
}

// Using classes from two different namespaces.
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectA.TeamA.ClassA.Print()");
            }
        }
    }

    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectA.TeamB.ClassA.Print()");
            }
        }
    }
}

namespace ProjectB
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectB.TeamA.ClassA.Print()");
            }
        }
    }
}
