using System;

namespace Open_Lab_10._00
{
    public class Book
    {
         string title;
         int pages;
         string category;
        string author;
        int releaseDate;

        public void t(string t)
        {
            title = t;
        }
        public void p(int p)
        {
            pages = p;
        }    
        public void c(string c)
        {
            category = c;
        }
        public void a(string a)
        {
            author = a;
        }
        public void rd(int rd)
        {
            releaseDate = rd;
        }
        public void vypis()
        {
            Console.WriteLine(title + " " + pages + " " + category + " " + author + " " + releaseDate);
           
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            
            Book LOTR = new Book();
            LOTR.t("Lord of The Rings");
            LOTR.p(42069);
            LOTR.c("Fantasy");
            LOTR.a("Tolkien");
            LOTR.rd(420);
            LOTR.vypis();
           

           
           
            

        }

    }







}
