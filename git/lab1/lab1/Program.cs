using System;
using static System.Net.Mime.MediaTypeNames;

namespace lab1
{
    
    class Program
    {
        public class Student
        {

            public string firstname;
            public string lastname;
            public int numbergroup;
            public int[] points = new int[5];
            public double sredbalstudenta()
            {
                double sred=0;
                for (int i=0; i < points.Length; i++)
                {
                    sred = sred + points[i];
                }
                sred = sred / points.Length;
                return sred;
            }
        }
        static void Main(string[] args)
        {
            string comm = "third commit";
            int numgroup,kol = 5;
            Student[] student = new Student[kol];
            student[0] = new Student { firstname = "alexander", lastname = "yankovskiy", numbergroup = 2, points = new int[] { 10, 3, 6, 4, 5 } };
            student[1] = new Student { firstname = "timofey", lastname = "grichenko", numbergroup = 2, points = new int[] { 8, 7, 9, 4, 5 } };
            student[2] = new Student { firstname = "alex", lastname = "ivanov", numbergroup = 1, points = new int[] { 9, 6, 6, 3, 5 } };
            student[3] = new Student { firstname = "egor", lastname = "smirnov", numbergroup = 2, points = new int[] { 9, 6, 6, 3, 5 } };
            student[4] = new Student { firstname = "alex", lastname = "listkov", numbergroup = 1, points = new int[] { 5, 6, 6, 3, 5 } };
            string str;
            for (; ; )
            {
                Console.WriteLine("введите one,если хотите рассчитать средний бал 1 студента;");
                Console.WriteLine("введите group,если хотите рассчитать средний бал всей группы");
                Console.WriteLine("введите end для завершения работы");
                str = Console.ReadLine();

                switch (str)
                {
                    case "one":
                        Console.WriteLine("1-й коммит");
                        
                        Console.WriteLine("введите фамилию студента для рассчёта среднего балла (2-й коммит)");
                        string lastname = " ";
                        lastname = Console.ReadLine();

                        //int a = 1;
                        for (int i = 0; i < kol; i++)
                        {
                            if (student[i].lastname == lastname) { Console.WriteLine(student[i].sredbalstudenta()); }


                            if (i == kol) Console.WriteLine("error");
                        }
                        break;
                    case "group":
                        Console.WriteLine("введите группу средний бал которой нужно рассчитать");
                        numgroup = Int32.Parse(Console.ReadLine());
                        double sredgroup = 0;
                        int b = 0;
                        for (int i = 0; i < kol; i++)
                        {

                            if (student[i].numbergroup == numgroup) { sredgroup = sredgroup + student[i].sredbalstudenta(); b++; }

                        }
                        sredgroup = sredgroup / b;
                        Console.WriteLine("количество студентов в группе " + b);
                        Console.WriteLine(sredgroup);
                        break;
                }
                if (str == "end") break ;
            }
           
        }
    }
}
