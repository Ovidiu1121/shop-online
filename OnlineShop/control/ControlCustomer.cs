using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class ControlCustomer
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

            while ((line=reader.ReadLine())!=null)
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


    }
}
