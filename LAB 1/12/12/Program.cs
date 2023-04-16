using System;
using System.Diagnostics.CodeAnalysis;

namespace BootingCSharp
{
    class program
    {
        static void Main(string[] args)
        {
            //string var1;
            //extra_task();
            //task1();
            //var1 = task2();
            //float_task3();
            //calculate_area_task4();
            //lab2_task1();
            //print_task2(5);
            //lab2_task3();
            //lab_task_4();
            //lab3_task1();
            //read_data();
            string path = "C:\\A DISK\\C#\\testing.txt";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                readData(path,names,password);
                Console.Clear();
                option = to_show_menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("ENTER NAME: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("PASSWORD: ");
                    string p = Console.ReadLine();
                    signin(n,p,names,password);
                }
                else if(option == 2)
                {
                    Console.WriteLine("ENTER NAME: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("PASSWORD: ");
                    string p = Console.ReadLine();
                    signup(path, n, p);
                }
            }
            while (option < 3);
        }
        static string parsedata(string record,int field) 
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path,string[] names,string[] password) {
                int x = 0;
                if (File.Exists(path))
                {
                    StreamReader fileVar = new StreamReader(path);
                    string record;
                    while ((record = fileVar.ReadLine()) != null)
                    {
                        names[x] = parsedata(record, 1);
                        password[x] = parsedata(record, 2);
                        x++;
                        if (x >= 5)
                        {
                            break;
                        }
                    }
                    fileVar.Close();
                }
                else
                {
                    Console.WriteLine("NOT EXSISTS");
                }
        }
        static void signin(string n,string p, string[] names,string[] password) {
                bool flag = false;
                for (int x = 0; x < 5; x++)
                {
                    if (n == names[x] && p == password[x])
                    {
                        Console.WriteLine("VALID");
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("INVALID");
                }
                Console.ReadKey();
            }
        static void signup(string path,string n,string p)
            {
                StreamWriter fileVar = new StreamWriter(path, true);
                fileVar.WriteLine(n + "," + p);
                fileVar.Flush();
                fileVar.Close();

            }
        static int to_show_menu()
        {
            string[] arr = { "1. SIGN IN", "2. SIGN UP", "3. Exit" };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);  
            }
            int Task = int.Parse(Console.ReadLine());
            return Task;
            
        }
        static void task1()
        {
            Console.WriteLine("HELLO WORLD");
            Console.Write("FAIZAN");
            Console.ReadKey();  
        }
        static string task2() {
            string temp;
            temp = Console.ReadLine();
            return temp;
        }
        static void float_task3()
        {
            float var = 2.2F;
            string str;
            Console.WriteLine(var);
            str = Console.ReadLine();  
            var = float.Parse(str);
            Console.WriteLine(var);
        }

        static void calculate_area_task4()
        {
            string temp;
            float length;
            temp = Console.ReadLine();
            length = float.Parse(temp);
            float area = length * length;
            Console.WriteLine("AREA IS : {0}",area);
        }

        static void lab2_task1()
        {
            string str;
            str = Console.ReadLine();   
            int marks = int.Parse(str);
            if(marks > 50) {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }
        static void print_task2(int n)
        {
            for(int i = 0; i < n ; i++)
            {
                Console.WriteLine("ABC");
            }
        }
        static void lab_task_4()
        {
            int[] arr = new int[3];
            int larg = -100;
            for(int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 3; i++)
            {
                if(larg < arr[i])
                {
                    larg = arr[i];
                }
            }
            Console.WriteLine(larg);
            
        }
   
        static void lab2_task3()
        {
            string temp;
            int sum = 0;
            int n;
            do
            {
                temp = Console.ReadLine();
                n = int.Parse(temp);
                sum = sum + n;
            }
            while (n != -1);
            sum = sum + 1;
            Console.WriteLine("RESULT: {0}", sum);
        }

        static void lab3_task1()
        {
            int[] arr = new int[2];
            arr[0] = int.Parse(Console.ReadLine());
            arr[1] = int.Parse(Console.ReadLine());
            int sum = arr[0] + arr[1];
            Console.WriteLine(sum);
        }

        static void read_data()
        {

            string path = "C:\\A DISK\\C#\\testing.txt";
            if (File.Exists(path))
            {
                StreamReader filevar = new StreamReader(path);
                string record;
                while ((record = filevar.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                filevar.Close();
            }
            else
            {
                Console.WriteLine("FILE NOT EXSIST!");
            }
        }

        static void extra_task()
        {
            int[] num = {1,5,6,2,4};
            int count = num.Length;
            int sum = 0;

            string sums = sum.ToString();

            for(int i = 0; i < count / 2; i++)
            {
                string temp = num[i].ToString() + num[count-i-1].ToString();
                sum = sum + int.Parse(temp);
            }
            if(count % 2 != 0)
            {
                sum = sum + num[count/2];
            }
            Console.WriteLine("SUM IS : {0}",sum);


        }
    }
}
