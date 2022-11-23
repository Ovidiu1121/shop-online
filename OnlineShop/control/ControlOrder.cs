using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class ControlOrder
    {
        private List<Order> lista=new List<Order>();
        public string path = Application.StartupPath+@"/data_order/orders.txt";

        public ControlOrder()
        {
            this.load();
        }

        public void load()
        {

            StreamReader reader = new StreamReader(path);

            string line = "";

            while ((line=reader.ReadLine())!=null)
            {
                Order o = new Order(line);
                lista.Add(o);
            }
            reader.Close();

        }

        public string afisare()
        {

            string text = "";

            for (int i = 0; i<lista.Count; i++)
            {
                text+=this.lista[i].describe();
            }
            return text;
        }

        public string toSave()
        {

            string text = "";
            int i = 0;

            for (i = 0; i<lista.Count-1; i++)
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

        public void add(Order x)
        {
            lista.Add(x);
        }

        public void delete(int id)
        {

            for (int i = 0; i<=lista.Count-1; i++)
            {
                if (lista[i].getId().Equals(id))
                {
                    lista.RemoveAt(i);
                    i--;
                }
            }

        }

        public Order returnOrderById(int id)
        {

            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getId().Equals(id))
                {
                    return lista[i];
                }
            }
            return null;
        }

        public void update(int id, Order newOrder)
        {

            Order old = returnOrderById(id);

            old.setCustomerId(newOrder.getCustomerId());
            old.setAmmount(newOrder.getAmmount());

        }


    }
}
