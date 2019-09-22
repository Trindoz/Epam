using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program demo = new Program();
            
            Console.WriteLine("Первоначальная последовательность чисел: 15 -2 23 14 -5 6 17 -8");
            Console.Write("Упорядоченная последовательность чисел: ");
            for (int i = 0; i < demo.Sort(new int[] { 15, -2, 23, 14, -5, 6, 17, -8 }).Length; i++)
            {
                Console.Write(demo.Sort(new int[] { 15, -2, 23, 14, -5, 6, 17, -8 })[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Искомое число под индексом "+demo.BinarySearch(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8}, 4));
            Console.WriteLine( demo.SearchWord("кукушка кукушка квакушка петрушка собака кошка ослик зебра собака"));
            Console.WriteLine("Факториал заданного числа равен " + demo.Factorial(5));
            Console.WriteLine( demo.CorrectBracket("(]}{{()"));

        }
        // Задание 1
        public int [] Sort (int[] array)
        {
            int[] arr = new int[array.Length];
            int x;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            return arr;
            
        }
        //Задание 2
        public int BinarySearch(int[] array, int searchedValue)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchedValue == array[mid])
                {
                    return mid;
                }

                else if (searchedValue < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            return -1;

        }
        //Задание 3
        public string SearchWord(string word)
        {
            string t = "";
            string[] tx = new string[word.Length];
            string[] text = word.Split(' ');
            for (int i = 0; i < text.Length; i++)
            {
                string write = text[i];

                int count = 0;
                foreach (string item in text)
                {
                    if (item == write)
                        count++;
                }
                if (count == 1)

                    tx[i] = text[i] + " ";
            }
            for (int i = 0; i < tx.Length; i++)
            {
                t += tx[i];
            }
            return t;
        }
        //Задание 4
        public  int  Factorial(int f)
        {
            if (f >= 0)
            {
                int fact = 1;
                for (int i = 1; i <= f; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            else return 0;
        }
        //Задание 5
        public string CorrectBracket(string bracket)
        {
            if (bracket.Length % 2 == 0)
            {
                int a = 0;
                int a1 = 0;
                int b = 0;
                int b1 = 0;
                int c = 0;
                int c1 = 0;
                for (int i = 0; i < bracket.Length; i++)
                {
                    if (bracket[i] == '(')
                    {
                        a++;
                    }
                    if (bracket[i] == ')')
                    {
                        a1++;
                    }
                    if (bracket[i] == '[')
                    {
                        b++;
                    }
                    if (bracket[i] == ']')
                    {
                        b1++;
                    }
                    if (bracket[i] == '{')
                    {
                        c++;
                    }
                    if (bracket[i] == '}')
                    {
                        c1++;
                    }
                }
                
                if (((a == a1) & (b == b1) & (c == c1)) & (((bracket[0]=='(')|(bracket[0]=='[')|(bracket[0]=='{'))&((bracket[bracket.Length-1]==')')| (bracket[bracket.Length - 1] == '}')| (bracket[bracket.Length - 1] == ']'))))
                {

                    for (int i = 1; i < bracket.Length - 1; i++)
                    {
                        if ((bracket[i] == '(') & ((bracket[i + 1] == ']') | (bracket[i + 1] == '}')))
                        {
                            return "Неверная скобочная последовательность";
                        }
                        else if ((bracket[i] == '{') & ((bracket[i + 1] == ']') | (bracket[i + 1] == ')')))
                        {
                            return "Неверная скобочная последовательность";
                        }
                        else if ((bracket[i] == '[') & ((bracket[i + 1] == '}') | (bracket[i + 1] == ')')))
                        {
                            return "Неверная скобочная последовательность";
                        }
                    }
                    return "Верная скобочная последовательность";
                }
                else return "Неверная скобочная последовательность";
            }
            else return "Неверная скобочная последовательность";
 
        }
    }
}
