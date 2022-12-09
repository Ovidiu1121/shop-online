using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlCos:Panel
    {
        private FrmHome frmHome;
        private Customer customer;
        private Label lblTitle1;
        private Label lblTitle2;
        private Label lblAsideCostProduse;
        private Label lblAsideCostLivrare;
        private Label lblCostProduse;
        private Label lblCostLivrare;
        private Label lblAsideTotal;
        private Label lblLei1;
        private Label lblLei2;
        private Label lblLei3;
        RoundedButton btnContinua;
        private Panel pnlAllcards;

        public PnlCos(FrmHome frmHome,Customer customer)
        {
            this.frmHome = frmHome; 
            this.customer = customer;

            this.Location = new Point(0, 120);
            this.Size = new Size(1950, 1000);
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Beige;
            this.Name="pnlCos";
            
            this.lblTitle1 = new Label();
            this.Controls.Add(this.lblTitle1);
            this.lblTitle1.Location = new Point(150, 150);
            this.lblTitle1.Size = new Size(600, 54);
            this.lblTitle1.Text="Cosul meu de cumparaturi";
            this.lblTitle1.Font=new Font("Arial", 25, FontStyle.Regular);

            this.pnlAllcards = new Panel();
            this.Controls.Add(this.pnlAllcards);
            this.pnlAllcards.Location = new Point(150, 220);
            this.pnlAllcards.Size = new Size(1200, 800);
            this.pnlAllcards.BackColor = Color.White;



        }

    }
}
