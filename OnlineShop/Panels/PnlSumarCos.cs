using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlSumarCos:Panel
    {
        private FrmHome frmHome;
        private Label lblTitle1;
        private Label lblAsideCostProduse;
        private Label lblAsideCostLivrare;
        private Label lblCostProduse;
        private Label lblCostLivrare;
        private Label lblAsideTotal;
        private Label lblCostTotal;
        private Label lblLei1;
        private Label lblLei2;
        private Label lblLei3;
        RoundedButton btnContinua;
        private ControlOrderDetails controlOrderDetails=new ControlOrderDetails();
        private ControlOrder controlOrder=new ControlOrder();

        public PnlSumarCos(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(1230, 234);
            this.Size = new Size(600, 400);
            this.Name="pnlSumarCos";
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.lblTitle1 = new Label();
            this.Controls.Add(this.lblTitle1);
            this.lblTitle1.Location = new Point(25, 15);
            this.lblTitle1.Size = new Size(270, 45);
            this.lblTitle1.Text="Sumar comanda";
            this.lblTitle1.Font=new Font("Arial", 20, FontStyle.Regular);

            this.lblAsideCostProduse=new Label();
            this.Controls.Add(this.lblAsideCostProduse);
            this.lblAsideCostProduse.Location = new Point(25, 88);
            this.lblAsideCostProduse.Size = new Size(150, 30);
            this.lblAsideCostProduse.Text="Cost produse:";
            this.lblAsideCostProduse.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblAsideCostLivrare=new Label();
            this.Controls.Add(this.lblAsideCostLivrare);
            this.lblAsideCostLivrare.Location = new Point(25, 140);
            this.lblAsideCostLivrare.Size = new Size(150, 30);
            this.lblAsideCostLivrare.Text="Cost livrare:";
            this.lblAsideCostLivrare.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblAsideTotal=new Label();
            this.Controls.Add(this.lblAsideTotal);
            this.lblAsideTotal.Location = new Point(25, 200);
            this.lblAsideTotal.Size = new Size(150, 30);
            this.lblAsideTotal.Text="Total:";
            this.lblAsideTotal.Font=new Font("Arial", 16, FontStyle.Bold);

            this.lblCostProduse=new Label();
            this.Controls.Add(this.lblCostProduse);
            this.lblCostProduse.Location = new Point(495, 88);
            this.lblCostProduse.Size = new Size(70, 20);
            this.lblCostProduse.Text=this.controlOrderDetails.costTotalProduse().ToString();
            this.lblCostProduse.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblCostLivrare=new Label();
            this.Controls.Add(this.lblCostLivrare);
            this.lblCostLivrare.Location = new Point(495, 140);
            this.lblCostLivrare.Size = new Size(40, 20);
            if (this.lblCostProduse.Text.Equals("0"))
            {
                this.lblCostLivrare.Text="0";
            }
            else
            {
                this.lblCostLivrare.Text="20";
            }
            this.lblCostLivrare.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblLei1=new Label();
            this.Controls.Add(this.lblLei1);
            this.lblLei1.Location = new Point(560, 88);
            this.lblLei1.Size = new Size(150, 30);
            this.lblLei1.Text="lei";
            this.lblLei1.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblLei2=new Label();
            this.Controls.Add(this.lblLei2);
            this.lblLei2.Location = new Point(560, 140);
            this.lblLei2.Size = new Size(150, 30);
            this.lblLei2.Text="lei";
            this.lblLei2.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblCostTotal=new Label();
            this.Controls.Add(this.lblCostTotal);
            this.lblCostTotal.Location = new Point(460, 200);
            this.lblCostTotal.Size = new Size(90, 31);
            int price = int.Parse(this.lblCostProduse.Text)+int.Parse(this.lblCostLivrare.Text);
            this.lblCostTotal.Text=price.ToString();
            this.lblCostTotal.ForeColor=Color.Red;
            this.lblCostTotal.Font=new Font("Arial", 16, FontStyle.Regular);

            this.lblLei3=new Label();
            this.Controls.Add(this.lblLei3);
            this.lblLei3.Location = new Point(550, 200);
            this.lblLei3.Size = new Size(150, 30);
            this.lblLei3.Text="lei";
            this.lblLei3.ForeColor=Color.Red;
            this.lblLei3.Font=new Font("Arial", 16, FontStyle.Regular);

            this.btnContinua=new RoundedButton();
            this.Controls.Add(this.btnContinua);
            this.btnContinua.Location = new Point(25, 270);
            this.btnContinua.Size = new Size(550, 80);
            this.btnContinua.Text="Continua";
            this.btnContinua.ForeColor=Color.White;
            this.btnContinua.BackColor=Color.Red;
            this.btnContinua.FlatAppearance.BorderSize=0;
            this.btnContinua.FlatStyle=FlatStyle.Flat;
            this.btnContinua.Font=new Font("Cascadia Mono", 15, FontStyle.Regular);
            this.btnContinua.Click+=new EventHandler(this.send_order_Click);

        }

        private void send_order_Click(object sender, EventArgs e)
        {
            if (this.frmHome.logat==true)
            {
                Order order = this.frmHome.getOrder();

                order.setAmmount(int.Parse(this.lblCostTotal.Text));
                order.setFinalizare(true);
                this.controlOrder.salvareFisier();
            }
            else
            {
                MessageBox.Show("Nu sunteti logat.");
            }
        }


    }
}
