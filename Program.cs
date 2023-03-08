
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
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.AddContact("sagar", "katahre", "yuuu", "pune", "MH", 441877, 01234456789, "abc@gmail.com");
            addressBookMain.PrintList();
            Console.ReadLine();
        }
    }
}
