using System;
using System.Text;

namespace lab_3.week
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("input  text");
        //    string text = Console.ReadLine();
        //    Console.WriteLine("input  text1");
        //    string text1 = Console.ReadLine();
        //    Console.WriteLine("input operators");
        //    string operators = Console.ReadLine();
        //    Console.WriteLine(Reverse(text, text1, operators));


            //Console.WriteLine("input first number");
            //int text =int.Parse (Console.ReadLine());
            //Console.WriteLine("input second number");
            //int text2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("input operator");
            //char operators = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(Counter(text,text2,operators));



            //int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            //int[] newarr = CustomSort(arr);



            //foreach (int value in newarr)
            //{
            //    Console.Write(value + " ");
            //}



            //Console.WriteLine("input size");
            //int size = int.Parse(Console.ReadLine());
            //string[] result = new string[size];
            //for (int i = 0; i < result.Length; i++)
            //{
            //    string newarr = Console.ReadLine();
            //    result[i] = newarr;
            //}
            //string separator = Console.ReadLine();
            //Console.WriteLine(CustomJoin(result, separator));

            //int[] myArr = { 5, 6, 7, 8 };
            //int a = 10;

            //Reference(ref myArr,a);

            //foreach (var item in myArr)
            //{
            //    Console.Write(item + " ");
            //}

            //int[] text = { 2, 3, 4, 6, 7 };
            //Reference(ref text);
            //foreach (var item in text)
            //{
            //    Console.Write(item+" ");
            //}         

        }

        #region array azdan coxa sırala
        static int[] CustomSort(int[] arr)
        {

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            return arr;
        }
        #endregion

        #region arraylar arasina separator eklesin ama sonuncya eklenmesin
        static string CustomJoin(string[] text, string separator)
        {
            StringBuilder cb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                cb.Append(text[i]);
                if (i < text.Length - 1)
                {
                    cb.Append(separator);
                }
            }
            return cb.ToString();


        }
        #endregion

        #region calculator 
        static int Counter(int text, int text2, char operators)
        {
            int result = 0;
            switch (operators)
            {
                case '*':

                    result = text * text2;
                    break;

                case '/':
                    result = text * text2;

                    break;

                case '-':
                    result = text - text2;
                    break;


                case '+':
                    result = text + text2;
                    break;

                default:
                    Console.WriteLine("incorrect operators");
                    break;
            }
            return result;
        }
        #endregion

        #region   exsample: text=alma operator=+ netice: +lm+
        static string Reverse(string text, string text1, string operators)
        {
            text = text.Replace(text1, operators);
            return text;

        }
        #endregion

        #region  arrayin sonuna nese elave etmek


        static void Reference(ref int[] myArr, int a)
        {
            Array.Resize(ref myArr, myArr.Length + 1);
            myArr[myArr.Length - 1] = a;




        }
        #endregion

        #region cut ededleri arraya menimsetmek
        static void Reference(ref int[] text)
        {

            int[] counter = new int[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] % 2 == 0)
                {
                    Array.Resize(ref counter, counter.Length + 1);
                    counter[counter.Length - 1] = text[i];
                }

            }
            text = counter;
        }
        #endregion
    }
}
