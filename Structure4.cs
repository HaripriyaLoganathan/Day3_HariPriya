using System;
namespace Structure4
{
    struct Student
    {
        public string name;
       public  int dob;
        public int marks;

    }
    struct MailingList
    {
        public string name;
        public int doorno;
        public string steet;
        public string city;
        public int pincode;
    }
    struct Inventory
    {
        public int code;
        public string name;
        public int cost;
        public int totalitem;
    }
    struct Books
    {
        public string author;
        public string title;
        public int yearofpub;
        public int cost;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s;
            MailingList ml;
            Inventory i;
            Books b;
        }
    }
}
