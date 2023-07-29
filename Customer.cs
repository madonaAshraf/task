using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Customer
    {

        private String? name;

        private String? address;
        private String? email;
        List<book>? ListOfBooksCheckedOut = new List<book>();

       public string Name { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }

        public Customer() { 
        
        ListOfBooksCheckedOut=new List<book>();
        
        
        }
        public void checkout (book bo) {

            ListOfBooksCheckedOut.Add(bo);

            bo.cheekingOut();
        
        }

        public void returnbook (book bo)
        {
            ListOfBooksCheckedOut.Remove(bo);
            bo.returning();
        }


    }
}
