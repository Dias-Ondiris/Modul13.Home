using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul13.Home
{
    public class Client
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public ServiceType ServiceType { get; set; }
        public string GetServiceType { get
            {
                if (this.ServiceType == ServiceType.Loan) return "Кредитование";
                else if (this.ServiceType == ServiceType.Deposit) return "Открытие вклада";
                else if (this.ServiceType == ServiceType.Consultation) return "Консультация";
                else return "Не известно";
            } }

        public Client(int id, string name, ServiceType serviceType)
        {
            Id = id;
            Name = name;
            ServiceType = serviceType;
        }

        public override string ToString()
        {
            return $"Клиент {Name} (ID: {Id}), Услуга: {GetServiceType}";
        }
    }

    public enum ServiceType
    {
        Loan,
        Deposit,
        Consultation
    }



}
