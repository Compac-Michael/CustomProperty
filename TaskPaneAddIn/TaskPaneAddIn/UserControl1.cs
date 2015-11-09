using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TaskPaneAddIn
{
    [ComVisible(true)]
    [ProgId("Compac_CustomProperty_TaskPane")]
    public partial class UserControl1 : UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
        }
    }
}
