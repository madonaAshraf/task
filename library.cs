using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class library
    {

       public List<book> listofBook = new List<book>();

       public List<Customer> listofcustomer = new List<Customer>();

       public List<librarian> listoflibrarian = new List<librarian>();

       


        public void addBook(book bo)
        {
            listofBook.Add(bo);
        }

        public void removeBook(book bo)
        {
            listofBook.Remove(bo);

        }


       public List<book> searchbook ( string name) {
        List<book> searchresult = new List<book>();
            foreach (var book in listofBook)
            {
                if (book.Title.ToLower().Contains(name.ToLower()))
                {
                    searchresult.Add(book);
                }
            }
        }
     



        public void addCustomer (Customer cus) {
        
        listofcustomer.Add(cus);
        
        
        }

        public void removeCustomer(Customer cus)
        {

            listofcustomer.Remove(cus);
        }


    }
 }
