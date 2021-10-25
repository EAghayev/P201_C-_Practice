using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework-1
            //int[] numbers = new int[] { 45, 10, 54, 66, 74, 18 };

            //int counter = 0;
            //int temp;
            //int sumOfDigits;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    temp = numbers[i];
            //    sumOfDigits = 0;

            //    while (temp > 0)
            //    {
            //        sumOfDigits += temp % 10;
            //        temp = (temp - temp % 10) / 10;
            //    }


            //    if (sumOfDigits < 10)
            //        counter++;
            //}
            //Console.WriteLine("reqemlerinin cemi 10-den kicik olan ededlerin sayi: " + counter);
            #endregion

            #region Homework-3
            //int num = 64;

            //int i = 1;
            //while (i * i <= num)
            //{
            //    i++;
            //}

            //Console.WriteLine("result: " + (i - 1));
            #endregion

            //Verilmis ededler siyahisindaki en boyuk ededi tapan program
            #region Task-1

            //int[] numbers = new int[] { 45, 10, -100, 90, 165, 85 };

            //if(numbers.Length > 0)
            //{
            //    int max = numbers[0];

            //    for(int i = 1; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] > max)
            //            max = numbers[i];
            //    }

            //    Console.WriteLine("Siyahidaki en boyuk element: "+max);
            //}
            //else
            //{
            //    Console.WriteLine("Siyahida element yoxdur!");
            //}


            #endregion

            //Verilmis ededler siyahisindaki 3-e ve ya 7-e bolunen ededlerin ededi ortasini tapan proqram
            #region Task2
            //int[] numbers = new int[] { 45, 10, -100, 90, 165, 85 };

            //int sum = 0;
            //int counter = 0;
            //int result;

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if(numbers[i]%3==0 || numbers[i] % 7 == 0)
            //    {
            //        sum += numbers[i];
            //        counter++;
            //    }
            //}

            //if(counter > 0)
            //{
            //    result = sum / counter;

            //    Console.WriteLine("ededi orta="+result);
            //}
            //else
            //{
            //    Console.WriteLine("Siyahida 3-e ve ya 7-e bolunen eded yoxdur!");
            //}

            #endregion


            // Istifadeciden ad ve soyad daxil edim console-a fullname yazdirmaq
            // adin uzunlugu 3-den kicik ve ya 20-den boyukdurse tekrar ad daxil edilmesini istemek
            #region Task3
            //string name;
            //string surname;

            //bool checkNameInput = true;
            //do
            //{
            //    if(checkNameInput == false)
            //        Console.WriteLine("Adinizi duzgun daxil edin: (uzunluq min 3, max 20 ola biler) ");
            //    else 
            //        Console.WriteLine("Adinizi daxil edin:");


            //    name = Console.ReadLine();

            //    checkNameInput = false;

            //} while (name.Length<3 || name.Length>20);

            //Console.WriteLine("Soyadinizi daxil edin: ");
            //surname = Console.ReadLine();

            //string fullName = name + " " + surname;

            //Console.WriteLine("FullName: "+fullName);
            #endregion

            //Daxil edilmis string deyerini terkibinde 1 charinin olub olmadigini tapan alqoritm

            #region Task4
            Console.WriteLine("Yazi daxil edin:");
            string text = Console.ReadLine();
            bool hasChar = false;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '1')
                {
                    hasChar = true;
                    break;
                }
            }

            if(hasChar)
                Console.WriteLine(text + " yazisinda 1 chari var!");
            else
                Console.WriteLine(text + " yazisinda 1 chari YOXDUR!");
            #endregion


        }
    }
}
