using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class OrderDetails
    {

        private int id;
        private int order_id;
        private int product_id;
        private int price;
        private int quantity;

        public OrderDetails()
        {

        }

        public OrderDetails(int id, int order_id, int product_id,int price, int quantity)
        {
            this.id = id;
            this.order_id = order_id;
            this.product_id = product_id;
            this.price = price;
            this.quantity = quantity;
        }

        public OrderDetails(string c)
        {
            string[] a = c.Split(",");

            this.id=int.Parse(a[0]);
            this.order_id=int.Parse(a[1]);
            this.product_id=int.Parse(a[2]);
            this.price=int.Parse(a[3]); 
            this.quantity=int.Parse(a[4]);
        }

        public string describe()
        {

            string text = "";

            text+=this.id.ToString()+" ";
            text+=this.order_id.ToString()+" ";
            text+=this.product_id.ToString()+" ";
            text+=this.price.ToString()+" ";
            text+=this.quantity.ToString()+"\n";

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

        public int getOrderId()
        {
            return this.order_id;
        }

        public void setOrderId(int order_id)
        {
            this.order_id=order_id;
        }

        public int getProdcutId()
        {
            return this.product_id;
        }

        public void setProductId(int product_id)
        {
            this.product_id=product_id;
        }

        public int getPrice()
        {
            return this.price;
        }

        public void setPrice(int price)
        {
            this.price=price;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity=quantity;
        }

        public string save()
        {

            string text = "";

            text+=this.id.ToString()+",";
            text+=this.order_id.ToString()+",";
            text+=this.product_id.ToString()+",";
            text+=this.price.ToString()+",";
            text+=this.quantity.ToString();

            return text;
        }

    }
}
