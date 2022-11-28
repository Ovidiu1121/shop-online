using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlProductsMain:Panel
    {
        FrmHome frmHome;
        Label lblTitle;
        Panel pnlCard;
        Panel pnlAllCards;

        ControlProduct control = new ControlProduct();

        public PnlProductsMain(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(0, 120);
            this.Size = new Size(799, 336);
            this.BackColor = Color.Gray; 
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

         

            this.lblTitle = new Label();
            this.Controls.Add(this.lblTitle);
            this.lblTitle.Location = new Point(337, 16);
            this.lblTitle.Size = new Size(134, 37);
            this.lblTitle.Text="PRODUSE";
            this.lblTitle.Font=new Font("Arial",14, FontStyle.Bold);

            this.pnlAllCards=new Panel();

            this.pnlAllCards.Parent=this;
            //this.Controls.Add(this.pnlAllCards);
            this.pnlAllCards.Location = new Point(12, 100);
            this.pnlAllCards.BackColor = Color.White;
            this.pnlAllCards.Anchor = AnchorStyles.Right;
            this.Dock=DockStyle.Fill;

            this.createCards(4);

            this.pnlAllCards.Size=new Size(this.Width, 254);



        }

        public void createCards(int nrCollums)
        {
            int x = 16, y = 20, ct = 0;

            List<Product> products = this.control.getList();

            foreach(Product p in products)
            {

                ct++;
                PnlCard pnlCard = new PnlCard(p);
                pnlCard.Location = new Point(x, y);
                this.pnlAllCards.Controls.Add(pnlCard);

                x+=200;

                if (ct%nrCollums==0)
                {
                    x=16;
                    y+=250;
                }

                if (y>this.pnlAllCards.Height)
                {
                    this.pnlAllCards.AutoScroll = true;
                }

            }
           



        }



    }
}
