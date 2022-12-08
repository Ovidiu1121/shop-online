using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class PnlChooseProduct:Panel
    {
        FrmHome frmHome;
        ComboBox comboBox;
        ControlProduct controlProduct=new ControlProduct();

        public PnlChooseProduct(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(0, 70);
            this.Size = new Size(810, 48);
            this.BackColor=Color.Red;
            this.Anchor = AnchorStyles.Top| AnchorStyles.Left | AnchorStyles.Right;
            this.Name="pnlChooseProduct";

            this.comboBox = new ComboBox();
            this.Controls.Add(this.comboBox);
            this.comboBox.Location = new Point(-472, 7);
            this.comboBox.Size = new Size(151, 28);
            this.comboBox.Text="Produse";
            this.comboBox.Anchor=AnchorStyles.None;
            this.populateCmbBox();


        }

        private void populateCmbBox()
        {

            List<string> categories = this.controlProduct.getAllCategories();

            foreach(string category in categories)
            {
               this.comboBox.Items.Add(category);   
            }

        }




    }
}
