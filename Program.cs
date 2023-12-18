using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static object area { get; private set; }
        public static object perimeter { get; private set; }

        static void Main(string[] args)
        {
            /*
            //Задача 1.Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            Random rnd = new Random();
            int number = rnd.Next(10, 99);
            Console.WriteLine($"Случайное число:{number}");
            string res = (number % 2 == 0) ? "Четное число" : "Нечетное число";
            Console.WriteLine($"Число {number} - {res}") ;
            */
            //Задача 2.Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            /*
            Random rnd = new Random();
            int day = rnd.Next(1, 7);
            Console.WriteLine($"Число: {day} ");
            switch (day)
            {
                case 1: Console.WriteLine ("Понедельник"); break;
                case 2: Console.WriteLine ("Вторник"); break;
                case 3: Console.WriteLine ("Среда");   break;
                case 4: Console.WriteLine ("Четверг"); break;
                case 5: Console.WriteLine ("Пятница"); break;
                case 6: Console.WriteLine ("Суббота"); break;
                case 7: Console.WriteLine ("Воскресенье");break;
            }
            */
            //Задача 3.Даны три целых положительных числа. Если все они четные, каждое число 
            // уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.
            /*
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int z = int.Parse(Console.ReadLine());

            if (x % 2 == 0 && y % 2 == 0 && z % 2 == 0)
            {
                x/= 2;
                y/= 2;
                z/= 2;
                Console.WriteLine($"Первое Число: {x}");
                Console.WriteLine($"Второе Число: {y}");
                Console.WriteLine($"Третье Число: {z}");
            }
            else if (z % 2 == 0 || y % 2 == 0 || z % 2 == 0)
            {
                x *= 2;
                y *= 2;
                z *= 2;
                Console.WriteLine($"Первое Число: {x}");
                Console.WriteLine($"Второе Число: {y}");
                Console.WriteLine($"Третье Число: {z}");
            }
            else
            {
                x++;
                y++;
                z++;
                Console.WriteLine($"Первое Число: {x}");
                Console.WriteLine($"Второе Число: {y}");
                Console.WriteLine($"Третье Число: {z}");
            }
            */

            //Задача 4. Проведен тест, оцениваемый в целочисленных баллах от нуля до ста.Вывести на экран 
            // оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично»,
            // от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».
            /*
         Console.Write("Введите количество баллов: ");
         int score = int.Parse(Console.ReadLine());

         if (score >= 90 && score <= 100)
         {
             Console.WriteLine("Отлично");
         }
         else if (score >= 70 && score <= 89)
         {
             Console.WriteLine("Хорошо");
         }
         else if (score >= 50 && score <= 69)
         {
             Console.WriteLine("Удовлетворительно");
         }
         else if (score < 50)
         {
             Console.WriteLine("Неудовлетворительно");
         }
         else
         {
             Console.WriteLine("Некорректное количество баллов");
         }
           */

            //Задача 5.Дан признак геометрической фигуры на плоскости:
            // к – круг, п – прямоугольник, т - треугольник.Вывести на экран периметр и площадь заданной фигуры(данные, необходимые для расчетов, запросить у пользователя).
            /*
                Console.WriteLine("Введите признак геометрической фигуры: ");
                char figure = char.Parse(Console.ReadLine());
                double perimeter;
                double square;
                int a, b, c, h;
                switch (figure)
                {
                    case 'К':
                    case 'к':
                        Console.Write("Введите радиус круга: ");
                        int r = int.Parse(Console.ReadLine());
                        perimeter = 2 * Math.PI * r;
                        square = Math.PI * Math.Pow(r, 2);
                        Console.WriteLine($"Периметр = {perimeter:f2}\nПлощадь = {square:f2}");
                        break;

                    case 'П':
                    case 'п':
                        Console.WriteLine("Введите стороны прямоугольника: ");
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = int.Parse(Console.ReadLine());
                        perimeter = (a + b) * 2;
                        square = a * b;
                        Console.WriteLine($"Периметр = {perimeter:f2}\nПлощадь = {square:f2}");
                        break;

                    case 'Т':
                    case 'т':
                        Console.WriteLine("Введите стороны треугольника: ");
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("c = ");
                        c = int.Parse(Console.ReadLine());
                        Console.Write("h = ");
                        h = int.Parse(Console.ReadLine());
                        perimeter = a + b + c;
                        square = (a * h) / 2;
                        Console.WriteLine($"Периметр = {perimeter:f2}\nПлощадь = {square:f2}");
                        break;
                    default: Console.WriteLine("Введённая вами фигура отсутсвует в этой программе"); break;
                }
          */
            //Задача 6.Написать приложение, которое позволяет вычислить сумму страхового взноса(SV) для автомобиля. Входные данные будут вводиться с клавиатуры:
            /*
            try
            { 
            Console.Write("марка автомобиля - ");
            string ma = Console.ReadLine();
            Console.Write("Срок страхования(от 1 до 12) - ");
            int month = int.Parse(Console.ReadLine());
            double sum, kt=0;

                if (month < 3)
                    kt = 10     ;
                else if (month >= 3 && month < 6)
                    kt = 8;
                else if (month >= 6 && month < 12)
                    kt = 5;

                sum = 50 * month * (1 + kt / 100);

                Console.WriteLine($"Ваш автомобиль марки {ma} был застрахован\nСумма страхового взноса составила {sum}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            */

            Console.ReadKey();

        }
    }
}
