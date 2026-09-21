using System;
using System.Collections.Generic;
using System.Text;
/**
 * תוכנית בדיקה לספר הטלפונים מדף עבודה 1 פרק 8
 *
 * @author צוות מדעי המחשב, המרכז להוראת המדעים, האוניברסיטה העברית, ירושלים
 * @version 23/10/2006
 */
namespace ConsoleApplication1
{
    class Program1
    {
        public static int ShowMenu()
        {
            int op;

            do
            {
                Console.WriteLine();
                Console.WriteLine("0. Update contact phone");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Delete exist contact");
                Console.WriteLine("3. Search contact");
                Console.WriteLine("4. Show all contacts");
                Console.WriteLine("5. Number of conatcts");
                Console.WriteLine("6. Exit");
                Console.WriteLine(">> Enter option [0-6]: ");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (op < 0 || op > 6);


            return (op);
        }

        static void Main(String[] args)
        {
           // ShowMenu();
            // יצירת ספר טלפונים
            PhoneBook book1 = new PhoneBook();

            // הוספת אנשי קשר לספר הטלפונים
            Contact c1 = new Contact("Contact 01", "000-0001");
            book1.AddFirst(c1);
            Contact c2 = new Contact("Contact 02", "000-0002");
            book1.AddFirst(c2);
            Contact c3 = new Contact("Contact 03", "000-0003");
            book1.AddFirst(c3);
            Contact c4 = new Contact("Contact 04", "000-0004");
            book1.AddFirst(c4);
            Contact c5 = new Contact("Contact 05", "000-0005");
            book1.AddFirst(c5);
            Contact c6 = new Contact("Contact 06", "000-0006");
            book1.AddFirst(c6);

            // הדפסת ספר הטלפונים
            Console.Write("book1:\n" + book1);


           


            //// יצירת ספר טלפונים
            //PhoneBook book3 = new PhoneBook();

            //// העתקת על אנשי הקשר מהספר טלפונים הראשון
            //String[] names = book1.GetAllContactsNames();
            //for (int i = 0; i < names.Length; i++)
            //    book3.AddContact(names[i], book1.GetPhone(names[i]));

            //names = book2.GetAllContactsNames();
            //for (int i = 0; i < names.Length; i++)
            //    if (book3.GetPhone(names[i]) == null)
            //        book3.AddContact(names[i], book2.GetPhone(names[i]));

            //// הדפסת ספר הטלפונים
            //Console.Write("\n\nbook3:\n" + book3.ToString());
            //Console.ReadLine();
        }
    }
}
