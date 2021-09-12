using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-8");
            Person jane = new Person("Jane Doe", "8.765.432-1");
            Person Lucas = new Person("Lucas Martino", "4.658.761-8");
            john.IntroduceYourself();
            jane.IntroduceYourself();
            Lucas.IntroduceYourself();
        }
    }
}
