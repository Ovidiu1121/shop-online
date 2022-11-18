using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Product
    {
        private int id;
        private string name;
        private string image;
        private int price;
        private int stock;

        public Product()
        {

        }

        public Product(int id, string name, string image, int price, int stock)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.price = price;
            this.stock = stock;

        }

        public Product(string c)
        {
            string[] a = c.Split(",");

            this.id = int.Parse(a[0]);
            this.name = a[1];
            this.image = a[2];
            this.price = int.Parse(a[3]);
            this.stock = int.Parse(a[4]);

        }

        public string describe()
        {

            string text = "";

            text+=this.id.ToString()+" ";
            text+=this.name+" ";
            text+=this.image+" ";
            text+=this.price.ToString()+" ";
            text+=this.stock.ToString()+"\n";

            return text;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId()
        {
            this.id=id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getImage()
        {
            return this.image;
        }

        public void setImage(string image)
        {
            this.image=image;
        }

        public int getPrice()
        {
            return this.price;
        }

        public void setPrice(int price)
        {
            this.price=price;
        }

        public int getStock()
        {
            return this.stock;
        }

        public void setStock(int stock)
        {
            this.stock=stock;
        }

        public string save()
        {

            string text = "";

            text+=this.id.ToString()+",";
            text+=this.name+",";
            text+=this.image+",";
            text+=this.price.ToString()+",";
            text+=this.stock.ToString();

            return text;
        }



    }
}
