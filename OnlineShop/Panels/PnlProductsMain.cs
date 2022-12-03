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
            this.BackColor = Color.White; 
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left|AnchorStyles.Bottom;
            this.Name="pnlProductsMain";
         
            this.pnlAllCards=new Panel();
            this.pnlAllCards.Parent=this;
            this.pnlAllCards.Location = new Point(12, 56);
            this.pnlAllCards.BackColor = Color.White;
            this.pnlAllCards.Anchor = AnchorStyles.Right;

            this.createCards(6);

            this.pnlAllCards.Size=new Size(this.Width, 300);



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

                x+=175;

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
