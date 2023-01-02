using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlCardIstoricComanda:Panel
    {

        private Label lblComandaNr;
        private Label lblNr;
        private RoundedButton btnDetalii;
        private FrmHome frmHome;
        private Order order;
        public PnlCardIstoricComanda(FrmHome frmHome,Order order)
        {
            this.frmHome = frmHome;
            this.order = order;

            this.Size=new Size(1170, 81);
            this.BorderStyle=BorderStyle.FixedSingle;
            this.Name="PnlCardIstoricComanda";
            this.BackColor=Color.White;

            this.lblComandaNr=new Label();
            this.Controls.Add(this.lblComandaNr);
            this.lblComandaNr.Location=new Point(70, 9);
            this.lblComandaNr.Size=new Size(123, 28);
            this.lblComandaNr.Text="Comanda nr.";
            this.lblComandaNr.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblNr=new Label();
            this.Controls.Add(this.lblNr);
            this.lblNr.Location=new Point(116, 40);
            this.lblNr.Size=new Size(17, 20);
            this.lblNr.Text=order.getId().ToString();

            this.btnDetalii=new RoundedButton();
            this.Controls.Add(this.btnDetalii);
            this.btnDetalii.Location=new Point(960, 12);
            this.btnDetalii.Size=new Size(170, 55);
            this.btnDetalii.Text="Detalii comanda";
            this.btnDetalii.FlatAppearance.BorderSize=0;
            this.btnDetalii.FlatStyle=FlatStyle.Flat;
            this.btnDetalii.ForeColor=Color.Red;
            this.btnDetalii.Font=new Font("Cascadia Mono", 9, FontStyle.Regular);
            this.btnDetalii.Click+=new EventHandler(this.detalii_comanda_Click);

        }

        private void detalii_comanda_Click(object sender ,EventArgs e)
        {
            this.frmHome.Controls.Remove(this.frmHome.activePanel);
            this.frmHome.activePanel=new PnlDetaliiComandaIstoric(this.frmHome, this.order);
            this.frmHome.Controls.Add(this.frmHome.activePanel);


        }

    }
}
