using System;


namespace PersonCustomerClass
{
    class Person
    {
        //Declare fields
        private string _name;
        private string _address;
        private string _cityState;
        private int _zip;
        private string _phone;


        //Default constructor 
        public Person()
        {
            _name = "";
            _address = "";
            _cityState = "";
            _zip = 0;
            _phone = "";
        }
        public Person(string name, string address, string cityState, Int32 zip, string phone)
        {
            _name = name;
            _address = address;
            _cityState = cityState;
            _zip = zip;
            _phone = phone;
        }


        //Properties with getters and setters
        public string Name { get; set; }
        public string Address { get; set; }
        public string CityState { get; set; }
        public Int32 Zip { get; set; }
        public string Phone { get; set; }

    }
}
