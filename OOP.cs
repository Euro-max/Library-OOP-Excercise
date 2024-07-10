// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
class Book{
    public string name{get;set;}
    public double price{get;set;}
}
namespace WOW{
public class Shopping
{
    static void Main(string[] args){
bool isShopping=true;
List<Book> Books=new List<Book>();
while(isShopping){
    Book purchasedBook= new Book();
Console.WriteLine("Welcome to the book store. What book do you want to buy?");
purchasedBook.name=Console.ReadLine();
Console.WriteLine("Your Price");

purchasedBook.price=Convert.ToDouble(Console.ReadLine());
Books.Add(purchasedBook);
Console.WriteLine("Do you want to remove a book?");
    string response=Console.ReadLine();
    if(response=="yes"){
        Console.WriteLine("Which book do you want to remove?");
        var bookrem=Console.ReadLine();
        Book actualBooks=new Book();
        foreach(var toBeremoved in Books){
            if(toBeremoved.name.Contains(bookrem)){
                actualBooks=toBeremoved;
            }
            else{
                Console.WriteLine("No book with that name, sir");
            }
            
        }
        Books.Remove(actualBooks);
    }


Console.WriteLine("Do you want to continue? Type Y for yes and N for no");
string choice=Console.ReadLine();
if(choice=="no"){
    var total=0.00;
    
    isShopping=false;
    Console.WriteLine("Your books are");
    foreach(var Book in Books){
        Console.WriteLine(Book.name);
        total+=Book.price;
    }
    Console.WriteLine($"Your total is {total}");
}
    
}
}
}
}
