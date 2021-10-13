using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chess

            Chess c1 = new Chess("Chessboard 8x8", "Black and White", "Queen, King, Rook, Bishop", "GrandMaster");
            Console.WriteLine(c1.AllGames());
            #endregion

            #region Checkers

            Checkers ch1 = new Checkers();

            Console.WriteLine("input Board");
            string text = Console.ReadLine();
            ch1.Board = text;


            Console.WriteLine("input Color");
            string text1 = Console.ReadLine();
            ch1.Color = text1;


            Console.WriteLine("input Figure");
            string figure1 = Console.ReadLine();
            ch1.Figure = figure1;


            Console.WriteLine("input your Elo");
            int elo1 = int.Parse(Console.ReadLine());
            ch1._elo = elo1;
            Console.WriteLine(ch1.Elo);

            Console.WriteLine(ch1.AllGames());
            #endregion




            #region Student
            //Student s1 = new Student();

            //Console.WriteLine("input Name");
            //string text = Console.ReadLine();
            //s1._name = text;
            //Console.Clear();

            //Console.WriteLine("input Surname");
            //string text1 = Console.ReadLine();
            //s1._surname = text1;
            //Console.Clear();

            //Console.WriteLine("input age");
            //int age1 = int.Parse(Console.ReadLine());
            //s1._age = age1;
            //Console.Clear();

            //Console.WriteLine("input number");
            //int num = int.Parse(Console.ReadLine());
            //s1.Mark = num;
            //Console.WriteLine(s1.Mark);

            //Console.WriteLine(s1.Any());
            #endregion


        }
    }
}
