using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlContulMeu : Panel
    {
        Label lblTitle1;
        Label lblTitle2;
        Label lblTitle3;
        Label lblAside1;
        Label lblAside2;
        Label lblAside3;
        Label lblPrenume;
        Label lblNume;
        Label lblAdresaEmail1;
        Label lblAdresaEmail2;
        Label lblParola1;
        Label lblParola2;
        Label lblConfirmParola;
        Label lblPhone;
        TextBox txtParola1;
        TextBox txtParola2;
        TextBox txtConfirmPArola;
        TextBox txtPrenume;
        TextBox txtNume;
        TextBox txtAdresaEmail1;
        TextBox txtAdresaEmail2;
        TextBox txtPhone;
        RoundedButton btnInregistrare;
        RoundedButton btnLogIn;
        CheckBox checkBox;
        FrmHome frmHome;
        Customer customer;
        FontAwesome.Sharp.IconButton icon1;
        FontAwesome.Sharp.IconButton icon2;
        FontAwesome.Sharp.IconButton icon3;
        ControlCustomer controlCustomer = new ControlCustomer();
        Panel a;
        Panel b;
        private ControlOrderDetails controlOrderDetails=new ControlOrderDetails();

        public PnlContulMeu(FrmHome frmHome)
        {
            a=frmHome.header;
            b=frmHome.chooseProduct;
            if (frmHome.logat==false)
            {
                //a.Enabled=false;
                //b.Enabled=false;
            }
            else
            {
                a.Enabled = true;
                b.Enabled = true;
            }

            this.frmHome = frmHome;
            this.Name="pnlContulMeu";
            this.Location = new Point(0, 120);
            this.Size = new Size(1950, 1000);
            this.BackColor = Color.White;
            this.Dock= DockStyle.Fill;

            this.lblTitle1 = new Label();
            this.Controls.Add(this.lblTitle1);
            this.lblTitle1.Location = new Point(100, 200);
            this.lblTitle1.Size = new Size(400, 31);
            this.lblTitle1.Text="De ce sa iti creezi cont?";
            this.lblTitle1.Font=new Font("Arial", 18, FontStyle.Bold);

            this.icon1=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.icon1);
            this.icon1.IconChar=FontAwesome.Sharp.IconChar.Splotch;
            this.icon1.IconSize=30;
            this.icon1.Location=new Point(100, 300);
            this.icon1.Enabled=false;
            this.icon1.Size=new Size(39, 29);
            this.icon1.FlatAppearance.BorderSize=0;
            this.icon1.FlatStyle=FlatStyle.Flat;

            this.lblAside1=new Label();
            this.Controls.Add(this.lblAside1);
            this.lblAside1.Location=new Point(150, 300);
            this.lblAside1.Size=new Size(300, 100);
            this.lblAside1.Text="Reduci timpul de finalizare \n a comenzii prin salvarea datelor \n de facturare, livrare si plata";
            this.lblAside1.Font=new Font("Arial", 12, FontStyle.Regular);

            this.icon2=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.icon2);
            this.icon2.IconChar=FontAwesome.Sharp.IconChar.Splotch;
            this.icon2.IconSize=30;
            this.icon2.Location=new Point(100, 400);
            this.icon2.Enabled=false;
            this.icon2.Size=new Size(39, 29);
            this.icon2.FlatAppearance.BorderSize=0;
            this.icon2.FlatStyle=FlatStyle.Flat;

            this.lblAside2=new Label();
            this.Controls.Add(this.lblAside2);
            this.lblAside2.Location=new Point(150, 400);
            this.lblAside2.Size=new Size(300, 50);
            this.lblAside2.Text="Verifici situatia comenzilor tale";
            this.lblAside2.Font=new Font("Arial", 12, FontStyle.Regular);

            this.icon3=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.icon3);
            this.icon3.IconChar=FontAwesome.Sharp.IconChar.Splotch;
            this.icon3.IconSize=30;
            this.icon3.Location=new Point(100, 450);
            this.icon3.Enabled=false;
            this.icon3.Size=new Size(39, 29);
            this.icon3.FlatAppearance.BorderSize=0;
            this.icon3.FlatStyle=FlatStyle.Flat;

            this.lblAside3=new Label();
            this.Controls.Add(this.lblAside3);
            this.lblAside3.Location=new Point(150, 450);
            this.lblAside3.Size=new Size(300, 100);
            this.lblAside3.Text="Salvezi produse in wishlist \n si faci liste de cumparaturi";
            this.lblAside3.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblTitle2=new Label();
            this.Controls.Add(this.lblTitle2);
            this.lblTitle2.Location = new Point(800, 200);
            this.lblTitle2.Size = new Size(300, 31);
            this.lblTitle2.Text="Vreau un cont nou";
            this.lblTitle2.Font=new Font("Arial", 18, FontStyle.Bold);

            this.lblTitle3=new Label();
            this.Controls.Add(this.lblTitle3);
            this.lblTitle3.Location = new Point(1500, 200);
            this.lblTitle3.Size = new Size(300, 40);
            this.lblTitle3.Text="Am deja cont";
            this.lblTitle3.Font=new Font("Arial", 18, FontStyle.Bold);

            this.lblPrenume=new Label();
            this.Controls.Add(this.lblPrenume);
            this.lblPrenume.Location = new Point(760, 270);
            this.lblPrenume.Size = new Size(90, 17);
            this.lblPrenume.Text="Prenume *";
            this.lblPrenume.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtPrenume=new TextBox();
            this.Controls.Add(this.txtPrenume); ;
            this.txtPrenume.Location = new Point(760, 300);
            this.txtPrenume.Width=400;
            this.txtPrenume.BorderStyle=BorderStyle.FixedSingle;

            this.lblNume=new Label();
            this.Controls.Add(this.lblNume);
            this.lblNume.Location = new Point(760, 350);
            this.lblNume.Size = new Size(90, 17);
            this.lblNume.Text="Nume *";
            this.lblNume.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtNume=new TextBox();
            this.Controls.Add(this.txtNume);
            this.txtNume.Location = new Point(760, 380);
            this.txtNume.Width=400;
            this.txtNume.BorderStyle=BorderStyle.FixedSingle;

            this.lblAdresaEmail1 = new Label();
            this.Controls.Add(this.lblAdresaEmail1);
            this.lblAdresaEmail1.Location = new Point(760, 430);
            this.lblAdresaEmail1.Size = new Size(150, 17);
            this.lblAdresaEmail1.Text="Adresa de email *";
            this.lblAdresaEmail1.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtAdresaEmail1=new TextBox();
            this.Controls.Add(this.txtAdresaEmail1);
            this.txtAdresaEmail1.Location = new Point(760, 460);
            this.txtAdresaEmail1.Width=400;
            this.txtAdresaEmail1.BorderStyle=BorderStyle.FixedSingle;

            this.lblPhone=new Label();
            this.Controls.Add(this.lblPhone);
            this.lblPhone.Location = new Point(760, 510);
            this.lblPhone.Size = new Size(150, 17);
            this.lblPhone.Text="Numar de telefon *";
            this.lblPhone.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtPhone=new TextBox();
            this.Controls.Add(this.txtPhone);
            this.txtPhone.Location = new Point(760, 540);
            this.txtPhone.Width=400;
            this.txtPhone.BorderStyle=BorderStyle.FixedSingle;

            this.lblParola1 = new Label();
            this.Controls.Add(this.lblParola1);
            this.lblParola1.Location = new Point(760, 590);
            this.lblParola1.Size = new Size(70, 17);
            this.lblParola1.Text="Parola *";
            this.lblParola1.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtParola1=new TextBox();
            this.Controls.Add(this.txtParola1);
            this.txtParola1.Location = new Point(760, 620);
            this.txtParola1.Width=400;
            this.txtParola1.BorderStyle=BorderStyle.FixedSingle;

            this.lblConfirmParola = new Label();
            this.Controls.Add(this.lblConfirmParola);
            this.lblConfirmParola.Location = new Point(760, 670);
            this.lblConfirmParola.Size = new Size(150, 17);
            this.lblConfirmParola.Text="Confirma parola *";
            this.lblConfirmParola.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtConfirmPArola=new TextBox();
            this.Controls.Add(this.txtConfirmPArola);
            this.txtConfirmPArola.Location = new Point(760, 700);
            this.txtConfirmPArola.Width=400;
            this.txtConfirmPArola.BorderStyle=BorderStyle.FixedSingle;

            this.checkBox=new CheckBox();
            this.Controls.Add(this.checkBox);
            this.checkBox.Location=new Point(760, 750);
            this.checkBox.Text="Sunt de acord cu Termenii si conditiile \nde utilizare a site-ului altex.ro";
            this.checkBox.Size = new Size(350, 60);
            this.checkBox.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnInregistrare=new RoundedButton();
            this.Controls.Add(this.btnInregistrare);
            this.btnInregistrare.Location=new Point(760, 820);
            this.btnInregistrare.Size = new Size(400, 80);
            this.btnInregistrare.Text="Inregistrare";
            this.btnInregistrare.ForeColor=Color.White;
            this.btnInregistrare.BackColor=Color.Red;
            this.btnInregistrare.FlatStyle=FlatStyle.Flat;
            this.btnInregistrare.Font=new Font("Cascadia Mono", 14, FontStyle.Regular);
            this.btnInregistrare.Click+=new EventHandler(this.inregistrare_Click);

            this.lblAdresaEmail2=new Label();
            this.Controls.Add(this.lblAdresaEmail2);
            this.lblAdresaEmail2.Location=new Point(1400, 270);
            this.lblAdresaEmail2.Size=new Size(150, 17);
            this.lblAdresaEmail2.Text="Adresa de email *";
            this.lblAdresaEmail2.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtAdresaEmail2=new TextBox();
            this.Controls.Add(this.txtAdresaEmail2);
            this.txtAdresaEmail2.Location = new Point(1400, 300);
            this.txtAdresaEmail2.Width=400;
            this.txtAdresaEmail2.BorderStyle=BorderStyle.FixedSingle;

            this.lblParola2=new Label();
            this.Controls.Add(this.lblParola2);
            this.lblParola2.Location=new Point(1400, 350);
            this.lblParola2.Size=new Size(80, 17);
            this.lblParola2.Text="Parola *";
            this.lblParola2.Font=new Font("Arial", 10, FontStyle.Regular);

            this.txtParola2=new TextBox();
            this.Controls.Add(this.txtParola2);
            this.txtParola2.Location = new Point(1400, 380);
            this.txtParola2.Width=400;
            this.txtParola2.BorderStyle=BorderStyle.FixedSingle;

            this.btnLogIn=new RoundedButton();
            this.Controls.Add(this.btnLogIn);
            this.btnLogIn.Location=new Point(1400, 440);
            this.btnLogIn.Size=new Size(400, 80);
            this.btnLogIn.ForeColor=Color.White;
            this.btnLogIn.BackColor=Color.Red;
            this.btnLogIn.FlatStyle=FlatStyle.Flat;
            this.btnLogIn.Text="Logheaza-te in cont";
            this.btnLogIn.Font=new Font("Cascadia Mono", 14, FontStyle.Regular);
            this.btnLogIn.Click+=new EventHandler(this.logare_Click);

        }

        public void inregistrare_Click(object sender, EventArgs e)
        {

            if (this.txtNume.Text.Equals("")==false&&this.txtPrenume.Text.Equals("")==false&&this.txtAdresaEmail1.Text.Equals("")==false&&this.txtPhone.Text.Equals("")==false&&this.txtParola1.Text.Equals("")==false&&this.txtConfirmPArola.Text.Equals("")==false)
            {
                if (this.controlCustomer.isEmail(this.txtAdresaEmail1.Text)==false)
                {

                    if (this.txtParola1.Text.Equals(this.txtConfirmPArola.Text)==true)
                    {
                        this.controlOrderDetails.deleteAll();
                        this.controlOrderDetails.salvareFisier();
                        a.Enabled=true;
                        b.Enabled=true;
                        Customer customer = new Customer(this.controlCustomer.generateNextId(), this.txtAdresaEmail1.Text, this.txtParola1.Text, this.txtNume.Text, this.txtPrenume.Text, int.Parse(this.txtPhone.Text)); 
                        this.controlCustomer.add(customer);
                        this.controlCustomer.salvareFisier();
                        this.frmHome.setCustomer(customer);

                        this.frmHome.Controls.Remove(this.frmHome.activePanel);
                        this.frmHome.activePanel=new PnlInfoContulMeu(this.frmHome, customer);
                        this.frmHome.Controls.Add(this.frmHome.activePanel);

                    }
                    else
                    {
                        MessageBox.Show("Trebuie utilizata aceasi parola.");
                    }
                }
                else
                {
                    MessageBox.Show("Aceasta adresa de email este asociata unui cont existent.");
                }

            }
            else if (this.txtNume.Text.Equals("")==true||this.txtPrenume.Text.Equals("")==true||this.txtAdresaEmail1.Text.Equals("")==true||this.txtPhone.Text.Equals("")==true||this.txtParola1.Text.Equals("")==true||this.txtConfirmPArola.Text.Equals("")==true)
            {
                MessageBox.Show("Exista camp necompletat", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        public void logare_Click(object sender, EventArgs e)
        {
            
            if (this.txtAdresaEmail2.Text.Equals("")==false&&this.txtParola2.Text.Equals("")==false)
            {
                if (controlCustomer.isEmail(this.txtAdresaEmail2.Text)==true&&this.controlCustomer.isParolaByEmail(this.txtAdresaEmail2.Text, this.txtParola2.Text)==true)
                {
                    this.controlOrderDetails.deleteAll();
                    this.controlOrderDetails.salvareFisier();
                    a.Enabled=true;
                    b.Enabled=true;
                    Customer customer =this.controlCustomer.getCustomerByEmail(this.txtAdresaEmail2.Text);
                    this.frmHome.Controls.Remove(this.frmHome.activePanel);
                    this.frmHome.activePanel=new PnlInfoContulMeu(this.frmHome, customer);
                    this.frmHome.Controls.Add(this.frmHome.activePanel);

                    this.frmHome.setCustomer(customer);
                    this.frmHome.logat=true;
                }
                else
                {
                    MessageBox.Show("Email sau parola invalida.");
                }

            }
            else if (this.txtAdresaEmail2.Text.Equals("")==true||this.txtParola2.Text.Equals("")==true)
            {
                MessageBox.Show("Exista camp necompletat", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
