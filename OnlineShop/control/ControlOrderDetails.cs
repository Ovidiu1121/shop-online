﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class ControlOrderDetails
    {

        private List<OrderDetails> lista=new List<OrderDetails>();
        public string path = Application.StartupPath+@"/data_orderDetails/orderDetails.txt";

        private ControlProduct controlProduct=new ControlProduct();

        public ControlOrderDetails()
        {
            this.load();

        }

        public void load()
        {

            StreamReader reader = new StreamReader(path);

            string line = "";

            while ((line=reader.ReadLine())!=null&& line.Length>2)
            {
                OrderDetails o = new OrderDetails(line);
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

        public void add(OrderDetails x)
        {

            lista.Add(x);

        }

        public void deleteByProductId(int productId)
        {

            for (int i = 0; i<=lista.Count-1; i++)
            {
                if (lista[i].getProdcutId().Equals(productId))
                {
                    lista.RemoveAt(i);
                    i--;
                }
            }

        }

        public OrderDetails returnOrderDetailsById(int id)
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
            }else
            {
                return lista[lista.Count-1].getId()+1;
            }
        }

        public bool isOrderDetails(int orderId, int productId)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getOrderId().Equals(orderId)==true&&lista[i].getProdcutId().Equals(productId)==true)
                {
                    return true;
                }
            }
            return false;
        }

        public void update(OrderDetails newOrderDetails)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getOrderId().Equals(newOrderDetails.getOrderId())==true&&lista[i].getProdcutId().Equals(newOrderDetails.getProdcutId())==true)
                {
                    OrderDetails old = lista[i];

                    int pret = this.controlProduct.getPriceById(old.getProdcutId());

                    old.setQuantity(old.getQuantity()+newOrderDetails.getQuantity());
                    old.setPrice(old.getPrice()+pret);
                }
            }

        }

        public void updateQuantityByProductId(int productId, int quantity)
        {
            
            for(int i=0;i<lista.Count; i++)
            {
                if (lista[i].getProdcutId().Equals(productId))
                {
                    int firstPrice=this.controlProduct.getPriceById(productId);

                    this.lista[i].setQuantity(quantity);
                    this.lista[i].setPrice(firstPrice*quantity);
                }
            }

        }

        public List<OrderDetails> getList()
        {
            return lista;
        }

        public int costTotalProduse(int orderId)
        {

            int s = 0;

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getOrderId().Equals(orderId))
                {
                    s+=lista[i].getPrice();
                }
            }
            return s;
        }

        public OrderDetails getOrderDetailsByProductId(int productId)
        {

            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getProdcutId().Equals(productId))
                {
                    return this.lista[i];
                }
            }
            return null;
        }

        public bool isEmpty()
        {

            if (lista.Count==0)
            {
                return true;
            }
            return false;
        }

        public void deleteAll()
        {

            this.lista.Clear();

        }

        public bool existOrderDetails_byOrderId(int orderId)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getOrderId().Equals(orderId))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
