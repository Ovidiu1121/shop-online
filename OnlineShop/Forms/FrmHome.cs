using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class FrmHome : Form
    {
        public Panel activePanel;
        public Panel header;
        public Panel chooseProduct;
        public FrmHome()
        {
            InitializeComponent();

            this.header = new PnlHeader(this);
            this.chooseProduct=new PnlChooseProduct(this);
            this.activePanel=new PnlProductsMain(this);

            this.Controls.Add(header);
            this.Controls.Add(chooseProduct);
            this.Controls.Add(activePanel);
            
        }

        public void erase(String name)
        {
            Control aux = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(name))
                {
                    aux=c;
                }
            }

            this.Controls.Remove(aux);
        }

    }
}
