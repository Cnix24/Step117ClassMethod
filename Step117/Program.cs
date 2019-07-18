using System;

namespace Step117
{
    class Program
    {
        static void Main(string[] args)
        {
            // Steps 1-4 | Create a class and void method with an output integer. Method divides input by 2. Method uses output parameters.

            int x;

            Class1 class1 = new Class1();

            Console.WriteLine("Please provide a whole number: ");
            string firstInput = Console.ReadLine();
            int firstInteger = Convert.ToInt32(firstInput);

            class1.VoidMethod(firstInteger, out x);
            

            Console.WriteLine("The number you provided divided by 2 equals "+x);
            Console.ReadLine();

            //END: Steps 1-4

            // Step 5 | Overload a method

            int y; 
            Class1 classB = new Class1();

            Console.WriteLine("Please provide a whole number: ");
            string secondInput = Console.ReadLine();
            int secondInteger = Convert.ToInt32(secondInput);

            Console.WriteLine("Please provide a second whole number: ");
            string thirdInput = Console.ReadLine();
            int thirdInteger = Convert.ToInt32(thirdInput);

            classB.VoidMethod(secondInteger, thirdInteger, out y);

            

            Console.WriteLine("The sum of those numbers divided by 2 equals " + y);
            Console.ReadLine();

            //END: Step 5

            //Step 6: static class

            Console.WriteLine(Class1.secretMessage);
            Console.ReadLine();

            //Step 6: end

        }
    }
}
