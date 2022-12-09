using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlCardOrder:Panel
    {
        private PictureBox pictureBox1;
        private Label lblDescribe;
        private Label lblDisponibilInStoc;
        private Label lblProductPrice;
        private Label lblLei;
        private Label lblBuc;
        private NumericUpDown numericUpDown;
        private Button btnStergere;
        private Button btnAddFavorite;
        private FrmHome frmHome;
        private Product product;



        public PnlCardOrder(FrmHome frmHome, Product product)
        {
            this.frmHome = frmHome;
            this.product = product;

            this.Size=new Size(1000, 200);
            this.Name="pnlCardOrder";
            this.BackColor=Color.White;
            this.BorderStyle = BorderStyle.Fixed3D;

            this.pictureBox1 = new PictureBox();
            this.Controls.Add(this.pictureBox1);
            this.pictureBox1.Location=new Point(17, 12);
            this.pictureBox1.Size=new Size(236, 183);
            this.pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image=Image.FromFile(Application.StartupPath+@"/images/"+this.product.getImage()+".jpg");

            this.lblDescribe=new Label();
            this.Controls.Add(this.lblDescribe);
            this.lblDescribe.Location=new Point(269, 12);
            this.lblDescribe.Size=new Size(382, 25);
            this.lblDescribe.Text=this.product.getName().ToString();

        }



    }
}
