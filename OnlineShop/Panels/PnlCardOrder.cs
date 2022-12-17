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
        private FontAwesome.Sharp.IconButton btnStergere;
        private FontAwesome.Sharp.IconButton btnAddFavorite;
        private FrmHome frmHome;
        private Product product;
        private ControlOrderDetails controlOrderDetails=new ControlOrderDetails();

        public PnlCardOrder(FrmHome frmHome, OrderDetails orderDetails,Product product)
        {
            this.frmHome = frmHome;
            this.product = product;

            this.Size=new Size(1000, 200);
            this.Name="pnlCardOrder";
            this.BackColor=Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.pictureBox1 = new PictureBox();
            this.Controls.Add(this.pictureBox1);
            this.pictureBox1.Image=Image.FromFile(Application.StartupPath+@"/images/imag2.jpg");
            this.pictureBox1.Location=new Point(15, 8);
            this.pictureBox1.Size=new Size(213, 183);
            this.pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;

            this.lblDescribe=new Label();
            this.Controls.Add(this.lblDescribe);
            this.lblDescribe.Location=new Point(240, 12);
            this.lblDescribe.Size=new Size(500, 25);
            this.lblDescribe.Text=this.product.getName().ToString();
            this.lblDescribe.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblDisponibilInStoc=new Label();
            this.Controls.Add(this.lblDisponibilInStoc);
            this.lblDisponibilInStoc.Location=new Point(250, 51);
            this.lblDisponibilInStoc.Size=new Size(127, 20);
            this.lblDisponibilInStoc.Text="Disponibil: in stoc";
            
            this.btnAddFavorite=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btnAddFavorite);
            this.btnAddFavorite.Location=new Point(240, 93);
            this.btnAddFavorite.Size=new Size(222, 34);
            this.btnAddFavorite.Text="Adaugati la favorite";
            this.btnAddFavorite.IconChar=FontAwesome.Sharp.IconChar.Plus;
            this.btnAddFavorite.TextImageRelation=TextImageRelation.ImageBeforeText;
            this.btnAddFavorite.ForeColor=Color.Red;
            this.btnAddFavorite.IconColor=Color.Red;
            this.btnAddFavorite.Font=new Font("Arial", 12, FontStyle.Regular);
            this.btnAddFavorite.IconSize=25;
            this.btnAddFavorite.FlatAppearance.BorderSize=0;
            this.btnAddFavorite.FlatStyle=FlatStyle.Flat;

            this.btnStergere=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btnStergere);
            this.btnStergere.Location=new Point(240, 133);
            this.btnStergere.Size=new Size(127, 34);
            this.btnStergere.Text="Stergere";
            this.btnStergere.IconChar=FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnStergere.TextImageRelation=TextImageRelation.ImageBeforeText;
            this.btnStergere.ForeColor=Color.Red;
            this.btnStergere.IconColor=Color.Red;
            this.btnStergere.Font=new Font("Arial", 12, FontStyle.Regular);
            this.btnStergere.IconSize=25;
            this.btnStergere.FlatAppearance.BorderSize=0;
            this.btnStergere.FlatStyle=FlatStyle.Flat;
            this.btnStergere.Click+=new EventHandler(this.stergere_Click);

            this.numericUpDown=new NumericUpDown();
            this.Controls.Add(this.numericUpDown);
            this.numericUpDown.Location=new Point(921, 62);
            this.numericUpDown.Size=new Size(46, 23);
            this.numericUpDown.Value=orderDetails.getQuantity();
            this.numericUpDown.BorderStyle=BorderStyle.None;

            this.lblProductPrice=new Label();
            this.Controls.Add(this.lblProductPrice);
            this.lblProductPrice.Location=new Point(838, 12);
            this.lblProductPrice.Size=new Size(97, 38);
            int price = (int)(product.getPrice()*numericUpDown.Value);
            this.lblProductPrice.Text=price.ToString();
            this.lblProductPrice.Font=new Font("Arial", 17, FontStyle.Bold);

            this.lblLei=new Label();
            this.Controls.Add(this.lblLei);
            this.lblLei.Location=new Point(930, 12);
            this.lblLei.Size=new Size(50, 38);
            this.lblLei.Text="lei";
            this.lblLei.Font=new Font("Arial",18, FontStyle.Bold);

            this.lblBuc=new Label();
            this.Controls.Add(this.lblBuc);
            this.lblBuc.Location=new Point(877, 59);
            this.lblBuc.Size=new Size(45, 30);
            this.lblBuc.Text="buc";
            this.lblBuc.Font=new Font("Arial", 12, FontStyle.Regular);

        }

        private void stergere_Click(object sender, EventArgs e)
        {

            this.controlOrderDetails.deleteByProductId(this.product.getId());
            this.controlOrderDetails.salvareFisier();

        }


    }
}
