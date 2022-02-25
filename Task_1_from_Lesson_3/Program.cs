using System;

namespace Task_1_from_Lesson_3
{
    /*
    ---------------------------- Условие задачи ----------------------------
    |    Постройте таблицу значений функции y=f(x) для х[a, b] с шагом h.   |
    |  Если в некоторой точке x функция не определена, то выведите на экран |
    |  сообщение об этом.                                                   |
    |   Замечание.                                                          |
    |   При решении данной задачи использовать вспомогательный метод f(x),  |
    | реализующий заданную функцию, а также проводить обработку возможных   |
    | исключений.                                                           |
    |                           y = 1/((1+x)^2)                             |
    -------------------------------------------------------------------------
     */
    class Program 
    {
        static double Function(int x)
        {
            try
            {
                if (x == -1) throw new Exception();
                return (double)1 / Math.Pow((1 + x), 2);
            }
            catch(Exception e) 
            {
                throw;
            }
        }
        static void Main()
        {
            //Диапазон координаты x
            int a;
            int b;

            //шаг для выводы таблицы
            int h;

            int[] x;
            try
            {
                Console.Write("Введите начало координат х: ");
                a= Int32.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Введите конец координат х: ");
                b= Int32.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Введите шаг для координаты х: ");
                h= Int32.Parse(Console.ReadLine());
                double y;

                x= new int[b-a];
                Console.WriteLine("-----X--------Y----");
                for (int i = a; i <= b; i += h)
                {
                    y= Function(i);
                    Console.WriteLine("|" + "{0,8:0.000}" + "|" + "{1,8:0.000}" + "|", i, y);
                }
                Console.WriteLine("-------------------");
            }
            catch(FormatException)
            {
                Console.WriteLine("Ошибка. Введите целое число!");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка!");
            }
            //double a = Function(5);
            //Console.WriteLine("{0,8:0.000}", a);
        }
    }    
}