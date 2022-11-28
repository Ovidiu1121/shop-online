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

        public PnlChooseProduct(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(0, 79);
            this.Size = new Size(799, 44);
            this.BackColor = Color.Beige;
            this.Anchor = AnchorStyles.Top| AnchorStyles.Left | AnchorStyles.Right;

            this.comboBox = new ComboBox();
            this.Controls.Add(this.comboBox);
            this.comboBox.Location = new Point(40, 7);
            this.comboBox.Size = new Size(151, 28);
            this.comboBox.Text="Produse";
            this.comboBox.Anchor=AnchorStyles.None;


        }

    }
}
