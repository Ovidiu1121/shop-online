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
        Panel pnlAllCards;
        PictureBox pictureBox;

        ControlProduct control = new ControlProduct();

        public PnlProductsMain(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(0, 118);
            this.Size = new Size(1950, 1000);
            this.BackColor = Color.White; 
            this.Name="pnlProductsMain";
         
            this.pnlAllCards=new Panel();
            this.pnlAllCards.Parent=this;
            this.pnlAllCards.Location = new Point(500, 400);
            this.pnlAllCards.BackColor = Color.White;
            this.pnlAllCards.Anchor = AnchorStyles.Right;

            this.createCards(9);

            this.pnlAllCards.Size=new Size(900, 300);

            this.pictureBox=new PictureBox();
            this.Controls.Add(this.pictureBox);
            this.pictureBox.Location=new Point(400, 0);
            this.pictureBox.Size=new Size(1100, 370);
            this.pictureBox.BorderStyle=BorderStyle.FixedSingle;
            this.pictureBox.Image=Image.FromFile(Application.StartupPath+@"/Logos-Icons/ad1.jfif");


        }

        public void createCards(int nrCollums)
        {
            int x = 16, y = 20, ct = 0;

            List<Product> products = this.control.getList();

            foreach(Product p in products)
            {

                ct++;
                PnlCard pnlCard = new PnlCard(p,this.frmHome);
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
