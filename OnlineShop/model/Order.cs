using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Order
    {
        private int id;
        private int customer_id;
        private int ammount;

        public Order()
        {

        }

        public Order(int id,int customer_id,int amount)
        {
            this.id = id;
            this.customer_id = customer_id;
            this.ammount = amount;
        }

        public Order(string c)
        {
            string[] a = c.Split(",");

            this.id=int.Parse(a[0]);
            this.customer_id=int.Parse(a[1]);   
            this.ammount=int.Parse(a[2]);
        }

        public string describe()
        {

            string text = "";

            text+=this.id.ToString()+" ";
            text+=this.customer_id.ToString()+" ";
            text+=this.ammount.ToString()+"\n";

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

        public string save()
        {

            string text = "";

            text+=this.id.ToString()+",";
            text+=this.customer_id.ToString()+",";
            text+=this.ammount.ToString();

            return text;
        }

    }
}
