using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlIstoricComenzi:Panel
    {
        private Panel pnlAllCards;
        private Label lblTitle;
        private FrmHome frmHome;
        private ControlOrderDetails controlOrderDetails=new ControlOrderDetails();
        private ControlOrder controlOrder=new ControlOrder();
        private Customer customer;
        private Label lblEmpty;

        public PnlIstoricComenzi(FrmHome frmHome,Customer customer)
        {
            this.frmHome = frmHome;
            this.customer = customer;

            this.Location = new Point(0, 120);
            this.Size = new Size(1950, 1000);
            this.BackColor = Color.White;
            this.Name="PnlIstoricComenzi";

            if (this.controlOrder.isEmpty().Equals(true))
            {
                this.lblEmpty = new Label();
                this.Controls.Add(this.lblEmpty);
                this.lblEmpty.Location = new Point(100, 95);
                this.lblEmpty.Size = new Size(500, 50);
                this.lblEmpty.Text="Nu ai plasat nici o comanda.";
                this.lblEmpty.Font=new Font("Arial", 20, FontStyle.Regular);
            }
            else
            {
                this.lblTitle = new Label();
                this.Controls.Add(this.lblTitle);
                this.lblTitle.Location = new Point(100, 40);
                this.lblTitle.Size = new Size(160, 45);
                this.lblTitle.Text="Comenzi";
                this.lblTitle.Font=new Font("Arial", 20, FontStyle.Bold);

                this.pnlAllCards = new Panel();
                this.Controls.Add(this.pnlAllCards);
                this.pnlAllCards.Location = new Point(100, 95);
                this.createCards();
                this.pnlAllCards.Size=new Size(1220, 750);
                this.BackColor= Color.White;
            }

        }

        public void createCards()
        {
            int x = 15, y = 15;

            List<Order> order = this.controlOrder.getList();

                foreach (Order o in order)
                {
                    if (o.getFinalizare().Equals(true))
                    {
                        if (this.customer.getId().Equals(o.getCustomerId())==true)
                        {
                            PnlCardIstoricComanda pnlCard = new PnlCardIstoricComanda(this.frmHome, o);
                            pnlCard.Location = new Point(x, y);
                            this.pnlAllCards.Controls.Add(pnlCard);

                            y+=100;
                        }
                    }

                }

                if (y>this.pnlAllCards.Height)
                {
                    this.pnlAllCards.AutoScroll = true;
                }


        }

    }
}
