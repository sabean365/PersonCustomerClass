using System;


namespace PersonCustomerClass
{
    class Customer : Person
    {
        //Extra fields
        private Int32 _custNum;
        private bool _mailingList;

        //Default constructor
        public Customer()
        {
            _custNum = 0;
            _mailingList = false;
        }

        //Parameterized constructor
        public Customer(string name, string address, string cityState, Int32 zip, string phone, Int32 custNum, bool mailingList)
            : base(name, address, cityState, zip, phone)
        {
            _custNum = custNum;
            _mailingList = mailingList;
        }

        //Getters and setters for two new properties
        public Int32 CustNum { get; set; }
        public bool MailingList { get; set; }
    }
}
