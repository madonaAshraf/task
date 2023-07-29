using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class librarian
    {

        public String? name;

        public String? address;
        public String? email;
        public double salary;
        

        public void add ( book bo ,library li )
        {
            li.addBook ( bo );
            Console.WriteLine("book", bo.Title , " has added to library");
           
        }


        public void remove (book bo, library li)
        {
            li.removeBook(bo);
            Console.WriteLine("book", bo.Title, " has removed from library");

        }

        public void manageAccount (Customer customer)
        {
            
        }



    }
 }

