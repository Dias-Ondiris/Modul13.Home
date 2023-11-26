using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul13.Home
{
    public class BankQueue
    {
        private Queue<Client> clients = new Queue<Client>();

        public void AddClient(Client client)
        {
            clients.Enqueue(client);
            DisplayQueue();
        }

        public void ServeClient()
        {
            if (clients.Count > 0)
            {
                Client client = clients.Dequeue();
                Console.WriteLine($"Обслуживается: {client}");
                DisplayQueue();
            }
            else
            {
                Console.WriteLine("Очередь пуста.");
            }
        }

        private void DisplayQueue()
        {
            Console.WriteLine("Текущая очередь:");
            foreach (Client client in clients)
            {
                Console.WriteLine(client);
            }
        }
    }


}
