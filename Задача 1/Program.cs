using System;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оценките на Тошко са: ");
            int[] Toshko = new int[4];
            Toshko[0] = int.Parse(Console.ReadLine());
            Toshko[1] = int.Parse(Console.ReadLine());
            Toshko[2] = int.Parse(Console.ReadLine());
            Toshko[3] = int.Parse(Console.ReadLine());


            Console.WriteLine("Оценките на Гошко са: ");
            int[] Goshko = new int[4];
            Goshko[0] = int.Parse(Console.ReadLine());
            Goshko[1] = int.Parse(Console.ReadLine());
            Goshko[2] = int.Parse(Console.ReadLine());
            Goshko[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Оценките на Петьо са: ");
            int[] Petio = new int[4];
            Petio[0] = int.Parse(Console.ReadLine());
            Petio[1] = int.Parse(Console.ReadLine());
            Petio[2] = int.Parse(Console.ReadLine());
            Petio[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Оценките на Иван са: ");
            int[] Ivan = new int[4];
            Ivan[0] = int.Parse(Console.ReadLine());
            Ivan[1] = int.Parse(Console.ReadLine());
            Ivan[2] = int.Parse(Console.ReadLine());
            Ivan[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Оценките на Калоян са: ");
            int[] Kaloqn = new int[4];
            Kaloqn[0] = int.Parse(Console.ReadLine());
            Kaloqn[1] = int.Parse(Console.ReadLine());
            Kaloqn[2] = int.Parse(Console.ReadLine());
            Kaloqn[3] = int.Parse(Console.ReadLine());




            int i = 0;
            int i2 = 0;
            int i3 = 0;
            int i4 = 0;
            int i5 = 0;
            int i6 = 0;


            int sum = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;


            float average = 0.0f;
            float average2 = 0.0f;
            float average3 = 0.0f;
            float average4 = 0.0f;
            float average5 = 0.0f;
            float average6 = 0.0f;

            


            for (i = 0; i < Toshko.Length; i++)
            {
                sum += Toshko[i];
            }
            average = (float)sum / Toshko.Length;

            Console.WriteLine("Средния успех на Тошко е: " + average);




            for (i2 = 0; i2 < Goshko.Length; i2++)
            {
                sum2 += Goshko[i2];
            }
            average2 = (float)sum2 / Goshko.Length;
            
            Console.WriteLine("Средния успех на Гошко е: " + average2);




            for (i3 = 0; i3 < Petio.Length; i3++)
            {
                sum3 += Petio[i3];
            }
            average3 = (float)sum3 / Petio.Length;

            Console.WriteLine("Средния успех на Петьо е: " + average3);




            for (i4 = 0; i4 < Ivan.Length; i4++)
            {
                sum4 += Toshko[i4];
            }
            average4 = (float)sum4 / Ivan.Length;

            Console.WriteLine("Средния успех на Иван е: " + average4);




            for (i5 = 0; i5 < Kaloqn.Length; i5++)
            {
                sum5 += Kaloqn[i5];
            }
            average5 = (float)sum5 / Kaloqn.Length;

            Console.WriteLine("Средния успех на Калоян е: " + average5);

            double averageall = (average + average2 + average3 + average4 + average5) / 5;


            Console.WriteLine("Средния успех на класа е: " + averageall);




        }


    }


}