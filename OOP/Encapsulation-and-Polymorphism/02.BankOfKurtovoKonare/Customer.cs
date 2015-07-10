using System;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    public abstract class Customer : ICustomer
    {
        private string name;

        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The customer name is missing!");
                }

                this.name = value;
            }
        }
    }
}
