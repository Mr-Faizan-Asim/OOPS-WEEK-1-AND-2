using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Program
    {
        class student
        {
            public string name;
            public int roll;
            public float cgpa;
            public char isHosellite;
            public string department;
            public void top3(student[] s, ref int count)
            {
                for (int i = 0; i < count; i++)
            {

                }
            }            
        }
        static void Main(string[] args)
        {
            //task1();
            //task2();
            student_management_system();
        }
        static void student_management_system()
        {
            int st_count = 0;
            student st = new student();
            while (true)
            {

                Console.Clear();
                string[] option = { "1. ADD STUDENT", "2. VIEW STUDENT", "3. TOP 3 STUDENTS" };
                int opt = to_show_option(option);
                student[] s = new student[100];
                while(opt == 1)
                {
                    Console.Clear();
                    s[st_count] = add_new_student(st_count);
                    st_count++;
                    break;
                }
                while(opt == 2)
                {

                    Console.Clear();
                    view_all_student(s,st_count);
                    break;
                }
                while (opt == 3)
                {

                }
            }

        }
        static void view_all_student(student[] s, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("NAME: {0} ROLL: {1} CGPA: {2}", s[i].name, s[i].roll, s[i].cgpa);

            }
        }
        static student add_new_student(int count)
        {
            student obj = new student();
            Console.WriteLine("ENTER CGPA");
            string temp = Console.ReadLine();
            obj.cgpa = float.Parse(temp);
            Console.WriteLine("ENTER NAME");
            temp = Console.ReadLine();
            obj.name = temp;
            Console.WriteLine("ENTER ROLL");
            temp = Console.ReadLine();
            obj.roll = int.Parse(temp);
            Console.WriteLine("NAME: {0} ROLL: {1} CGPA: {2}", obj.name, obj.roll, obj.cgpa);
            Console.ReadKey();
            return obj;

        }

        static int to_show_option(string[] option)
        {
            for(int i = 0; i <  option.Length; i++)
            {
                Console.WriteLine(option[i]);
            }
            while (true)
            {

                string temp = Console.ReadLine();
                if(temp == "3" || temp == "1"|| temp == "2")
                {
                     return int.Parse(temp);
                }
            }
            return 0;
        }
        static void task2()
        {

            // First Object
            student s1 = new student();
            // Second object
            student s2 = new student();
            Console.WriteLine("ENTER CGPA");
            string temp = Console.ReadLine();
            s1.cgpa = float.Parse(temp);
            Console.WriteLine("ENTER NAME");
            temp = Console.ReadLine();
            s1.name = temp;
            Console.WriteLine("ENTER ROLL");
            temp = Console.ReadLine();
            s1.roll = int.Parse(temp);
            Console.WriteLine("NAME: {0} ROLL: {1} CGPA: {2}", s1.name, s1.roll, s1.cgpa);
            Console.ReadKey();
        }
        static void task1()
        {

            // First Object
            student s1 = new student();
            // Second object
            student s2 = new student();
            s1.cgpa = 3.022F;
            s1.name = "FAIZAN";
            s1.roll = 111;
            s2.cgpa = 3.9F;
            s2.name = "Ali";
            s2.roll = 112;
            Console.WriteLine("NAME: {0} ROLL: {1} CGPA: {2}", s1.name, s1.roll, s1.cgpa);
            Console.WriteLine("NAME: {0} ROLL: {1} CGPA: {2}", s2.name, s2.roll, s2.cgpa);
            Console.ReadKey();
        }
    }
}
