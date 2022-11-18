using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Customer
    {

        private int id;
        private string email;
        private string password;
        private string name;
      
        public Customer()
        {

        }

        public Customer(int id,string email,string password,string name)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
        }

        public Customer(string c)
        {

            string[] a = c.Split(",");

            this.id=int.Parse(a[0]);
            this.email = a[1];
            this.password = a[2];
            this.name = a[3];

        }

        public string describe()
        {

            string text = "";

            text+=this.id.ToString()+" ";
            text+=this.email+" ";
            text+=this.password+" ";
            text+=this.name+"\n";

            return text;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id=id;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email=email;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password=password;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name=name;
        }

        public string save()
        {

            string text = "";
            text+=this.id.ToString()+",";
            text+=this.name+",";
            text+=this.email+",";
            text+=this.password;

            return text;
        }


    }
}
