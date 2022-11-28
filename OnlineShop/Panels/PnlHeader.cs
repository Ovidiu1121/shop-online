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
        Button btnSearch;
        Button btnCont;
        Button btnFavorite;
        Button btnCos;

        public PnlHeader(FrmHome frmHome)
        {

            this.frmHome = frmHome;
            this.Location = new Point(12,20);
            this.Size =new Size(frmHome.Width, 70);
                this.BackColor = Color.White;

            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

            this.txtBox = new TextBox();
            this.Controls.Add(this.txtBox);
            this.txtBox.Text="Cauta produsul dorit";
            this.txtBox.Location = new Point(85, 31);
            this.txtBox.Size = new Size(195, 27);
         

            this.btnSearch = new Button();
            this.Controls.Add(this.btnSearch);
            this.btnSearch.Text="X";
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Location = new Point(286, 31);
            this.btnSearch.Size = new Size(42, 27);
       
            this.btnCont = new Button();
            this.Controls.Add(this.btnCont);
            this.btnCont.Location = new Point(377, 31);
            this.btnCont.Size = new Size(105, 29);
            this.btnCont.FlatStyle = FlatStyle.Flat;
            this.btnCont.FlatAppearance.BorderSize = 0;
            this.btnCont.Text="Contul meu";
          

            this.btnCos = new Button();
            this.Controls.Add(this.btnCos);
            this.btnCos.Location = new Point(657, 31);
            this.btnCos.Size = new Size(94, 29);
            this.btnCos.Text="Cosul meu";
            this.btnCos.FlatAppearance.BorderSize = 0;  
            this.btnCos.FlatStyle = FlatStyle.Flat;
          

            this.btnFavorite = new Button();
            this.Controls.Add(this.btnFavorite);
            this.btnFavorite.Location = new Point(520, 31);
            this.btnFavorite.Size = new Size(94, 29);
            this.btnFavorite.Text="Favorite";
            this.btnFavorite.FlatStyle = FlatStyle.Flat;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
        

        }


    }
}
