using System;
using System.Text;

namespace ConsoleApplication1
{
   public class Contact
    {
        private String name;
        private String phone;

        public Contact(String name, String phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public Contact(Contact co)
        {
            this.name = co.name;
            this.phone = co.phone;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetPhone(String phone)
        {
            this.phone = phone;
        }

        public String GetName()
        {
            return (this.name);
        }

        public String GetPhone()
        {
            return (this.phone);
        }

        public override String ToString()
        {
            return (this.name + ":" + this.phone);
        }
    }
}
