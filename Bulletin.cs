using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Bulletin : UserControl
    {
        public Bulletin()
        {
            InitializeComponent();

            for (int i = 0; i < 100; ++i)
            {
                flowLayoutPanel1.Controls.Add(new BulletinCard());
            }
        }
    }
}
