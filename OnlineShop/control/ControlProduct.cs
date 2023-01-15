using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class ControlProduct
    {
        private List<Product> lista=new List<Product>();
        public string path = Application.StartupPath+@"/data_product/products.txt";

        public ControlProduct()
        {
            this.load();
        }

        public void load()
        {

            StreamReader reader = new StreamReader(path);

            string line = "";

            while ((line=reader.ReadLine())!=null&&line.Length>2)
            {
                Product p = new Product(line);
                lista.Add(p);
            }
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

        public void add(Product x)
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

        public Product returnProductById(int id)
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

        public void update(int id, Product newProduct)
        {

            Product old = returnProductById(id);

            old.setName(newProduct.getName());
            old.setImage(newProduct.getImage());
            old.setPrice(newProduct.getPrice());
            old.setStock(newProduct.getStock());
            

        }

        public List<Product> getList()
        {
            return lista;
        }

        public List<string> getAllCategories()
        {

            List<string> categories = new List<string>();

            for(int i = 0; i<lista.Count; i++)
            {
                if (categories.Contains(lista[i].getCategory())==false)
                {
                    categories.Add(lista[i].getCategory());
                }
            }
            return categories;
        }

        public int getPriceById(int id)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getId().Equals(id))
                {
                    return this.lista[i].getPrice();
                }
            }
            return -1;
        }

        public Product returnProdByString(string description)
        {
            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getName().Contains(description).Equals(true))
                {
                    return lista[i];
                }
            }
            return null;
        }

    }
}
