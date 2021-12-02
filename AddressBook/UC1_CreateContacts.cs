using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UC1_CreateContacts
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phonenumber;
        public string email;

        public  void DisplayContacts()
        {
            UC1_CreateContacts cc = new UC1_CreateContacts();

            Console.Write("Enter First Name: ");
            cc.firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            cc.lastname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            cc.address = Console.ReadLine();

            Console.Write("Enter City name: ");
            cc.city = Console.ReadLine();

            Console.Write("Enter State name: ");
            cc.state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            cc.zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            cc.phonenumber = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            cc.email = Console.ReadLine();


            Console.WriteLine("\nDetails of the Person are given below: ");
            Console.WriteLine("\nFirst Name: " + cc.firstname);
            Console.WriteLine("\nLast Name: " + cc.lastname);
            Console.WriteLine("\nAddress: " + cc.address);
            Console.WriteLine("\nCity: " + cc.city);
            Console.WriteLine("\nState: " + cc.state);
            Console.WriteLine("\nZip Code: " + cc.zipcode);
            Console.WriteLine("\nPhone Number: " + cc.phonenumber);
            Console.WriteLine("\nEmail ID: " + cc.email);
            Console.WriteLine("-------------------------------------------");

        }
    }
}
