using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRMS.Forms
{
    public partial class Wait : Form
    {
        public Wait()
        {
            InitializeComponent();
            pb_wait.Enabled = pb_wait.Visible = true;
        }
    }
}
