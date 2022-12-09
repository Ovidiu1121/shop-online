using System;
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

        private  Customer customer=new Customer(4, "emailcustomer@dd.com", "parola", "mihai", "alex", 729376352);
        private  Order order;

        public FrmHome()
        {
            InitializeComponent();

            Product p=new Product(1," Laptop ultraportabil ASUS Zenbook Pro 14"," imag3", 2200, 70, "Laptop");

            this.header = new PnlHeader(this,customer);
            this.chooseProduct=new PnlChooseProduct(this);
            //this.activePanel=new PnlProductsMain(this,customer);
            this.activePanel=new PnlCardOrder(this, p);

            this.Controls.Add(header);
            this.Controls.Add(chooseProduct);
            this.Controls.Add(activePanel);

            order = new Order(controlOrder.getLastId(), customer.getId(), 0, false);
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
        }


    }
}
