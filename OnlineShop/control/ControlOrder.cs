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

            while ((line=reader.ReadLine())!=null&&line.Length>2)
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

            if (lista.Count==0)
            {
                return text;
            }

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

        public int generateNextId()
        {
            if (lista.Count==0)
            {
                return 1;
            }
            else
            {
                return lista[lista.Count-1].getId()+1;
            }
        }

        public bool isOrderById(int id)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getId().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        public void deleteAllFalse()
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getFinalizare().Equals(false))
                {
                    lista.RemoveAt(i);
                    i--;
                }
            }

        }


    }
}
