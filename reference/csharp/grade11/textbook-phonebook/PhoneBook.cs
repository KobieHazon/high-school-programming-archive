using System;
using System.Text;

namespace ConsoleApplication1
{
    /**
     * מחלקה המגדירה ספר טלפונים 
     *
     * @author צוות מדעי המחשב, המרכז להוראת המדעים, האוניברסיטה העברית, ירושלים
     * @version 2/8/2007
     */
     public class PhoneBook
    {
        private Node<Contact> phoneBook;
        private int numOfContacts;

        public PhoneBook()
        {
            this.phoneBook = null;
            this.numOfContacts = 0;
        }
        public Node<Contact> IsExist(Contact con)
        {
            Node<Contact> pos = this.phoneBook;
            while (pos != null)
            {
                if( pos.GetInfo().GetName().Equals(con.GetName()))// שינוי
                    return pos;
                pos = pos.GetNext();
            }
            return pos;


        }
        public void AddFirst(Contact con)
        {
            
            Node<Contact> pos =IsExist(con);

            if (pos == null)
            {
                this.phoneBook = new Node<Contact>(new Contact(con), this.phoneBook);
                this.numOfContacts++;
            }
            else
            {
                Contact c = pos.GetInfo();// נתון לשינוי
                c.SetPhone(con.GetPhone());// שינוי
            }
        }
        public void Addlast(Contact con)
        {

            Node<Contact> pos = IsExist(con);
            Node<Contact> pos1 = this.phoneBook;
            if (pos == null)
            {
                if (this.phoneBook == null)
                    this.phoneBook = new Node<Contact>(new Contact(con));
                else
                {

                    while (pos1.GetNext() != null)
                        pos1 = pos1.GetNext();

                    pos1.SetNext(new Node<Contact>(new Contact(con)));
                }
                this.numOfContacts++;
            }
            else
            {
                Contact c = pos.GetInfo();// נתון לשינוי
                c.SetPhone(con.GetPhone());// שינוי
            }
        }
        public void Remove1(Contact con)
        {
          
            Node<Contact> pos = IsExist(con);
            
            if (pos != null)
            {
                Node<Contact> pos1 = this.phoneBook;
                if (this.phoneBook == pos)
                {
                    this.phoneBook = this.phoneBook.GetNext(); ;
                    
                }
                else
                {
                    while (pos1.GetNext() != pos)
                    {
                        pos1 = pos1.GetNext();
                    }
                    pos1.SetNext(pos.GetNext());
                }
                this.numOfContacts--;
            }

        }


        public String GetPhone(String name) //מחזיר את הטלפון של איש   
        {
            Node<Contact> pos = this.phoneBook;

            while (pos != null)
            {
                if (pos.GetInfo().GetName().Equals(name))
                    return (pos.GetInfo().GetPhone());
                pos = pos.GetNext();
            }

            return (null);
        }
       

       

        public void SetPhone(String name, String phone) // 
        {
            Node<Contact> pos = this.phoneBook;

            while (name.CompareTo(pos.GetInfo().GetName()) != 0)
                pos = pos.GetNext();

            pos.GetInfo().SetPhone(phone);
        }

        public String[] GetAllContactsNames()
        {
            String[] names = new String[this.numOfContacts];
            Node<Contact> pos = this.phoneBook;

            for (int i = 0; i < this.numOfContacts; i++)
            {
                names[i] = pos.GetInfo().GetName();
                pos = pos.GetNext();
            }

            return (names);
        }


        public override String ToString()
        {
            String str = "";
            Node<Contact> pos = this.phoneBook;

            while (pos != null)
            {
                //str = str + String.Format("%-20s %10s\n", pos.GetInfo());
                str = str +  pos.GetInfo()+"\n";
                pos = pos.GetNext();
            }

            return (str);
        }
    }
}
