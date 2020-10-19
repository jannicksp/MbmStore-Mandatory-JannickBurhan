using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();


        static Repository() {
            // Books
            // Book no 1
            Book myBook = new Book();
            myBook.ProductID = 1;
            myBook.Title = "A Hard Day's Write: The Stories Behind Every Beatles Song ";
            myBook.Author = "Steve Turner";
            myBook.Price = 150.00M;
            myBook.Publisher = "It Books";
            myBook.Published = 2005;
            myBook.ISBN = "978-0060844097";
            myBook.ImageUrl = "A_Hard_Days_Write.jpg";
            myBook.Category = "Book";
            Products.Add(myBook);

            // Book no 2
            Book myBook2 = new Book(2, "Georg Martin", "With a Little Help from My Friends: The Making of Sgt. Pepper", 180.00M, 1995);
            myBook2.Publisher = "Little Brown & Co";
            myBook2.ISBN = "0316547832";
            myBook2.ImageUrl = "The Making of Sgt. Pepper.jpg";
            myBook2.Category = "Book";
            Products.Add(myBook2);


            // CDs
            // CD no 1
            MusicCD myCD = new MusicCD();
            myCD.ProductID = 3;
        myCD.Title = "Abbey Road (Remastered)";
            myCD.Artist = "Beatles";
            myCD.Price = 128.00M;
            myCD.Released = 2009;
            myCD.Label = "EMI";
            myCD.ImageUrl = "abbey_road.jpg";
            myCD.Category = "MusicCD";
            Products.Add(myCD);

            // CD no 2
            MusicCD myCD2 = new MusicCD(4, "The Beatles", "Revolver (Remastered)", 128.00M, 2009);
        myCD2.Label = "EMI";
            myCD2.ImageUrl = "revolver.jpg";
            myCD2.Category = "MusicCD";
            Products.Add(myCD2);


            // Movies
            // create a new Movie objects
            Movie movie1 = new Movie(5,"Jungle Book", 160.50M, "junglebook.jpg", "Jon Favreau");
            movie1.Category = "Movie";
            Products.Add(movie1);

            Movie movie2 = new Movie(6, "Gladiator", 49.95M, "gladiator.jpg", "Ridley Scott");
            movie2.Category = "Movie";
            Products.Add(movie2);

            Movie movie3 = new Movie(7, "Forrest Gump", 154.50M, "forrest-gump.jpg", "Robert Zemeckis");
            movie3.Category = "Movie";
            Products.Add(movie3);

            Customer c1 = new Customer(1, "Tina", "Petterson", "Irisdahlsvej 32", "8200", "Århus N");
            Customer c2 = new Customer(2, "Thomas", "Larsson", "Solsikkevej 32", "8000", "Århus C");

            Invoice i1 = new Invoice(1, new DateTime(2016, 9, 12), c1);
            Invoice i2 = new Invoice(2, new DateTime(2016, 9, 24), c2);

            i1.AddOrderItem(movie3, 1);
            i1.AddOrderItem(myBook2, 1);

            i2.AddOrderItem(myBook, 1);
            i2.AddOrderItem(myCD2, 1);

            Invoices.Add(i1);
            Invoices.Add(i2);
        }

    }
}