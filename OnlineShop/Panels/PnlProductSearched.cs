using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlProductSearched:Panel
    {

        private PictureBox pictureBox;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblLei;
        private FrmHome frmHome;
        private Product product;

        public PnlProductSearched(FrmHome frmHome, Product product)
        {

            this.product = product;
            this.frmHome = frmHome;
 
            this.Name="pnlProductSearched";
            this.Location = new Point(0, 118);
            this.Size = new Size(1950, 1000);

            this.lblDescription=new Label();
            this.Controls.Add(this.lblDescription);
            this.lblDescription.Text=product.getName().ToString();
            this.lblDescription.Location=new Point(434, 211);
            this.lblDescription.Size=new Size(242, 70);
            this.lblDescription.Font=new Font("Arial", 15, FontStyle.Regular);

            this.lblLei=new Label();
            this.Controls.Add(this.lblLei);
            this.lblLei.Text="Lei";
            this.lblLei.Location=new Point(500, 307);
            this.lblLei.Size=new Size(45, 31);
            this.lblLei.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblPrice=new Label();
            this.Controls.Add(this.lblPrice);
            this.lblPrice.Text=product.getPrice().ToString();
            this.lblPrice.Location=new Point(434, 307);
            this.lblPrice.Size=new Size(91, 31);
            this.lblPrice.Font=new Font("Arial", 14, FontStyle.Regular);

            this.pictureBox=new PictureBox();
            this.Controls.Add(this.pictureBox);
            this.pictureBox.Location=new Point(200, 200);
            this.pictureBox.Size=new Size(225, 206);
            this.pictureBox.Image=Image.FromFile(Application.StartupPath+ @"/images/"+product.getImage().ToString()+".jpg");
            this.pictureBox.SizeMode=PictureBoxSizeMode.Zoom;
            this.pictureBox.Click+=new EventHandler(this.product_page_Click);

        }

        public void product_page_Click(object sender, EventArgs e)
        {

            this.frmHome.Controls.Remove(this.frmHome.activePanel);
            this.frmHome.activePanel=new PnlProductPage(this.frmHome, this.product);
            this.frmHome.Controls.Add(this.frmHome.activePanel);


        }



    }
}
