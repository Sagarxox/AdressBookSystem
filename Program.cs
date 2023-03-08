﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address Book System Problem");

            Console.WriteLine("Enter the First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone Number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email");
            string email = Console.ReadLine();

            AddressBookMain addressBookMain = new AddressBookMain();

            AddressBookMain.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            

            addressBookMain.PrintList();
            Console.ReadLine();
        }

    }
}

