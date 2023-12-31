﻿using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


    public abstract void colorSet();
}

//Write MyBook class

class MyBook : Book
{
    int price;
   public MyBook(string t, string a,int price) : base(t, a)
    {
        this.price = price;

    }

    public override void colorSet()
    {
        Console.WriteLine("Yellow");
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nPrice: {price}");
    }

    //public   void colorSet()
    //{
    //    Console.WriteLine("Yellow");
    //}


}


class AbsClassSolution
{
    public void call()
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
        new_novel.colorSet();
    }
}