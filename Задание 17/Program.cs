using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Введите номер аккаунта:");
                int accnum1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите номер аккаунта прописью:");
                string accnum2 = Console.ReadLine();
                Console.Write("Введите баланс:");
                double balance1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите имя:");
                string fname1 = Console.ReadLine();
                Account<int> account1 = new Account<int>(accnum1, balance1, fname1);
                Account<string> account2 = new Account<string>(accnum2, balance1, fname1);
                account1.Print();
                Console.WriteLine();
                account2.Print();
                Console.ReadKey();
            }
        }
        class Account<T>
        {
            private T AccNumb;
            private double Balance;
            private string FullName;
            public Account(T accnumb, double balance, string fullname)
            {
                AccNumb = accnumb;
                Balance = balance;
                FullName = fullname;
            }
            public void Print()
            {
                Console.Write("Номер аккаунта:{0} ", AccNumb);
                Console.Write("Баланс:{0} ", Balance);
                Console.Write("Имя:{0} ", FullName);
            }
        }
    }