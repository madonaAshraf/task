// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;
namespace ConsoleApp7;


/*int row = 5;
for (int i = 1; i <= row; i++)
{

    for (int j = 0; j <= row - i; j++) Console.Write(" ");
    for (int j = 0; j < i * 2 - 1; j++) Console.Write("*");
    Console.WriteLine();

}

for (int i = 1; i <= row; i++)
{

    for (int j = 0; j < row-3; j++) Console.Write(" ");
    for (int j = 0; j < row+2; j++) Console.Write("*");
    Console.WriteLine();

}
for (int i = row; i <= row+1; i++)
{

    for (int j = 0; j <= row - i; j++) Console.Write(" ");
    for (int j = 0; j < i * 2 - 1; j++) Console.Write("*");
    Console.WriteLine();

}
*/

/*
BigInteger x = 1;
Console.WriteLine(x);
*/


class program
{
    static void Main(string[] args) { 
       
        FictionBook fi = new FictionBook();
        fi.Author = "tony";
        fi.Title = "Test";
        fi.Isbn = 34645531;
        FictionBook di = new FictionBook();
        di.Author = "john";
        di.Title = "wwwwww";
        di.Isbn = 29374294;

        nonFictionBook nonFictionBook = new nonFictionBook();
        nonFictionBook.Author = "william";
        nonFictionBook.Title = "Text";
        nonFictionBook.Isbn = 13769738;
        Customer customer = new Customer();
        customer.Name = "madona";
        customer.Address = " 105 elmaks";
        customer.Email = "madonna234@gamil.com ";
        customer.checkout(fi);
        customer.returnbook(nonFictionBook);

        
     library li = new library();
        li.searchbook("tony");
        li.addBook(fi);
        li.addBook(nonFictionBook);
        li.removeBook(di);
        li.searchbook("john");


    }

 
}


