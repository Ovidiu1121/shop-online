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

            this.Size = new Size(160, 230);
            this.BackColor=Color.White;
            this.Name="pnlCard";
            this.BorderStyle = BorderStyle.FixedSingle;
            

            this.lblDescriere = new Label();
            this.Controls.Add(this.lblDescriere);
            this.lblDescriere.Location = new Point(5, 150);
            this.lblDescriere.Size = new Size(150, 50);
            this.lblDescriere.Text=product.getName().ToString();

            this.lblPret = new Label();
            this.Controls.Add(this.lblPret);
            this.lblPret.Location = new Point(48, 200);
            this.lblPret.Size = new Size(55, 20);
            this.lblPret.Text=product.getPrice().ToString();    

            this.lblLei = new Label();
            this.Controls.Add(this.lblLei);
            this.lblLei.Location = new Point(100, 200);
            this.lblLei.Size = new Size(30, 20);
            this.lblLei.Text="Lei";

     
            this.pictureBox1= new PictureBox();
            this.Controls.Add(this.pictureBox1);
            this.pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image=Image.FromFile(Application.StartupPath + @"/images/"+product.getImage().ToString()+".jpg");
            this.pictureBox1.Location = new Point(13, 13);
            this.pictureBox1.Size = new Size(125, 83);
        }


    }
}
