namespace MethodOverloading
{
    public class Program
    {
        //public static int Add(int num1, int num2)
        //{
        //    int answer = num1 + num2;
        //    Console.WriteLine($"{num1} + {num2} = {answer}");
        //    return answer;
        //}

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //public static decimal Add(decimal num1, decimal num2)
        //{
        //    decimal answer = num1 + num2;
        //    Console.WriteLine($"{num1} + {num2} = {answer}");
        //    return answer;
        //}

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool dollar)
        {
            var sum = num1 + num2;
            if(dollar == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(dollar == true && sum != 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return $"{sum}";
            }
        }

        //public static string Add(int num1, int num2, bool dollars)
        //{
        //    var answer = num1 + num2;
        //    if (dollars == true)
        //    {
        //        if(answer == 1)
        //        {
        //            string money = $"{answer} dollar";
        //            return money;
        //        }
        //        else
        //        {
        //            string money = $"{answer} dollars";
        //            return money;
        //        }
        //    }
        //    else
        //    {
        //        return $"{answer}";
        //    }
        //}

        static void Main(string[] args)
        {
            var answer1 = Add(1, 2);
            var answer2 = Add(1.1m, 2.2m);
            var answer3 = Add(1, 0, true);
            var answer4 = Add(1, 2, true);
            var answer5 = Add(2, 3, false);

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            Console.WriteLine(answer5);
        }
    }
}
