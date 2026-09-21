using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class file
    {
        private string filename;
        private string filetype;
        private int filesize;
        private int filedate;
        private bool open;
        private string filecontent;

        public file(string filename, string filetype, int filesize, int filedate, bool open, string filecontent)
        {
            this.filename = filename;
            this.filetype = filetype;
            this.filesize = filesize;
            this.filedate = filedate;
            this.open = open;
            this.filecontent = filecontent;
        }


        public string Getname()
        {
            return filename;
        }
        public string gettype()
        {
            return filetype;
        }
        public int Getsize()
        {
            return filesize;
        }
        public int Getdate()
        {
            return filedate;
        }
        public bool Getopen()
        {
            return open;
        }
        public string Getcontent()
        {
            return filecontent;
        }


        public string ReturnAll()
        {
            return "The name is " + this.filename + ", type: " + this.filetype + ", size: " + this.filesize + ", date:" + this.filedate + ", open?" + this.open + ", content: " + this.filecontent;
        }


        public void setname(string filename)
        {
            this.filename = filename;
        }

        public void settype(string filetype)
        {
            this.filetype = filetype;
        }

        public void setsize(int filesize)
        {
            this.filesize = filesize;
        }

        public void setdate(int filedate)
        {
            this.filedate = filedate;
        }

        public void setopen(bool open)
        {
            this.open = open;
        }

        public void setcontent(string filecontent)
        {
            this.filecontent = filecontent;
        }



        public bool sametype(string filetype)
        {
            if (this.filetype == filetype)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        class Program
        {
            static void Main(string[] args)
            {
                string name = null;
                string filetype = " ";
                int filesize = 0;
                int filedate = 0;
                bool open = false;
                string content = null;

                Console.WriteLine("Enter the file name, type, size, date, open, content");

                name = Console.ReadLine();
                filetype = Console.ReadLine();
                filesize = int.Parse(Console.ReadLine());
                filedate = int.Parse(Console.ReadLine());
                open = bool.Parse(Console.ReadLine());
                content = Console.ReadLine();
                file f1 = new file(name, filetype, filesize, filedate, open, content);

                Console.WriteLine("Enter the file name, type, size, date, open, content");
                name = Console.ReadLine();
                filetype = Console.ReadLine();
                filesize = int.Parse(Console.ReadLine());
                filedate = int.Parse(Console.ReadLine());
                open = bool.Parse(Console.ReadLine());
                content = Console.ReadLine(); ;
                file f2 = new file(name, filetype, filesize, filedate, open, content);

                if (f1.sametype(f2.gettype()) == true)
                {
                    f1.setopen(true);
                    f2.setopen(true);
                    
                    Console.WriteLine("What is the new file name? ");
                    name = Console.ReadLine();
                    file newf = new file(name, f1.gettype(), f1.Getsize() + f2.Getsize(),f1.Getdate(), true, f1.Getcontent() + f2.Getcontent());

                    Console.WriteLine(newf.ReturnAll());
                }
                else
                {
                    Console.WriteLine("Not both are the same type");
                }

                f1.setopen(false);
                f2.setopen(false);

            }
        }
    }
}
