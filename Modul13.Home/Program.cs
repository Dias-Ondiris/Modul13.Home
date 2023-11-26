using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul13.Home
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankQueue = new BankQueue();
            bool exit = false;
            int clientId = 1;
            while (!exit)
            {
                Console.WriteLine("\n1. Встать в очередь\n2. Обслужить следующего клиента\n3. Выход");
                Console.Write("Выберите опцию: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        ServiceType serviceType = ChooseService();
                        bankQueue.AddClient(new Client(clientId++, name, serviceType));
                        break;
                    case "2":
                        bankQueue.ServeClient();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверная опция.");
                        break;
                }
            }
        }
        private static ServiceType ChooseService()
        {
            Console.WriteLine("Выберите услугу:\n1. Кредитование\n2. Открытие вклада\n3. Консультация");
            Console.Write("Ваш выбор: ");
            string serviceChoice = Console.ReadLine();

            switch (serviceChoice)
            {
                case "1":
                    return ServiceType.Loan;
                case "2":
                    return ServiceType.Deposit;
                default:
                    return ServiceType.Consultation;
            }
        }
    }

}
