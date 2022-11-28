using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlCard:Panel
    {
        Label lblDescriere;
        Label lblPret;
        Label lblLei;
        PictureBox pictureBox1;

        public PnlCard(Product product)
        {

            this.Size = new Size(134, 200);
            this.BackColor=Color.Blue;
            //this.BorderStyle = BorderStyle.FixedSingle;

            this.lblDescriere = new Label();
            this.Controls.Add(this.lblDescriere);
            this.lblDescriere.Location = new Point(13, 109);
            this.lblDescriere.Size = new Size(129, 60);
            this.lblDescriere.Text=product.describe();

            this.lblPret = new Label();
            this.Controls.Add(this.lblPret);
            this.lblPret.Location = new Point(13, 169);
            this.lblPret.Size = new Size(60, 20);
            this.lblPret.Text="0000.00";

            this.lblLei = new Label();
            this.Controls.Add(this.lblLei);
            this.lblLei.Location = new Point(79, 169);
            this.lblLei.Size = new Size(25, 20);
            this.lblLei.Text="lei";

     
           // this.pictureBox1= new PictureBox();

           // this.pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
           //// this.pictureBox1.Image=Image.FromFile(Application.StartupPath + @"/images/" + product.getImage() + ".jpg");
           // this.pictureBox1.Location = new Point(13, 13);
           // this.pictureBox1.Size = new Size(125, 83);

            

        }


    }
}
