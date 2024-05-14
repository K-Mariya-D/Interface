using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTutorInterface
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();

            var text = new Label();

            var FormSize = this.Size ;

            text.Location = new Point((FormSize.Width - text.Width) / 2 , 120 );  
        }
    }
}
