namespace _02.Custom
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;

        private string middleName;

        private string lastName;

        private int id;

        private string address;

        private string mobilePhone;

        private string mail;

        public Customer(
            string firstName,
            string middleName,
            string lastName,
            int id,
            string address,
            string phone,
            string mail,
            CustomerType type,
            List<Payment> payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = address;
            this.MobilePhone = phone;
            this.Mail = mail;
            this.CustomerType = type;
            this.Payments = payments;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name is missing!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Middle name is missing!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name is missing!");
                }

                this.lastName = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be negative!");
                }

                this.id = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address is missing!");
                }

                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("MobilePhone is missing!");
                }

                this.mobilePhone = value;
            }
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("E-mail is missing!");
                }

                this.mail = value;
            }
        }

        public List<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Customer)
            {
                Customer customer = obj as Customer;
                return this.FirstName == customer.FirstName && this.MiddleName == customer.MiddleName
                       && this.LastName == customer.LastName && this.Id == customer.Id
                       && this.Address == customer.Address && this.MobilePhone == customer.MobilePhone
                       && this.CustomerType == customer.CustomerType;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Name: {0}", string.Concat(this.FirstName, " ", this.MiddleName, " ", this.LastName)));
            sb.AppendLine(
                string.Format(
                    "ID: {0}\nAddress: {1}\nMobile phone: {2}\nE-mail: {3}\nCustomer type: {4}",
                    this.Id,
                    this.Address,
                    this.MobilePhone,
                    this.Mail,
                    this.CustomerType));

            return sb.ToString();
        }

        public static bool operator ==(Customer a, Customer b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Customer a, Customer b)
        {
            return !a.Equals(b);
        }

        public object Clone()
        {
            return new Customer(
                        this.FirstName,
                        this.MiddleName,
                        this.LastName,
                        this.Id,
                        this.Address,
                        this.MobilePhone,
                        this.Mail,
                        this.CustomerType,
                        new List<Payment>(this.Payments));
        }

        public int CompareTo(Customer other)
        {
            if (this.FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }

            if (this.FirstName == other.FirstName && this.MiddleName.CompareTo(other.MiddleName) < 0)
            {
                return -1;
            }

            if (this.FirstName == other.FirstName && this.MiddleName == other.MiddleName && this.LastName.CompareTo(other.LastName) < 0)
            {
                return -1;
            }

            if (this.FirstName == other.FirstName && this.MiddleName == other.MiddleName && this.LastName == other.LastName && this.Id < other.Id)
            {
                return -1;
            }

            return 1;
        }
    }

    public enum CustomerType
    {
        OneTime, Regular, Golden, Diamond
    }
}
