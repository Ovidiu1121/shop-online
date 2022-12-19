using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlCos:Panel
    {
        private FrmHome frmHome;
        private Customer customer;
        private Label lblTitle1;
        private Panel pnlAllCards;
        private Panel pnlSumar;
        private ControlProduct controlProduct=new ControlProduct();
        private ControlOrderDetails controlOrderDetails=new ControlOrderDetails();  

        public PnlCos(FrmHome frmHome,Customer customer)
        {
            this.frmHome = frmHome; 
            this.customer = customer;

            this.Location = new Point(0, 120);
            this.Size = new Size(1950, 1000);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
            this.Name="pnlCos";
            
            this.lblTitle1 = new Label();
            this.Controls.Add(this.lblTitle1);
            this.lblTitle1.Location = new Point(150, 150);
            this.lblTitle1.Size = new Size(600, 54);
            this.lblTitle1.Text="Cosul meu de cumparaturi";
            this.lblTitle1.Font=new Font("Arial", 25, FontStyle.Regular);

            this.pnlAllCards = new Panel();
            this.Controls.Add(this.pnlAllCards);
            this.pnlAllCards.Location = new Point(150, 220);
            this.createCards();
            this.pnlAllCards.Size = new Size(1050, 800);
            this.pnlAllCards.BackColor = Color.White;


            this.pnlSumar=new PnlSumarCos(frmHome);
            this.Controls.Add(this.pnlSumar);

        }

        public void createCards()
        {
            int x = 15, y = 15;

            List<OrderDetails> orderDetails = this.controlOrderDetails.getList();

            if (this.controlOrderDetails.isEmpty()==true)
            {
                return;
            }
            else
            {
                foreach (OrderDetails o in orderDetails)
                {

                    Product product = this.controlProduct.returnProductById(o.getProdcutId());
                    PnlCardOrder pnlCard = new PnlCardOrder(this.frmHome, o, product);
                    pnlCard.Location = new Point(x, y);
                    this.pnlAllCards.Controls.Add(pnlCard);

                    y+=210;
                }

                if (y>this.pnlAllCards.Height)
                {
                    this.pnlAllCards.AutoScroll = true;
                }

            }
            

        }


    }
}
