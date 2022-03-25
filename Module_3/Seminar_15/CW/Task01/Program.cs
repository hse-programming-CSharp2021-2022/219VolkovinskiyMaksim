﻿
namespace Task01
{
    class BankAccount
    {
        private object thisLock = new object();
        volatile int accountAmount;
        private bool l = false;
        Random r = new Random();
        public BankAccount(int sum)
        {
            accountAmount = sum;
        }
        int Buy(int sum)
        {
            l = false;
            if (accountAmount == 0)
                throw new InvalidOperationException($"Нулевой баланс...");
            // условие никогда не выполнится, пока вы не закомментируете lock.  
            if (accountAmount < 0)
                throw new InvalidOperationException($"Отрицательный баланс");
            Monitor.Enter(thisLock, ref l);
                if (accountAmount >= sum)
                {
                    Console.WriteLine($"Состояние счета: {accountAmount}");
                    Console.WriteLine($" Покупка на сумму: {sum}");
                    accountAmount = accountAmount - sum;
                    Console.WriteLine($" Счет после пок.: {accountAmount}");
                    if (l)
                        Monitor.Exit(thisLock);
                    return sum;
                }
                else
                {
                    if (l)
                        Monitor.Exit(thisLock);
                    return 0; // не хватает денег - отказываем в покупке
                }
        }
        public void DoTransactions()
        {
            try
            {
                while (true)
                {
                    Buy(r.Next(1, 50));
                    Thread.Sleep(r.Next(1, 10));
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Обработано исключение: {ex.Message}. Поток завершает работу...");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Thread[] threads = new Thread[10];
            BankAccount dep = new BankAccount(1000);
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(dep.DoTransactions);
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }
        }
    }
}