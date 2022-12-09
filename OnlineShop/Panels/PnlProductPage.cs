using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlProductPage:Panel
    {

        private Label lblDetails;
        private Label lblPrice;
        private Label lblLei;
        private Label lblGarantie1;
        private Label lblGarantie2;
        private FontAwesome.Sharp.IconButton btnFavorite;
        private PictureBox pictureBox;
        private FrmHome frmHome;
        private RoundedButton btnAdaugaInCos;
        private Product product;
        private Customer customer;
        private Order order;

        public PnlProductPage(FrmHome frmHome,Product product)
        {
            this.product = product;
            this.customer = frmHome.getCustomer();
            this.order = frmHome.getOrder();
            this.frmHome = frmHome;
            this.Location = new Point(0, 120);
            this.Size = new Size(1950, 1000);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left|AnchorStyles.Bottom;
            this.Name="pnlProductPage";

            this.lblDetails = new Label();
            this.Controls.Add(this.lblDetails);
            this.lblDetails.Location = new Point(83, 74);
            this.lblDetails.Size = new Size(1000, 54);
            this.lblDetails.Text=product.getName().ToString();
            this.Font=new Font("Arial", 24, FontStyle.Bold);

            this.pictureBox=new PictureBox();
            this.Controls.Add(this.pictureBox);
            this.pictureBox.Location = new Point(400, 200);
            this.pictureBox.Size = new Size(600, 600);
            this.pictureBox.Image=Image.FromFile(Application.StartupPath+@"/images/"+product.getImage().ToString()+".jpg");
            this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            this.lblPrice=new Label();
            this.Controls.Add(this.lblPrice);
            this.lblPrice.Location = new Point(1100, 280);
            this.lblPrice.Size = new Size(115, 47);
            this.lblPrice.Text=product.getPrice().ToString();
            this.lblPrice.Font=new Font("Segoe UI",24, FontStyle.Regular);

            this.lblLei=new Label();
            this.Controls.Add(this.lblLei);
            this.lblLei.Location = new Point(1210, 280);
            this.lblLei.Size = new Size(80, 45);
            this.lblLei.Text="lei";
            this.lblLei.Font=new Font("Segoe UI", 24, FontStyle.Regular);

            this.lblGarantie1 = new Label();
            this.Controls.Add(this.lblGarantie1);
            this.lblGarantie1.Location = new Point(1100, 370);
            this.lblGarantie1.Size = new Size(300, 23);
            this.lblGarantie1.Text="Garantie comerciala: 12 luni";
            this.lblGarantie1.Font=new Font("Arial", 12, FontStyle.Bold);

            this.lblGarantie2 = new Label();
            this.Controls.Add(this.lblGarantie2);
            this.lblGarantie2.Location = new Point(1100, 400);
            this.lblGarantie2.Size = new Size(330, 23);
            this.lblGarantie2.Text="Garantie de conformitate: 24 luni";
            this.lblGarantie2.Font=new Font("Arial", 12, FontStyle.Bold);

            this.btnAdaugaInCos=new RoundedButton();
            this.Controls.Add(this.btnAdaugaInCos);
            this.btnAdaugaInCos.Location = new Point(1100, 470);
            this.btnAdaugaInCos.Size = new Size(250, 73);
            this.btnAdaugaInCos.BackColor=Color.Red;
            this.btnAdaugaInCos.Text="Adauga in cos";
            this.btnAdaugaInCos.ForeColor=Color.White;
            this.btnAdaugaInCos.FlatAppearance.BorderSize=0;
            this.btnAdaugaInCos.FlatStyle=FlatStyle.Flat;
            this.btnAdaugaInCos.Font=new Font("Cascadia Mono", 12, FontStyle.Regular);
            this.btnAdaugaInCos.Click+=new EventHandler(this.create_order_Click);

            this.btnFavorite=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btnFavorite);
            this.btnFavorite.Location=new Point(1100, 570);
            this.btnFavorite.Size=new Size(160, 45);
            this.btnFavorite.IconChar=FontAwesome.Sharp.IconChar.Heart;
            this.btnFavorite.Text="Favorite";
            this.btnFavorite.TextImageRelation=TextImageRelation.ImageBeforeText;
            this.btnFavorite.FlatAppearance.BorderSize=0;
            this.btnFavorite.FlatStyle=FlatStyle.Flat;
            this.btnFavorite.Font=new Font("Arial", 12, FontStyle.Bold);
            this.btnFavorite.IconSize=40;

        }

        private void create_order_Click(object sender,EventArgs e)
        {
            ControlOrderDetails controlOrderDetails=new ControlOrderDetails();
            OrderDetails details=new OrderDetails(controlOrderDetails.generateNextId(),this.order.getId(),this.product.getId(),this.product.getPrice(),1);

            if (controlOrderDetails.isOrderDetails(details.getOrderId(), details.getProdcutId())==false)
            {
                controlOrderDetails.add(details);
                controlOrderDetails.salvareFisier();
            }
            else
            {
                controlOrderDetails.update(details);
                controlOrderDetails.salvareFisier();
            }


        }


    }
}
