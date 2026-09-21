using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    class PhoneBook
    {
        private Contact[] Contacts;
        private const int MaxContacts = 50;
        private int LastPos;

        public PhoneBook()
        {
            this.Contacts = new Contact[MaxContacts];
            this.LastPos = 0;
        }

        public Contact[] GetContacts()
        {
            return this.Contacts;
        }
        public void SetContacts(Contact[] Contacts)
        {
            this.Contacts = Contacts;
        }

        public void AddContact(string name, string phone)
        {
            bool same = false;
            int changeindex = -1;
            for (int i = 0; i < LastPos; i++)
            {
                if (this.Contacts[i].GetName() == name)
                {
                    same = true;
                    changeindex = i;
                }
            }
            if (same == true)
            {
                this.Contacts[changeindex].SetNumber(phone);
            }
            else
            {
                Contact temp = new Contact(name, phone);
                this.Contacts[LastPos] = temp;
                LastPos++;
            }
            
        }

        public void DelContact(string name)
        {
            int index = -1;
            for (int i = 0; i < LastPos; i++)
            {
                if (this.Contacts[i].GetName() == name)
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                for (int i = index; i < LastPos-1; i++)
                {
                    Contacts[i] = Contacts[i + 1];
                }
                Contacts[LastPos - 1] = null;
                LastPos--;
            }
        }

        public string GetPhone(string name)
        {
            int pointer = -1;
            for (int i = 0; i < LastPos; i++)
            {
                if (name == this.Contacts[i].GetName())
                {
                    pointer = i;
                }
            }
            if (pointer == -1)
                return null;
            else
                return this.Contacts[pointer].GetNumber();
        }

        public string[] GetAllContactsNames()
        {
            string[] ContactNames = new string[LastPos];
            for (int i = 0; i < LastPos; i++)
            {
                ContactNames[i] = this.Contacts[i].GetName();
            }

            return ContactNames;
        }

        public override string ToString()
        {
            string[] alphabat = new string[LastPos];

            string temp = "hello";
            for (int i = 0; i < LastPos; i++)
            {
                alphabat[i] = this.Contacts[i].GetName();
            }
            while (temp != null)
            {
                temp = null;
                for (int i = 0; i < alphabat.Length - 1; i++)
                {
                    if (alphabat[i].CompareTo(alphabat[i + 1]) < 0)
                    {

                        temp = alphabat[i];
                        alphabat[i] = alphabat[i + 1];
                        alphabat[i + 1] = temp;
                    }
                    else if (alphabat[i][0].Equals(alphabat[i + 1][0]) == true)
                    {
                            if (alphabat[i].CompareTo(alphabat[i + 1]) < 0)
                            {
                                temp = alphabat[i];
                                alphabat[i] = alphabat[i + 1];
                                alphabat[i + 1] = temp;
                            }
                        
                    }
                }
            }
            
            for (int i = 0; i < alphabat.Length; i++)
			{
			    alphabat[i] = alphabat[i] + " " + this.GetPhone(alphabat[i]);
			}
            string print = alphabat[0];
            for (int i = 1; i < alphabat.Length; i++)
            {
                print = print + "\n" + alphabat[i];
            }
            return (print);

        }
    }
}
