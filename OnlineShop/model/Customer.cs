using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Customer
    {

        private int id;
        private string email;
        private string password;
        private string firstName;
        private string lastName;
        private int phoneNumber;

        public Customer()
        {

        }

        public Customer(int id,string email,string password,string firstName, string lastName, int phoneNumber)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public Customer(string c)
        {

            string[] a = c.Split(",");

            this.id=int.Parse(a[0]);
            this.email = a[1];
            this.password = a[2];
            this.firstName = a[3];
            this.lastName = a[4];
            this.phoneNumber = int.Parse(a[5]);
        }

        public string describe()
        {

            string text = "";

            text+=this.id.ToString()+" ";
            text+=this.email+" ";
            text+=this.password+" ";
            text+=this.firstName+" ";
            text+=this.lastName+" ";
            text+=this.phoneNumber.ToString()+"\n";

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

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName=firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName=lastName;
        }

        public int getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void setPhoneNumber(int phoneNumber)
        {
            this.phoneNumber=phoneNumber;
        }

        public string save()
        {

            string text = "";
            text+=this.id.ToString()+",";
            text+=this.email+",";
            text+=this.password+",";
            text+=this.firstName+",";
            text+=this.lastName+",";
            text+=this.phoneNumber.ToString();

            return text;
        }


    }
}
