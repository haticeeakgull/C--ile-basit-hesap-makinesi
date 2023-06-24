namespace Methods
{
    class Program{
        public static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
        }
        public static void Sum(int a , int b)
        {
            AddSpace();
            Console.WriteLine("sum of the numbers:");
            Console.WriteLine(a + b);
            AddSpace();

        }
        public static void Difference(int a , int b)
        {
            AddSpace();
            Console.WriteLine("difference of the numbers:");
            Console.WriteLine(a - b);
            AddSpace();
        }
        public static void Multiplication(int a, int b)
        {
            AddSpace();
            Console.WriteLine("multiplication of the numbers:");
            Console.WriteLine(a * b);
            AddSpace();
        }
        public static void Division(int a , int b)
        {
            AddSpace();
            Console.WriteLine("division of the numbers:");
            Console.WriteLine(a / b);
            AddSpace();
        }
        public static void Mod(int a , int b)
        {
            AddSpace();
            Console.WriteLine("mod of the numbers:");
            Console.WriteLine(a % b);
            AddSpace();
        }
       


        static void Main(string[] args)
        {
            int input;
            int firstNum;
            int secondNum;
            Console.WriteLine("enter two numbers for processing:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());
            AddSpace();
            Console.WriteLine("Which process do you want to do? Enter number: 1)sum / 2)difference / 3)multiplication / 4)division / 5)mod");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:Sum(firstNum,secondNum);
                    break;
                case 2: Difference(firstNum,secondNum); 
                    break;
                case 3: Multiplication(firstNum,secondNum);
                    break;
                case 4: Division(firstNum,secondNum);
                    break;
                case 5:  Mod(firstNum,secondNum);
                    break;
                default:Console.WriteLine("wrong transaction entry");
                    break;
            }

        }
    }
}