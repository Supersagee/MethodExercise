using System;

namespace MethodExerciseConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            HelloPerson();

            FaveColor();

            FaveAnimal();

            FaveBand();

            Console.WriteLine("Give me number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number");
            int num2 = int.Parse(Console.ReadLine());

            int addTotal = Addition(num1, num2);
            Console.WriteLine($"Adding the two numbers comes out to {addTotal}");

            int subTotal = Subtraction(num1, num2);
            Console.WriteLine($"Subtracting the two numbers comes out to {subTotal}");

            int mulTotal = Multiplication(num1, num2);
            Console.WriteLine($"Multiplying the two numbers comes out to {mulTotal}");

            int divTotal = Division(num1, num2);
            int modTotal = Modulus(num1, num2);
            Console.WriteLine($"Dividing the two numbers comes out to {divTotal}, with a remander of {modTotal}");

        }

        //all methods bellow this

        public static int Addition(int num1, int num2)
        {
           return num1 + num2;
        }

        public static int Subtraction(int num1, int num2)
        {
           return num1 - num2;
        }

        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static void HelloPerson()
        {
            Console.WriteLine("Hi there! What is your name?");
            string userName = Console.ReadLine();
           
            if(userName == "Billy")
            {
                Console.WriteLine("Hey, that's my name too!");
            }
            else
            {
                Console.WriteLine($"Hey {userName}, nice to meet you!");
            }
        }

        public static void FaveColor()
        {
            Console.WriteLine("What's your favorite color?");
            string userColor = Console.ReadLine();
            
            if(userColor == "Red")
            {
                Console.WriteLine("No way! Mine too!");
            }
            else
            {
                Console.WriteLine("Nice! My fave color is red.");
            }
        }

        public static void FaveAnimal()
        {
            Console.WriteLine("So what's your favorite animal?");
            string userAnimal = Console.ReadLine();

            if (userAnimal == "Panther")
            {
                Console.WriteLine($"Same here! {userAnimal}s are so cool!");
            }
            else
            {
                Console.WriteLine($"{userAnimal}'s are pretty cool!");
            }
        }
        public static void FaveBand()
        {
                Console.WriteLine("Tell me, what is your favorite band?");
              
                string userBand = Console.ReadLine();

                if( userBand == "Tool")
                {
                    Console.WriteLine($"I love {userBand}! They rock! That is seriously cool!");
                }
                else
                {
                    Console.WriteLine($"{userBand} is such a solid band.");
                }
        }

        public static int Add(int addNum1, int addNum2)
        {
            return addNum1 + addNum2;
        }


    }
}
