using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
  abstract  public class book {

        
        private String? title;

        private String? author;

        private double isbn;

        private double numberOfPages ;


        public string Title
        {
            get { return title; }   
            set { title = value; } 
        }


        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public double NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

    public abstract void cheekingOut();
     public abstract void returning ();






  }



}

