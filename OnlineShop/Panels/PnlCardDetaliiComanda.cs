using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlCardDetaliiComanda:Panel
    {
        private PictureBox pct;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblLei;
        private Label lblAmmount;
        private Label lblBuc;
        private FrmHome frmHome;
        private OrderDetails orderDetails;
        private ControlOrderDetails controlOrderDetails=new ControlOrderDetails();
        private ControlProduct controlProduct=new ControlProduct();

        public PnlCardDetaliiComanda(FrmHome frmHome,OrderDetails orderDetails)
        {
            this.frmHome = frmHome;
            this.orderDetails = orderDetails;

            this.Location=new Point(300,300);
            this.Size=new Size(1190, 150);
            this.Name="pnlCardDetaliiComanda";
            this.BackColor=Color.White;
            this.BorderStyle = BorderStyle.Fixed3D;

            this.pct = new PictureBox();
            this.Controls.Add(this.pct);
            this.pct.Location=new Point(20, 10);
            this.pct.Size=new Size(143, 124);
            this.pct.SizeMode=PictureBoxSizeMode.Zoom;
            Product p = controlProduct.returnProductById(orderDetails.getProdcutId());
            this.pct.Image=Image.FromFile(Application.StartupPath + @"/images/"+p.getImage().ToString()+".jpg");
            
            this.lblDescription=new Label();
            this.Controls.Add(this.lblDescription);
            this.lblDescription.Location=new Point(180, 55);
            this.lblDescription.Size=new Size(368, 31);
            this.lblDescription.Text=p.getName().ToString();
            this.lblDescription.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lblLei=new Label();
            this.Controls.Add(this.lblLei);
            this.lblLei.Location=new Point(this.Width-100, 45);
            this.lblLei.Size=new Size(32, 25);
            this.lblLei.Text="lei";
            this.lblLei.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lblPrice=new Label();
            this.Controls.Add(this.lblPrice);
            this.lblPrice.Location=new Point(this.Width-160, 45);
            this.lblPrice.Size=new Size(60, 25);
            this.lblPrice.Text=p.getPrice().ToString();
            this.lblPrice.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lblBuc=new Label();
            this.Controls.Add(this.lblBuc);
            this.lblBuc.Location=new Point(this.Width-108, 75);
            this.lblBuc.Size=new Size(45, 25);
            this.lblBuc.Text="buc";
            this.lblBuc.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblAmmount=new Label();
            this.Controls.Add(this.lblAmmount);
            this.lblAmmount.Location=new Point(this.Width-130, 75);
            this.lblAmmount.Size=new Size(45, 25);
            this.lblAmmount.Text=orderDetails.getQuantity().ToString();
            this.lblAmmount.Font=new Font("Arial", 12, FontStyle.Regular);

        }


    }
}
