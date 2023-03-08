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

            addressBookMain.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            
            addressBookMain.PrintList();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Press 1 for Edit Contact, \n Press 2 for delete contact ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    Console.WriteLine("Enter first name of contact to be edited");
                    string firstNameEditedContact = Console.ReadLine();
                    Console.WriteLine("Enter last name of contact to be edited");
                    string lastNameEditedContact = Console.ReadLine();
                    addressBookMain.Edit(firstNameEditedContact, lastNameEditedContact);
                    break;
                case 2:
                    Console.WriteLine("Enetr the name of contact to be deleted");
                    string firstNameDeletedContact = Console.ReadLine();
                    Console.WriteLine("Enter last name of contact to be deleted");
                    string lastNameDeletedContact = Console.ReadLine();
                    addressBookMain.DeleteContact(firstNameDeletedContact, lastNameDeletedContact);
                    break;
                default:
                    Console.WriteLine("Enetr valid choice");
                    break;
            }
            Console.ReadLine();

        }

    }
}

