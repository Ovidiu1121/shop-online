using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlHeader:Panel
    {

        FrmHome frmHome;
        TextBox txtBox;
        FontAwesome.Sharp.IconButton btnSearch;
        FontAwesome.Sharp.IconButton btnCont;
        FontAwesome.Sharp.IconButton btnFavorite;
        FontAwesome.Sharp.IconButton btnCos; 
        PictureBox pictureBox;

        public PnlHeader(FrmHome frmHome)
        {

            this.frmHome = frmHome;
            this.Location = new Point(0, -3);
            this.Size =new Size(frmHome.Width, 70);
            this.BackColor = Color.White;
            this.Name="pnlHeader";
            this.Dock = DockStyle.Top;

            this.pictureBox = new PictureBox();
            this.Controls.Add(this.pictureBox);
            this.pictureBox.Image=Image.FromFile(Application.StartupPath +@"/Logos-Icons/altex.png");
            this.pictureBox.Location = new Point(85, 15);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.txtBox = new TextBox();
            this.Controls.Add(this.txtBox);
            this.txtBox.Location = new Point(200, 31);
            this.txtBox.Size = new Size(600, 27);
            this.txtBox.PlaceholderText="Cauta produsul dorit";

            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtBox.Controls.Add(this.btnSearch);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Location = new Point(this.txtBox.Width-40,-1);
            this.btnSearch.Size = new Size(37, 27);
            this.btnSearch.IconChar=FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconSize=25;

            this.btnCont = new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btnCont);
            this.btnCont.Location = new Point(280, 31);
            this.btnCont.Size = new Size(129, 30);
            this.btnCont.FlatStyle = FlatStyle.Flat;
            this.btnCont.FlatAppearance.BorderSize = 0;
            this.btnCont.Text="Contul meu";
            this.btnCont.Anchor=AnchorStyles.Right;
            this.btnCont.IconChar=FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCont.IconSize=30;
            this.btnCont.TextImageRelation=TextImageRelation.ImageBeforeText;

            this.btnCos = new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btnCos);
            this.btnCos.Location = new Point(600, 31);
            this.btnCos.Size = new Size(129, 30);
            this.btnCos.Text="Cosul meu";
            this.btnCos.FlatAppearance.BorderSize = 0;  
            this.btnCos.FlatStyle = FlatStyle.Flat;
            this.btnCos.Anchor=AnchorStyles.Right;
            this.btnCos.IconChar=FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCos.IconSize=30;
            this.btnCos.TextImageRelation = TextImageRelation.ImageBeforeText;


            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btnFavorite);
            this.btnFavorite.Location = new Point(450, 31);
            this.btnFavorite.Size = new Size(129, 30);
            this.btnFavorite.Text="Favorite";
            this.btnFavorite.FlatStyle = FlatStyle.Flat;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.Anchor=AnchorStyles.Right;
            this.btnFavorite.IconChar=FontAwesome.Sharp.IconChar.Heart;
            this.btnFavorite.IconSize=30;
            this.btnFavorite.TextImageRelation=TextImageRelation.ImageBeforeText;

        }


    }
}
