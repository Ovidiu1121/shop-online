using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class ControlCustomer
    {
        private List<Customer> lista=new List<Customer>();

        public string path = Application.StartupPath+@"/data_customer/customers.txt";

        public ControlCustomer()
        {

            this.load();

        }

        public void load()
        {

            StreamReader reader = new StreamReader(path);

            string line = "";

            while ((line=reader.ReadLine())!=null&&line.Length>2)
            {
                Customer c = new Customer(line);
                lista.Add(c);
            }
            reader.Close();

        }

        public string afisare()
        {

            string text = "";

            for(int i=0;i<lista.Count;i++)
            {
                text+=this.lista[i].describe();
            }
            return text;
        }

        public string toSave()
        {

            string text = "";
            int i = 0;

            for(i = 0; i<lista.Count-1; i++)
            {
                text+=lista[i].save()+"\n";
            }
            text+=lista[i].save();

            return text;
        }

        public void salvareFisier()
        {

            StreamWriter writer = new StreamWriter(path);

            writer.WriteLine(this.toSave());

            writer.Close();
        }

        public void add(Customer x)
        {

            lista.Add(x);

        }

        public void delete(int id)
        {

            for(int i=0;i<=lista.Count-1;i++)
            {
                if (lista[i].getId().Equals(id))
                {
                    lista.RemoveAt(i);
                    i--;
                }
            }

        }

        public Customer returnCustomerById(int id)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getId().Equals(id))
                {
                    return lista[i];
                }
            }
            return null;
        }

        public void update(int id, Customer newCustomer)
        {

            Customer old=returnCustomerById(id);

            old.setEmail(newCustomer.getEmail());
            old.setFirstName(newCustomer.getFirstName());
            old.setPassword(newCustomer.getPassword());

        }

        public bool isEmail(string email)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getEmail().Equals(email)==true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isPhoneNumber(int phoneNumber)
        {

            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getPhoneNumber().Equals(phoneNumber)==true)
                {
                    return true;
                }
            }
            return false;

        }

        public int getLastId()
        {
            return lista[lista.Count-1].getId();
        }

        public Customer getCustomerByEmail(string email)
        {

            for(int i=0; i<lista.Count; i++)
            {
                if(lista[i].getEmail().Equals(email) == true)
                {
                    return lista[i];
                }
            }
            return null;
        }

        public bool isParolaByEmail(string email,string parola)
        {

            Customer c=getCustomerByEmail(email);

            if (c.getPassword().Equals(parola)==true)
            {
                return true;
            }
            return false;
        }



    }
}
