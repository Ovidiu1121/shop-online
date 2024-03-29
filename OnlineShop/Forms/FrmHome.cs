﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class FrmHome : Form
    {
        ControlOrder controlOrder=new ControlOrder();
        public Panel activePanel;
        public Panel header;
        public Panel chooseProduct;
        private Order order;
        private Customer customer=new Customer();
        public bool logat = false;

        public FrmHome()
        {
            InitializeComponent();

            this.BackColor=Color.White;
            this.header = new PnlHeader(this,customer);
            this.chooseProduct=new PnlChooseProduct(this);
            this.activePanel=new PnlContulMeu(this);
            
            this.Controls.Add(header);
            this.Controls.Add(chooseProduct);
            this.Controls.Add(activePanel);

            this.order = new Order(controlOrder.generateNextId(), customer.getId(), 0, false);
            controlOrder.add(order);
            controlOrder.salvareFisier();

            this.FormClosing+=new FormClosingEventHandler(this.delete_undone_orders_Closing);
          
        }

        public void erase(String name)
        {
            Control aux = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(name))
                {
                    aux=c;
                }
            }

            this.Controls.Remove(aux);
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        public Order getOrder()
        {
            return this.order;
        }

        public void setOrder(Order order)
        {
            this.order = order;
        }

        public Customer getCustomer()
        {
            return this.customer;
        }

        public void setCustomer(Customer customer)
        {
            this.customer = customer;
            this.order.setCustomerId(customer.getId());
            this.controlOrder.salvareFisier();
        }

        public void delete_undone_orders_Closing(object sender, EventArgs e)
        {
            this.controlOrder.deleteAllFalse();
            this.controlOrder.salvareFisier();

        }



    }
}
