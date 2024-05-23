public class Bài10
{
    static void Main(string[] args)
    {
        Console.Write("Nhập vào hệ số a: ");
        string inputA = Console.ReadLine();
        Console.Write("Nhập vào hệ số b: ");
        string inputB = Console.ReadLine();
        if (int.TryParse(inputA, out int a) && int.TryParse(inputB, out int b))
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                
                int x = -b / a;
                Console.WriteLine($"Nghiệm của phương trình là x = {x}");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số hợp lệ.");
        }
    }
}

        //Console.WriteLine("Linear Equation Resolver");
        //Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

        //Console.Write("a: ");
        //double a = Convert.ToDouble(Console.ReadLine());

        //Console.Write("b: ");
        //double b = Convert.ToDouble(Console.ReadLine());

        //if (a != 0)
        //{
        //    double solution = -b / a;
        //    Console.Write("The solution is: {0}!", solution);
        //}
        //else
        //{
        //    if (b == 0)
        //    {
        //        Console.Write("The solution is all x!");
        //    }
        //    else
        //    {
        //        Console.Write("Nod solution!");
        //    }
        //}
        //Console.ReadLine();
//    }
//}