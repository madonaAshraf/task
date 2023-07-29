using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class nonFictionBook :book
    {

        public string? genre;

        public string? subject;

        public override void cheekingOut() {

            Console.WriteLine("the title of book ", Title, "the genre of this book is ", genre, "author of this book is ", Author);

        }
        public override void returning()
        {



            Console.WriteLine("the title of book ", Title, "the genre of this book is ", genre, "author of this book is ", Author, "the subject is ", subject);



        }


    }
}
