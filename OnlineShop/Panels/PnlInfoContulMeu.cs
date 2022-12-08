using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlInfoContulMeu:Panel
    {

        Label lblTitle1;
        Label lblTitle2;
        Label lblTitle3;
        Label lblAsideNume;
        Label lblAsideEmail;
        Label lblAsideTelefon;
        Label lblAsideParola;
        Label lblNume;
        Label lblEmail;
        Label lblTelefon;
        Label lblParola;
        RoundedButton btnEditeazaDatele;
        RoundedButton btnEditeazaParola;
        FrmHome frmHome;

        public PnlInfoContulMeu(FrmHome frmHome,Customer customer)
        {

            this.frmHome = frmHome;
            this.BackColor = Color.White;
            this.Location = new Point(0, 110);
            this.Size = new Size(1950, 950);
            this.Name="pnlInfoContulMeu";

            this.lblTitle1 = new Label();
            this.Controls.Add(this.lblTitle1);
            this.lblTitle1.Location = new Point(246, 95);
            this.lblTitle1.Size = new Size(400, 50);
            this.lblTitle1.Font=new Font("Arial", 24, FontStyle.Bold);
            this.lblTitle1.Text="Informatiile contului";

            this.lblTitle2 = new Label();
            this.Controls.Add(this.lblTitle2);
            this.lblTitle2.Location = new Point(246, 205);
            this.lblTitle2.Size = new Size(240, 35);
            this.lblTitle2.Text="Datele personale";
            this.lblTitle2.Font=new Font("Regular", 16, FontStyle.Regular);

            this.lblTitle3 = new Label();
            this.Controls.Add(this.lblTitle3);
            this.lblTitle3.Location = new Point(950, 205);
            this.lblTitle3.Size = new Size(240, 28);
            this.lblTitle3.Text="Parola contului tau";
            this.lblTitle3.Font=new Font("Regular", 16, FontStyle.Regular);

            this.lblAsideNume=new Label();
            this.Controls.Add(this.lblAsideNume);
            this.lblAsideNume.Location = new Point(246, 270);
            this.lblAsideNume.Size = new Size(80, 20);
            this.lblAsideNume.Text="nume:";
            this.lblAsideNume.Font=new Font("Regular",12, FontStyle.Regular);

            this.lblAsideEmail=new Label();
            this.Controls.Add(this.lblAsideEmail);
            this.lblAsideEmail.Location = new Point(246, 315);
            this.lblAsideEmail.Size = new Size(80, 20);
            this.lblAsideEmail.Text="email:";
            this.lblAsideEmail.Font=new Font("Regular", 12, FontStyle.Regular);

            this.lblAsideTelefon=new Label();
            this.Controls.Add(this.lblAsideTelefon);
            this.lblAsideTelefon.Location = new Point(246, 360);
            this.lblAsideTelefon.Size = new Size(80, 20);
            this.lblAsideTelefon.Text="telefon:";
            this.lblAsideTelefon.Font=new Font("Regular", 12, FontStyle.Regular);

            this.lblNume=new Label();
            this.Controls.Add(this.lblNume);
            this.lblNume.Location = new Point(350, 270);
            this.lblNume.Size = new Size(170, 25);
            this.lblNume.Text=customer.getFirstName().ToString()+" "+customer.getLastName().ToString();
            this.lblNume.Font=new Font("Regular", 12, FontStyle.Regular);

            this.lblEmail=new Label();
            this.Controls.Add(this.lblEmail);
            this.lblEmail.Location = new Point(350, 315);
            this.lblEmail.Size = new Size(300, 25);
            this.lblEmail.Text=customer.getEmail().ToString();
            this.lblEmail.Font=new Font("Regular", 12, FontStyle.Regular);

            this.lblTelefon=new Label();
            this.Controls.Add(this.lblTelefon);
            this.lblTelefon.Location = new Point(350, 360);
            this.lblTelefon.Size = new Size(300, 25);
            this.lblTelefon.Text="+40 "+customer.getPhoneNumber().ToString();
            this.lblTelefon.Font=new Font("Regular", 12, FontStyle.Regular);

            this.lblAsideParola=new Label();
            this.Controls.Add(this.lblAsideParola);
            this.lblAsideParola.Location = new Point(950, 270);
            this.lblAsideParola.Size = new Size(80, 25);
            this.lblAsideParola.Text="parola:";
            this.lblAsideParola.Font=new Font("Regular", 12, FontStyle.Regular);

            this.lblParola=new Label();
            this.Controls.Add(this.lblParola);
            this.lblParola.Location = new Point(1050, 260);
            this.lblParola.Size=new Size(120, 38);
            this.lblParola.Text="............";
            this.lblParola.Font=new Font("Regular", 16, FontStyle.Regular);

            this.btnEditeazaDatele=new RoundedButton();
            this.Controls.Add(this.btnEditeazaDatele);
            this.btnEditeazaDatele.Location=new Point(246, 420);
            this.btnEditeazaDatele.Size=new Size(240, 60);
            this.btnEditeazaDatele.Text="Editeaza datele";
            this.btnEditeazaDatele.ForeColor=Color.Red;
            this.btnEditeazaDatele.FlatAppearance.BorderSize=0;
            this.btnEditeazaDatele.FlatStyle=FlatStyle.Flat;
            this.btnEditeazaDatele.Font=new Font("Cascadia Mono", 12, FontStyle.Regular);

            this.btnEditeazaParola=new RoundedButton();
            this.Controls.Add(this.btnEditeazaParola);
            this.btnEditeazaParola.Location=new Point(950, 330);
            this.btnEditeazaParola.Size=new Size(240, 60);
            this.btnEditeazaParola.Text="Editeaza parola";
            this.btnEditeazaParola.ForeColor=Color.Red;
            this.btnEditeazaParola.FlatAppearance.BorderSize=0;
            this.btnEditeazaParola.FlatStyle=FlatStyle.Flat;
            this.btnEditeazaParola.Font=new Font("Cascadia Mono", 12, FontStyle.Regular);



        }







    }
}
