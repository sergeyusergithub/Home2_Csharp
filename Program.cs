using System.Text;

namespace Home2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задача 1. Одномерный и двумерный массивы.
            // Найти min, max, сумму, произведение,
            // сумму четный элементов, сумму нечетных
            // столбцов

            Console.WriteLine("\nЗадача 1.");
            Console.WriteLine("Введите 5 чисел ->");

            // одномерный массив
            int[] A = new int[5];

            int item = 0;
            foreach (int i in A)
            {
                A[item] = Convert.ToInt32(Console.ReadLine());
                item++;
            }

            Console.WriteLine("=======================================");
            Console.WriteLine("Массив А:");
            foreach (int i in A)
            {
                Console.Write(String.Format("{0:d}", i) + ' ');
            }

            Console.WriteLine();

            double[,] B = new double[3, 4];

            Random rand = new Random();


            Console.WriteLine("Матрица В:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.NextDouble() * 10;
                    Console.Write(String.Format("{0:f2} ", B[i, j]));
                }
                Console.WriteLine();
            }

            double max = A[0], min = A[0];

            double sum = 0, mult = 1;

            double sum_even = 0;

            // в цикле определяем максимальное,
            // минимальное значение
            // часть общей суммы и произведения
            // сумму четных элементов массива
            foreach (int i in A)
            {
                if (max < i)
                {
                    max = i;
                }
                if (min > i)
                {
                    min = i;
                }
                if (i % 2 == 0)
                {
                    sum_even += i;
                }
                sum += i;
                mult *= i;
            }

            // в цикле опеределяем максимальное и 
            // минимальное значение учитывая 
            // предыдущие значения мин. и макс.
            // оставшуюся часть общей суммы и
            // произведения
            foreach (double i in B)
            {
                if (max < i)
                {
                    max = i;
                }
                if (min > i)
                {
                    min = i;
                }

                sum += i;
                mult *= i;
            }

            double sum_odd_matrix = 0;

            // в цикле определяем сумму нечетных
            // столбцов матрицы
            for (int i = 0; i < B.GetLength(0); ++i)
            {
                for (int j = 0; j < B.GetLength(1); ++j)
                {
                    if (j % 2 == 0)
                    {
                        sum_odd_matrix += B[i, j];
                    }
                }
            }

            // выводим полученные результаты
            Console.WriteLine(String.Format("Максимальное значение {0:f2}, минимальное значение {1:f2}", max, min));
            Console.WriteLine(String.Format("Общая сумма значений {0:f2}", sum));
            Console.WriteLine(String.Format("Общее произведение значений {0:f2}", mult));
            Console.WriteLine(String.Format("Сумма четных значений матрицы {0:f2}", sum_even));
            Console.WriteLine(String.Format("Сумма нечетный значений столбцов матрицы {0:f2}", sum_odd_matrix));

            // задача 2. Сумма элементов двумерного массива
            // между максимальными и минимальным элементами

            Console.WriteLine("\n=======================================\nЗадача 2.");

            int[,] Mtr = new int[5, 5];

            Random rnd = new Random();

            // с помощью цикла заполняем матрицу случайными
            // числами в заданном диапазоне
            for (int i = 0; i < Mtr.GetLength(0); i++)
            {
                for (int j = 0; j < Mtr.GetLength(1); j++)
                {
                    Mtr[i, j] = rnd.Next(-100, 100);
                    Console.Write(String.Format("{0:d}\t", Mtr[i, j]));
                }
                Console.WriteLine();
            }

            max = Mtr[0, 0];
            min = Mtr[0, 0];

            // в цикле опеределяем минимальный и 
            // максимальный элемент матрицы
            foreach (int i in Mtr)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine(String.Format("Min = {0}, max = {1}", min, max));

            sum = 0;

            // в цикле определяем сумму в 
            // диапазоне между максимумом и 
            // минимумом
            foreach (int i in Mtr)
            {
                if ((min < i) && (i < max))
                {
                    sum += i;
                }
            }

            Console.WriteLine(String.Format("Сумма = {0}", sum));

            // Задача 3. шифр цезаря

            Console.WriteLine("\n=======================================\nЗадача 3.");

            Console.WriteLine("Введите строку для применения шифра Цезаря ->");

            string str;

            // ввод строки пользователем
            str = Console.ReadLine();

            Console.WriteLine("Зашифрованная строка:");
            // переменная для сохранения зашифрованной строки
            string str_new = null;
            // цикл для шифрования строки
            for (int i = 0; i < str.Length; i++)
            {

                str_new += (char)((int)str[i] + 3);
            }
            Console.WriteLine(str_new);
            Console.WriteLine("Расшифрованная строка:");

            str = null;
            // цикл для расшифровки строки
            for (int i = 0; i < str_new.Length; i++)
            {

                str += (char)((int)str_new[i] - 3);
            }

            Console.WriteLine(str);


            // задача 4. Работа с матрицами, умножение 
            // матрицы на число, сложение матриц,
            // произведение матриц

            int rows = 0, cols = 0;
            Console.WriteLine("\n=======================================\nЗадача 4.");
            Console.WriteLine("Введите количество строк и столбцов матрицы A->");

            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());

            //Random rnd = new Random();

            int[,] MatrA = new int[rows, cols];
            Console.WriteLine("Исходная матрица A:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    MatrA[i, j] = rnd.Next(0, 20);
                    Console.Write($"{MatrA[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите число для умножения на матрицу->");

            int int_mult = Convert.ToInt32(Console.ReadLine());

            int[,] newMatr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatr[i, j] = MatrA[i, j] * int_mult;
                }
            }

            Console.WriteLine("Матрица A умноженная на число:");

            item = 1;
            foreach (int i in newMatr)
            {

                Console.Write(String.Format("{0} ", i));
                if (item % cols == 0)
                {
                    Console.WriteLine();
                }
                item++;
            }
            Console.WriteLine();

            int[,] MatrB = new int[rows, cols];

            Console.WriteLine("Матрица B для сложения:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    MatrB[i, j] = rnd.Next(0, 20);
                    Console.Write($"{MatrB[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма двух матриц A + B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatr[i, j] = MatrA[i, j] + MatrB[i, j];
                    Console.Write($"{newMatr[i, j]} ");
                }
                Console.WriteLine();
            }

            int rowsC = 0, colsC = 0;

            Console.WriteLine("Введите количество строк и столбцов матрицы C->");

            rowsC = Convert.ToInt32(Console.ReadLine());
            colsC = Convert.ToInt32(Console.ReadLine());


            if (cols == rowsC)
            {
                int[,] MatrC = new int[rowsC, colsC];
                Console.WriteLine("Исходная матрица C для умножения:");
                for (int i = 0; i < rowsC; i++)
                {
                    for (int j = 0; j < colsC; j++)
                    {
                        MatrC[i, j] = rnd.Next(0, 20);
                        Console.Write($"{MatrC[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nУмножение двух матриц:");
                int max_rows = (rows > rowsC) ? rows : rowsC;

                for (int i = 0; i < max_rows; i++)
                {


                    for (int j = 0; j < cols; j++)
                    {
                        if (i < rows)
                        {
                            Console.Write(String.Format("{0:d2} ", MatrA[i, j]));
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }


                    Console.Write("\t");


                    for (int j = 0; j < colsC; j++)
                    {
                        if (i < rowsC)
                        {
                            Console.Write(String.Format("{0:d2} ", MatrC[i, j]));
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    int[,] MatrMult = new int[rows, colsC];
                    for (int j = 0; j < rows; j++)
                    {
                        for (int k = 0; k < colsC; k++)
                        {
                            int sum_new = 0;
                            for (int m = 0; m < cols; m++)
                            {
                                sum_new += MatrA[j, m] * MatrC[m, k];
                            }

                            MatrMult[j, k] = sum_new;

                        }
                    }

                    Console.Write("\t");

                    for (int j = 0; j < colsC; j++)
                    {
                        if (i < rows)
                        {
                            Console.Write(String.Format("{0:d2} ", MatrMult[i, j]));
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Матрицы не могут быть умножены");
            }
            Console.WriteLine();


            // задача 5. вычисление арифметических выражений



            Console.WriteLine("\n=======================================\nЗадача 5.\nВведите арифметическое выражение->\n");

            // строка содержащая арифметическое выражение
            string arifmetic_statment = Console.ReadLine();

            // определяем отдельным массивом знвковые разделители
            char[] delim = { '+', '-' };
            // определяем массив строк в которых находятся числовые значения
            // введенного пользователем выражения
            string[] digit = arifmetic_statment.Split(delim);

            // определяем числовые разделители, чтобы можно было из
            // введенного выражения выделить введенные знаки и их последовательность
            char[] digit_delim = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            // маассив строк содержащий знаки выражения
            string[] sign = arifmetic_statment.Split(digit_delim);

            // переменная содержащая результат всего выражения,
            // первоначально поместим первое число выражения
            int result = Convert.ToInt32(digit[0]);
            // из за странного хранения массива строк, содержащего
            // знаки выражения, необходимо использовать дополнительную
            // переменную содержащую индекс чисел из числового массива
            int ind = 0;
            // цикл вычисляющий результат введенного выражения
            for (int i = 0; i < sign.Length; i++)
            {
                if (sign[i] == "+")
                {
                    result += Convert.ToInt32(digit[ind + 1]);
                    ind++;
                }
                else if (sign[i] == "-")
                {
                    result -= Convert.ToInt32(digit[ind + 1]);
                    ind++;
                }
            }
            Console.WriteLine("Результат вычисления выражения\n" + arifmetic_statment + " = " + Convert.ToString(result));


            // задача 6. Изменить регистр первых букв в предложении
            Console.WriteLine("\n=======================================\nЗадача 6.");
            Console.WriteLine("Введите строку->");
            // переменная для введенной пользователем строки
            str = null;
            // переменная для хранения первого символа
            // необходимого для преобразования в вверхний регистр
            string strUpper;
            // строковая переменная в которую можно
            // еще и записывать отдельные символы
            StringBuilder newstr = new StringBuilder();

            // индекс необходимого символа для преобразования регистра
            int index = 0;
            // разделители по которым будут определяться
            // начала предложения
            string txt_delim = ".!?";

            // ввод пользователя необходимой строки
            str = Console.ReadLine();

            // преобразуем введенную строку,
            // в строку в которой можно перезаписывать
            // необходимы символ
            newstr.Append(str);


            // перобразование первого введенного
            // символа строки в верхний регистр
            strUpper = str.Substring(index, 1).ToUpper();
            newstr[index] = strUpper[index];

            // строка символов необходимых для определения
            // первого символа начала предложения
            string word_delim = "abcdefghijklmnopqrstuvwxyz" +
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЧЦШЩЪЫЬЭЮЯ" +
            "абвгдеёжзийклмнопрстуфхчцшщъыьэюя" +
            "0123456789";

            // цикл определения местоположения символа
            // необходимого для преобразования регистра 
            // и его преобразование в верхний регистр
            while ((0 <= index) && (index < str.Length))
            {
                index = str.IndexOfAny(txt_delim.ToCharArray(), index + 1);
                index = str.IndexOfAny(word_delim.ToCharArray(), index);
                if (index != -1)
                {
                    strUpper = str.Substring(index, 1).ToUpper();
                    newstr[index] = strUpper[0];
                }
            }

            // вывод результирующей строки
            Console.WriteLine("Строка после преобразования:");
            Console.WriteLine(newstr);

            // задача 7. Удаление из текста не допустимого слова
            // и замена его на *

            Console.WriteLine("\n=======================================\nЗадача 7.");
            Console.WriteLine("Введите текст ->");

            string text = Console.ReadLine();

            index = 0;

            string sym = null;

            string del_str;
            int str_size = 0;

            Console.WriteLine("Введите запрещенное слово ->");
            del_str = Console.ReadLine();

            str_size = del_str.Length;

            int count = 0;

            for (int i = 0; i < str_size; i++)
            {
                sym += "*";
            }
            while ((0 <= index) && (index < text.Length))
            {
                index = text.IndexOf(del_str, index + 1);
                if (index != -1)
                {
                    count++;
                }
            }

            text = text.Replace(del_str, sym);

            Console.WriteLine("\nИсходный текст после исключения запрещенного слова:");
            Console.WriteLine(text);
            Console.WriteLine($"\nКоличество вхождения данного слова в текст: {count}");


        }
    }
}
