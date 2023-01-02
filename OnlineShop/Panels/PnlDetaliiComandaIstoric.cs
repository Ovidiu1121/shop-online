using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlDetaliiComandaIstoric:Panel
    {
        private Label lblTitle;
        private Label lblTitleSequel;
        private Panel pnlAllCards;
        private Label lblAsideCostProduse;
        private Label lblAsideCostLivrare;
        private Label lblCostProduse;
        private Label lblCostLivrare;
        private Label lblAsideTotal;
        private Label lblCostTotal;
        private Label lblLei1;
        private Label lblLei2;
        private Label lblLei3;
        private FrmHome frmHome;
        private Order order;
        private ControlOrderDetails controlOrderDetails=new ControlOrderDetails();

        public PnlDetaliiComandaIstoric(FrmHome frmHome,Order order)
        {
            this.order = order;
            this.frmHome = frmHome;
            this.Location = new Point(0, 120);
            this.Size = new Size(1950, 1000);
            this.BackColor = Color.White;
            this.Name="PnlDetaliiComandaIstoric";

            this.lblTitle = new Label();
            this.Controls.Add(this.lblTitle);
            this.lblTitle.Location = new Point(59, 36);
            this.lblTitle.Size=new Size(210, 45);
            this.lblTitle.Text="Comanda nr.";
            this.lblTitle.Font=new Font("Arial", 20, FontStyle.Regular);

            this.lblTitleSequel=new Label();
            this.Controls.Add(this.lblTitleSequel);
            this.lblTitleSequel.Location=new Point(265, 36);
            this.lblTitleSequel.Size=new Size(100, 45);
            this.lblTitleSequel.Text=order.getId().ToString();
            this.lblTitleSequel.Font=new Font("Arial", 20, FontStyle.Regular);

            this.pnlAllCards=new Panel();
            this.Controls.Add(this.pnlAllCards);
            this.pnlAllCards.Location=new Point(59, 85);
            this.createCards();
            this.pnlAllCards.Size=new Size(1230, 650);
            this.pnlAllCards.BorderStyle=BorderStyle.FixedSingle;

            this.lblAsideCostProduse=new Label();
            this.Controls.Add(this.lblAsideCostProduse);
            this.lblAsideCostProduse.Location=new Point(870, 750);
            this.lblAsideCostProduse.Size=new Size(160, 30);
            this.lblAsideCostProduse.Text="Cost produse";
            this.lblAsideCostProduse.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblAsideCostLivrare=new Label();
            this.Controls.Add(this.lblAsideCostLivrare);
            this.lblAsideCostLivrare.Location=new Point(870, 800);
            this.lblAsideCostLivrare.Size=new Size(160, 30);
            this.lblAsideCostLivrare.Text="Cost livrare";
            this.lblAsideCostLivrare.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblAsideTotal=new Label();
            this.Controls.Add(this.lblAsideTotal);
            this.lblAsideTotal.Location=new Point(870, 850);
            this.lblAsideTotal.Size=new Size(160, 30);
            this.lblAsideTotal.Text="Total";
            this.lblAsideTotal.Font=new Font("Arial", 14, FontStyle.Bold);

            this.lblLei1=new Label();
            this.Controls.Add(this.lblLei1);
            this.lblLei1.Location=new Point(1230, 750);
            this.lblLei1.Size=new Size(50, 30);
            this.lblLei1.Text="lei";
            this.lblLei1.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblLei2=new Label();
            this.Controls.Add(this.lblLei2);
            this.lblLei2.Location=new Point(1230, 800);
            this.lblLei2.Size=new Size(50, 30);
            this.lblLei2.Text="lei";
            this.lblLei2.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblLei3=new Label();
            this.Controls.Add(this.lblLei3);
            this.lblLei3.Location=new Point(1230, 850);
            this.lblLei3.Size=new Size(50, 30);
            this.lblLei3.Text="lei";
            this.lblLei3.Font=new Font("Arial", 14, FontStyle.Bold);

            this.lblCostProduse=new Label();
            this.Controls.Add(this.lblCostProduse);
            this.lblCostProduse.Location=new Point(1150, 750);
            this.lblCostProduse.Size=new Size(160, 30);
            int price = order.getAmmount()-20;
            this.lblCostProduse.Text=price.ToString();
            this.lblCostProduse.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblCostLivrare=new Label();
            this.Controls.Add(this.lblCostLivrare);
            this.lblCostLivrare.Location=new Point(1150, 800);
            this.lblCostLivrare.Size=new Size(160, 30);
            this.lblCostLivrare.Text="20";
            this.lblCostLivrare.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblCostTotal=new Label();
            this.Controls.Add(this.lblCostTotal);
            this.lblCostTotal.Location=new Point(1150, 850);
            this.lblCostTotal.Size=new Size(160, 30);
            this.lblCostTotal.Text=order.getAmmount().ToString();
            this.lblCostTotal.Font=new Font("Arial", 14, FontStyle.Bold);

        }


        public void createCards()
        {
            int x = 15, y = 15;

            List<OrderDetails> orderDetails = this.controlOrderDetails.getList();

            foreach (OrderDetails o in orderDetails)
            {

                PnlCardDetaliiComanda pnlCard = new PnlCardDetaliiComanda(this.frmHome, o);
                pnlCard.Location = new Point(x, y);
                this.pnlAllCards.Controls.Add(pnlCard);

                y+=160;
            }

            if (y>this.pnlAllCards.Height)
            {
                this.pnlAllCards.AutoScroll = true;
            }

            


        }

    }
}
