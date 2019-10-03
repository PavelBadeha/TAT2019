using System.Collections.Generic;

namespace CW_2
{
    /// <summary>
    /// Class of management inheritor of Department.
    /// </summary>
    class Management :Department
    {
        public Head Head { get; }= new Head();

        public List<Accountant> Accountants { get; } = new List<Accountant>();

        #region Constructors

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public Management() : base() { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="city">Name of the city.</param>
        /// <param name="street">Name of the street.</param>
        /// <param name="houseNumber">House number.</param>
        public Management(string name, string city, string street, string houseNumber) : base(name, city, street, houseNumber)
        { }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">Name of the faculty.</param>
        /// <param name="address">Address.</param>
        public Management(string name, Address address) : base(name, address) { }

        public Management(string name, Address address, Head head) : base(name, address)
        {
            Head = head;
        }

        public Management(string name, Address address, List<Accountant> accountants) : base(name, address)
        {
            Accountants.AddRange(accountants);
        }
        #endregion
        public override string ToString()
        {
            return "Management\n" + base.ToString() + "\n" + Head.ToString() + "\nQuantity of accountants:" + Accountants.Count;
        }

    public void AddAccountant(Accountant accountant)
        {
            bool check = true;
            foreach (var tempAccountant in Accountants)
            {
                if (tempAccountant.Equals(accountant))
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Accountants.Add(accountant);
            }
        }
    }
}
