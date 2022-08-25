using System;

//HomeWork 5 C#
//Developer kipov.m.h
//25.08.2022

namespace HomeWork2
{

    class Program
    {
            public const string VerDev = "V.0.1.0";
            //////Номер задания//////
            public const string NamberWork    = "Home work 5";
            //////Название программ///////
            public const string ProgramName_1 = "Программа создает массив заполненный случайными положительными трёхзначными числами. Потом показывает количество чётных чисел в массиве.";
            public const string ProgramName_2 = "Программа создает одномерный массив, заполненный случайными числами. Потом находит сумму элементов, стоящих на нечётных позициях.";
            public const string ProgramName_3 = "Программа создает массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.";
            public const string ProgramName_4 = "Программа создает одномерный массив из 123 случайных чисел. Потом находит количество элементов массива, значения которых лежат в отрезке [10,99]";
            public const string ProgramName_5 = "Программа находит произведение пар чисел в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследний и т.д. Результат работы записывает в новый массив.";
           
        ///////////////////////////////////////// Промежуточное меню для выхода или продолжнеия программы //////////////////////////////
        static void Contin()
        {
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы начать.");

            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.\n");
            Console.ResetColor();
        }
        //////////////////////////////////// Выход из программы по нажатию кнопок //////////////////////////////////////////////////////
        static int textWrite(int Exit_Play, string NameProg)
        {
            Contin();

            while (true)
            {
                String Presskey = Convert.ToString(Console.ReadKey().Key);
                if (Presskey == "q0" || Presskey == "End" || Presskey == "Backspace" || Presskey == "Escape" || Presskey == "Q1" || Presskey == "Q" || Presskey == "q")
                {
                    return 0;
                }
                else if (Presskey == "Enter" || Presskey == "Spacebar")
                {
                    return 1;
                }
                else
                {
                    devWrite(NameProg);
                    Contin();
                }

            }
        }
        ///////////////////////////////// Очистка экрана и вывод redkipov. ////////////////////////////////////////////////////////////
        static void devWrite(string s)
        {
            Console.Clear();
            const String nameDev = "redkipov";
            Console.ForegroundColor = ConsoleColor.Cyan; // цвет 
            Console.Write("developer - ");
            Console.ForegroundColor = ConsoleColor.DarkRed; // цвет 
            Console.WriteLine(nameDev);
            Console.ForegroundColor = ConsoleColor.DarkGray; // цвет 
            Console.WriteLine(VerDev);
            Console.ForegroundColor = ConsoleColor.Yellow; // цвет 
            Console.WriteLine(s);
            Console.ResetColor();
        }
        /////////////////////////////////////////////////// Меню приветствия //////////////////////////////////////////////////////////
        //___________________________________________________________________________________________________________________________//
        static void WelcomeWrite(string NameProg)
        {
            devWrite(NameProg);
            Console.ForegroundColor = ConsoleColor.DarkCyan; //  цвет
            Console.WriteLine(NamberWork);
            Console.ForegroundColor = ConsoleColor.Green; //  цвет зеленый
            Console.Write("Введите соотвествующую цифру программы, которую вы хотите ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; //  цвет
            Console.WriteLine("запустить");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("[1] "); ////// Первая программа.
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_1);
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("[2] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_2);
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("[3] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_3); 
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("[4] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_4);
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("[5] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_5);  
            ///////////////////////////////////////////////////////////
            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        //############################################### Программа 1 ###############################################################//
        //###########################################################################################################################//
        static void Program_1(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[1] {ProgramName_1}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                ////////**************** Logica **************////////    
                Console.WriteLine("Введите количество 3-х значных чисел в массиве: ");
                int UserNumbers = Convert.ToInt32(Console.ReadLine());
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array,100,990);
                int[] resultArrey = new int[array.Length];
                for (int i = 0; i < array.Length; i++) {
                    if (array[i] % 2 == 0)
                    {
                        resultArrey[i] = array[i];
                    }
                }
                ////////**************** End Logica **************////////
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("Случайные числа в массиве: ");
                WriteArray(array,1);
                Console.Write("Четные числа в массиве: ");
                int quantity = WriteArray(resultArrey,0); //вызов функции вывода массива и возврат количества.
                Console.WriteLine($"Количетсво четных чисел: {quantity}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 2 ###############################################################//
        //###########################################################################################################################//
        static void Program_2(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[2] {ProgramName_2}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                ////////**************** Logica **************//////// 
                Console.WriteLine("Введите размер массива (не больше 20-ти): ");
                int UserNumbers = Convert.ToInt32(Console.ReadLine());
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array,0,990);
                int[] resultArrey = new int[array.Length];
                int result=0;
                int j=1;
                for (int i = 0; i < array.Length; i++) 
                {
                    if (j % 2 != 0)
                    {
                        resultArrey[i] = array[i];
                    }
                    j++;
                }

                for (int i = 0; i < resultArrey.Length; i++) 
                {
                    result = result + resultArrey[i];
                }
                ////////**************** End Logica **************////////
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("Случайные числа в массиве: ");
                WriteArray(array,1);
                Console.Write("Сумма элементов: "); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(result);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(", на нечётных позициях.\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 3 ###############################################################//
        //###########################################################################################################################//
        static void Program_3(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[3] {ProgramName_3}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                ////////**************** Logica **************//////// 
                Console.WriteLine("Введите размер массива (не больше 20-ти): ");
                int UserNumbers = Convert.ToInt32(Console.ReadLine());
                decimal[] array = CreaterArrayVi(UserNumbers);
                array = ShuffleVi(array);
                decimal max = array[0];
                decimal min = array[0];
                for (int i=0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                         min = array[i];
                    }
                    if (array[i] > max)
                    {
                         max = array[i];
                    }
                }

                ////////**************** End Logica **************////////
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("Числа в массиве: ");
                WriteArrayVi(array,1);
                Console.Write("Разница между минимальным и максимальным числом: "); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(max-min);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($", минимальное число: {min}, максимальное число: {max}.\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа 4 ###############################################################//
        //###########################################################################################################################//
        static void Program_4(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[4] {ProgramName_4}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                ////////**************** Logica **************//////// 
                int UserNumbers = 123;
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array,0,300);
                int result=0;
                for (int i = 0; i < array.Length; i++) 
                {
                    if (array[i] > 9 && array[i] < 100)
                    {
                        result++;
                    }
                }
                ////////**************** End Logica **************////////
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("123 сгенерерованных чисел в массиве: ");
                WriteArray(array,1);
                Console.Write("\nКоличество элементов массива, которые лежат в отрезке от 10 до 99: "); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(result);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(".\n");
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа 5 ###############################################################//
        //###########################################################################################################################//
        static void Program_5(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[5] {ProgramName_5}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                ////////**************** Logica **************//////// 
                Console.WriteLine("Введите размер массива (не больше 20-ти): ");
                int UserNumbers = Convert.ToInt32(Console.ReadLine());
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array,1,20);
                int[] resultArrey = new int[array.Length];
                int size = array.Length-1;
                int trig=0;
                if (array.Length%2 == 0)
                {
                    for (int i=0; i < size; i++)
                    {
                        resultArrey[i] = array[i] * array[size];
                        size--;
                    }
                }
                else
                {
                   for (int i=0; i < size; i++)
                    {
                        resultArrey[i] = array[i] * array[size];
                        size--;
                        trig=i+1;
                    } 
                    resultArrey[(array.Length-1) - trig] = array[(array.Length-1) - trig];
                }
                ////////**************** End Logica **************////////
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("Числа в массиве: ");
                WriteArray(array,1);
                Console.Write("Произведение пар чисел в массиве: "); 
                Console.ForegroundColor = ConsoleColor.Green;
                WriteArray(resultArrey,0);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа скрытая #########################################################//
        //###########################################################################################################################//
        static void Program_7(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = "Скрытое меню";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                devWrite(NameProg);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Генератор 20 случайных чисел");
                Console.ResetColor();
                ////////**************** Logica **************////////
                int[] array = CreaterArray(20);
                WriteArray(array,1);
                array = Shuffle(array,0,100);
                WriteArray(array,1);
                ////////**************** End Logica **************////////
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        /////////////////// функции - массивов //////////////////
                        static int WriteArray(int[] array, int zero)
                        {
                            int numbers = 0;
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (i != array.Length - 1)
                                {
                                    if (zero==1)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}, ");
                                    }
                                    else if (array[i] > 0)
                                    {
                                    numbers++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}, ");
                                    }
                                }
                                else
                                {
                                    if (zero==1)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}.\n");
                                    }
                                    else if (array[i] > 0)
                                    {
                                    numbers++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}.\n");
                                    }
                                    else 
                                    {
                                        Console.Write(".......\n");
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            }
                             if (zero==1)
                            {
                                return numbers = 0;
                            }
                            else
                            {
                                return numbers;
                            }
                            
                        }
                        ////////////////////////////////////////////////   
                        static int WriteArrayVi(decimal[] array, int zero) //2
                        {
                            int numbers = 0;
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (i != array.Length - 1)
                                {
                                    if (zero==1 || zero==2)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}, ");
                                    }
                                    else if (array[i] > 0 && zero == 0)
                                    {
                                    numbers++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}, ");
                                    }
                                }
                                else
                                {
                                    if (zero==1)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}.\n");
                                    }
                                    else if (array[i] > 0 && zero==0)
                                    {
                                    numbers++;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write($"{i+1}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($":{array[i]}.\n");
                                    }
                                    else 
                                    {
                                        Console.Write(".......\n");
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            }
                            if (zero==1)
                            {
                                return numbers = 0;
                            }
                            else 
                            {
                                return numbers;
                            }
                            
                            
                        }
                        //
                        static int[] CreaterArray(int number)
                        {
                            int[] array = new int[number];
                            for (int i = 0; i < array.Length; i++)
                            {
                                array[i] = i + 1;
                            }
                            return array;
                        }
                        //
                        static decimal[] CreaterArrayVi(int number) //2
                        {
                            decimal[] array = new decimal[number];
                            for (int i = 0; i < array.Length; i++)
                            {
                                array[i] = i + 1;
                            }
                            return array;
                        }
                        //
                        static int[] Shuffle(int[] array, int amount, int amount2)
                        {
                            
                            for (int i = 0; i < array.Length; i++)
                            {
                                int j = new Random().Next(0, i + 1);
                                int number = new Random().Next(amount, amount2);
                                 
                               // array[i] = array[i];
                                array[i] = number;
                            }
                            return array;
                        }
                        static decimal[] ShuffleVi(decimal[] array) //2
                        {
                            
                            for (int i = 0; i < array.Length; i++)
                            {
                                decimal j = new Random().Next(0, i + 1);
                                decimal number = new Random().Next(10, 800);
                                 
                                array[i] = array[i];
                                array[i] = number;
                            }
                            return array;
                        }

//******************************************************** MAIN *********************************************************************//
//###################################################################################################################################//
        static void Main(string[] args)
        {
            int Exit_Play = 1;
            String PresskeyP = "Null";
            const String NameProg = "Главное меню";
            while (Exit_Play == 1)
            {
                Console.Clear();
                WelcomeWrite(NameProg);
                PresskeyP = Convert.ToString(Console.ReadKey().Key);
                //////////////////////////////////// Выбор пункта меню, нужной программы ///////////////////////////////////////////////////////
                if (PresskeyP == "D1" || PresskeyP == "NumPad1")
                {
                    Program_1(Exit_Play);
                }
                else if (PresskeyP == "D2" || PresskeyP == "NumPad2")
                {
                    Program_2(Exit_Play);
                }
                else if (PresskeyP == "D3" || PresskeyP == "NumPad3")
                {
                    Program_3(Exit_Play);
                }
                else if (PresskeyP == "D4" || PresskeyP == "NumPad4")
                {
                    Program_4(Exit_Play);
                }
                 else if (PresskeyP == "D5" || PresskeyP == "NumPad5")
                {
                    Program_5(Exit_Play);
                }
                else if (PresskeyP == "D6" || PresskeyP == "NumPad6")
                {
                    //Program_6(Exit_Play);
                }
                else if (PresskeyP == "D7" || PresskeyP == "NumPad7")
                {
                    Program_7(Exit_Play);
                }
                else if (PresskeyP == "q0" || PresskeyP == "End" || PresskeyP == "Backspace" || PresskeyP == "Escape" || PresskeyP == "Q1" || PresskeyP == "Q" || PresskeyP == "q")
                {
                    break;
                }
            }
        }
//######################################################## END ###############################################################//
    }
}
 //###########################################################################################################################//