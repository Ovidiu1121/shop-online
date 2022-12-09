using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Order
    {
        private int id;
        private int customer_id;
        private int ammount;
        private bool finalizat;


        public Order()
        {

        }

        public Order(int id,int customer_id,int amount,bool finalizat)
        {
            this.id = id;
            this.customer_id = customer_id;
            this.ammount = amount;
            this.finalizat = finalizat;
        }

        public Order(string c)
        {
            string[] a = c.Split(",");

            this.id=int.Parse(a[0]);
            this.customer_id=int.Parse(a[1]);   
            this.ammount=int.Parse(a[2]);
            this.finalizat=bool.Parse(a[3]);
        }

        public string describe()
        {

            string text = "";

            text+=this.id.ToString()+" ";
            text+=this.customer_id.ToString()+" ";
            text+=this.ammount.ToString()+" ";
            text+=this.finalizat.ToString()+"\n";

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

        public int getCustomerId()
        {
            return this.customer_id;
        }

        public void setCustomerId(int customer_id)
        {
            this.customer_id=customer_id;
        }

        public int getAmmount()
        {
            return this.ammount;
        }

        public void setAmmount(int ammount)
        {
            this.ammount=ammount;
        }

        public bool getFinalizare()
        {
            return this.finalizat;
        }

        public void setFinalizare(bool finalizat)
        {
            this.finalizat = finalizat;
        }

        public string save()
        {

            string text = "";

            text+=this.id.ToString()+",";
            text+=this.customer_id.ToString()+",";
            text+=this.ammount.ToString()+",";
            text+=this.finalizat.ToString();

            return text;
        }

    }
}
