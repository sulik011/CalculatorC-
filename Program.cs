
using System;
using System.Globalization;

class My
{
    static int GetDecimalDigitsCount(double number)
    {
        string str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." });
        return str.Contains(".") ? str.Remove(0, Math.Truncate(number).ToString().Length + 1).Length : 0;
    }
    static void Main()
    {
        string first_number_input, second_number_input, operation;      
        Console.WriteLine("  Введите первое число:_");
        first_number_input = Console.ReadLine();
        Console.WriteLine("  Что будем делать?  0_0");
        operation = Console.ReadLine();
        Console.WriteLine("  Введите второе число:_");
        second_number_input = Console.ReadLine();



        if (operation is "*" | operation is "/" | operation is "+" | operation is "-")
        {




                            if (operation is "*")
                            {
                                string step_for_conv = Convert.ToString(first_number_input);
                                int cnt = 0;
                                for (int i = 0; i < step_for_conv.Length; i++)
                                    if (step_for_conv[i] == ',') cnt++;
                                Console.WriteLine(cnt);


                                if (cnt > 1)
                                {
                                    int frst_num_int = int.Parse(step_for_conv);



                                    int global_result = 0, ten = 1;

                                    Console.WriteLine("  Умножаем каждую цифру втрого числа на первое число:   +_+");

                                    Console.WriteLine("  Вспомните!\n  Когда мы умножаем в столбик, с каждой следующей цифрой произведение цифры и числа двигаем на одну клетку влево))\n  WoW\n  Поэтому втрую цифру с права нужно умножить на 10, третью на 100 и т.д");

                                    for (int j = 0; j < second_number_input.Length; j++)
                                    {
                                        if (j > 0)
                                        {
                                            ten *= 10;
                                        }
                                    }
                                    Console.WriteLine(ten);
                                    for (int i = 0; i < second_number_input.Length; i++)
                                    {

                                        string a = Convert.ToString(second_number_input[i]);
                                        int scnd_num_int = int.Parse(a),
                                            result = 0;
                                        if (second_number_input.Length >= 2)
                                        {
                                            scnd_num_int *= ten;
                                            ten /= 10;
                                        }


                                        result = scnd_num_int * frst_num_int;
                                        Console.WriteLine("  " + scnd_num_int + " * " + frst_num_int + " = " + result + "");
                                        if (i == second_number_input.Length - 1)
                                        {
                                            Console.Write("  Прибавляем произведение цифры и числа к предыдущему произведению\n  Ответ: " + global_result + " + " + result + " = ");
                                            global_result += result;
                                            Console.WriteLine("" + global_result + "");

                                        }
                                        else
                                        {
                                            global_result += result;
                                        }
                                    }
                                }
                                //    ----------------------------------------------------------------------------------------------------------------------------
                                else
                                {
                                    Console.WriteLine("  Десятичные дроби умножаются немного по-другому...");
                                    double first_num = double.Parse(first_number_input);
                                    double second_num = double.Parse(second_number_input);

                                    Console.WriteLine("  Сначала, нам нужно избавиться от дробной части, тоесть десятичную дробь умножить на 10, 100, 1000 и т.д\n  Количество нулей зависит от количества цифр после запятой");
                                    string counter_str = "1";
                                    int after_comma = 0;
                                    int count_ = GetDecimalDigitsCount(first_num),
                                    count_2 = GetDecimalDigitsCount(second_num);



                                    if (count_ == 0 | count_2 == 0)
                                    {
                                        if (count_ == 0) after_comma += count_2;
                                        if (count_2 == 0) after_comma += count_;
                                    }
                                    else
                                    {
                                        after_comma += count_2;
                                        after_comma += count_;
                                    }
                                    for (int i = 0; i < after_comma; i++)
                                    {
                                        counter_str += "0";
                                    }
                                    double counter = double.Parse(counter_str);

                                    if (count_ == 0)
                                    {
                                        Console.WriteLine("  " + second_num + " * " + counter + " = " + second_num * counter + "");
                                        second_num *= counter;
                                    }
                                    if (count_2 == 0)
                                    {

                                        Console.WriteLine("  " + first_num + " * " + counter + " = " + first_num * counter + "");
                                        first_num *= counter;
                                    }
                                    if (count_ > 0 & count_2 > 0) first_num *= counter;
                                    if (count_ > 0 & count_2 > 0) second_num *= counter;
                                    Console.WriteLine("  Теперь мы должны перемножить наши 'целые' числа");
                                    double result = first_num * second_num;

                                    Console.WriteLine("  " + first_num + " * " + second_num + " = " + result + "");

                                    Console.WriteLine("  Получившееся произведение необходимо уравнять, тоеть нужно произведение разделить на сумму цифр после нуля первого и второго чисел\n  V_V");
                                    Console.WriteLine("  " + result + " / " + counter + " = " + result / counter + " ");


                                }
                                //    ----------------------------------------------------------------------------------------------------------------------------

                            }
                        }





                        if (operation is "/")
                        {
                            // NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                            //   {
                            //       NumberDecimalSeparator = ".",
                            //   };
                            try
                            {
                                int first_num = int.Parse(first_number_input);
                                int second_num = int.Parse(second_number_input);

                                double result = first_num / second_num;
                                double rest = result * second_num;
                                Console.WriteLine("  Делим первое число на второе:\n  " + first_num + " / " + second_num + " = " + result + "\n  >>>>>>>>>>>");
                                Console.WriteLine("  Чтобы проверить наш ответ, мы должны ответ умножить на делитель\n");

                                Console.WriteLine("  " + result + " * " + second_num + " = {0}", rest);
                            }
                            catch
                            {

                                double first_num = double.Parse(first_number_input);
                                double second_num = double.Parse(second_number_input);


                                int count = GetDecimalDigitsCount(first_num),
                                    count2 = GetDecimalDigitsCount(second_num);
                                string counter_str = "1";

                                if (count > count2)
                                {
                                    for (int i = 0; i < count; i++)
                                    {
                                        counter_str += "0";
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < count2; i++)
                                    {
                                        counter_str += "0";
                                    }
                                }
                                Console.WriteLine(
                                  "  Так как вы ввели десятичную(ые) дробь(и), мы должны найти число, у которого наибольшее количество цифр после запятой и превратить ее в целое\n  Для этого нужно умножить на 10, 100, 1000 и т.д\n  Количество нулей зависит от количества цифр после запятой\n  =_=");
                                int counter = int.Parse(counter_str);
                                Console.WriteLine("  В Данном случае нам нужно умножить оба числа на " + counter + "");
                                double empty_var = first_num * counter;
                                double empty_var_2 = second_num * counter;
                                Console.WriteLine("  " + first_num + " * " + counter + " = " + empty_var + "");
                                Console.WriteLine("  " + second_num + " * " + counter + " = " + empty_var_2 + "");
                                first_num *= counter;
                                second_num *= counter;
                                double result = first_num / second_num;
                                Console.WriteLine("  Делим первое число на второе:\n  " + first_num + " / " + second_num + " = " + result + "\n  <<<<<<<<<<<<");
                                Console.WriteLine("  Чтобы проверить наш ответ, мы должны ответ умножить на делитель\n");
                                double rest = result * second_num;

                                Console.WriteLine("" + result + " * " + second_num + " = {0}", rest);
                            }
                        }

                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        if (operation is "+")
                        {
                            if (first_number_input.Length >= 3 | second_number_input.Length >= 3)
                            {
                                char[] arr = first_number_input.ToCharArray();
                                int ind = first_number_input.Length - 1, ind2 = first_number_input.Length - 2;

                                char nums = arr[ind];
                                int num = Convert.ToInt32(nums);
                                Console.WriteLine(num);

                            }
                            else
                            {
                                Console.WriteLine("Тут все просто...");
                                int first_num = int.Parse(first_number_input);
                                int second_num = int.Parse(second_number_input);

                                Console.WriteLine("  " + first_num + " + " + second_num + " = " + first_num + second_num + " \n  e_e");
                            }
                        }

                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        if (operation is "-")
                        {
                            Console.WriteLine(" Просто...");
                            int first_num = int.Parse(first_number_input);
                            int second_num = int.Parse(second_number_input);
                            int result = first_num - second_num;

                            Console.WriteLine("  " + first_num + " + " + second_num + " = " + result + " \n  e_e");
                        }
        else
        {
          Console.WriteLine("Sorry...");
        }


    }
}
  

